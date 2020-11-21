using CHAT___Algorithms;
using CHAT___API.Models;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHAT___API.Storage
{
    public class DBManagement
    {
        private IMongoDatabase db;

        public DBManagement()
        {
            var client = new MongoClient();
            db = client.GetDatabase("local");
        }

        public bool ExistUser(string user)
        {
            var usersDB = db.GetCollection<UserModel>("users");
            List<UserModel> result = usersDB.Find(x => x.UserName == user).ToList();
            if (result.Count() == 0) return false;
            return true;
        }
        public bool InsertUser(UserModel user)
        {
            var usersDB = db.GetCollection<UserModel>("users");
            user.Key = GetNewKey();
            user.Password = EncryptPassword(user.Password);
            usersDB.InsertOne(user);
            return true;
        }
        public bool ValidateCredentials(string user, string password)
        {
            var usersDB = db.GetCollection<UserModel>("users");
            List<UserModel> result = usersDB.Find(x => x.UserName == user).ToList();
            if (EncryptPassword(password) == result[0].Password) return true;
            return false;
        }
        public List<string> GetUsersID(string user)
        {
            var usersDB = db.GetCollection<UserModel>("users");
            List<UserModel> users_result = usersDB.Find(x => x.UserName != user).ToList();
            List<string> result = new List<string>();
            for (int i = 0; i < users_result.Count; i++)
            {
                result.Add(users_result[i].UserName);
            }
            return result;
        }

        private int GetNewKey()
        {
            var usersDB = db.GetCollection<UserModel>("users");
            List<UserModel> result = usersDB.Find(x => true).ToList();
            List<int> keys = new List<int>();
            for (int i = 0; i < result.Count; i++)
            {
                keys.Add(result[i].Key);
            }

            bool isnew = false;
            int key_new = 0;
            while (isnew != true)
            {
                key_new = new Random().Next(100);
                if (!keys.Contains(key_new)) isnew = true;
            }
            return key_new;
        }
        private string EncryptPassword(string password)
        {
            SDES sdes = new SDES();
            sdes.SetKeys(10);

            byte[] password_encrypted = sdes.EncryptText(ConvertToByte(password));
            return ConvertToString(password_encrypted);
        }
        private byte[] ConvertToByte(string content)
        {
            byte[] array = new byte[content.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToByte(content[i]);
            }
            return array;
        }
        private string ConvertToString(byte[] content)
        {
            string result = "";
            for (int i = 0; i < content.Length; i++)
            {
                result += Convert.ToChar(content[i]);
            }
            return result;
        }

        public bool SaveMessage(MessageModel message)
        {
            var messagesDB = db.GetCollection<MessageModel>("messages");
            message = EncryptMessage(message);
            messagesDB.InsertOne(message);
            return true;
        }
        
        public List<MessageModel> GetMessages(string user1, string user2)
        {
            var messagesDB = db.GetCollection<MessageModel>("messages");
            List<MessageModel> messages_result = messagesDB.Find(x => (x.Transmitter == user1 && x.Receiver == user2) || (x.Transmitter == user2 && x.Receiver == user1)).ToList().OrderBy(x=>x.Date).ToList();
            List<MessageModel> result = new List<MessageModel>(messages_result.Count);
            for (int i = 0; i < messages_result.Count; i++)
            {
                result.Add(DecryptMessage(messages_result[i]));
            }
            return result;
            /**Si lo anterior no funciona usar 
            //List<MessageModel> list = messagesDB.Find(x => x.Transmitter == user1.UserName && x.Receiver==user2.UserName).ToList();
            //List<MessageModel> list2 = messagesDB.Find(x => x.Transmitter == user2.UserName && x.Receiver == user1.UserName).ToList();
            //List<MessageModel> result = list.Concat(list2).ToList().OrderByDescending(x => x.Date).ToList();
            return messages_result;**/
        }
        
        public MessageModel DecryptMessage(MessageModel message)
        {
            var usersDB = db.GetCollection<UserModel>("users");
            int trasnmitter_key = usersDB.Find(x => x.UserName == message.Transmitter).ToList()[0].Key;
            int receiver_key = usersDB.Find(x => x.UserName == message.Receiver).ToList()[0].Key;

            DiffieHellman df = new DiffieHellman();
            int publickey = df.GetPublicKey(trasnmitter_key);
            int commonkey = df.GetCommonKey(publickey, receiver_key);

            SDES sdes = new SDES();
            sdes.SetKeys(commonkey);

            message.Content = ConvertToString(sdes.DecryptText(ConvertToByte(message.Content)));

            return message;
        }
        public MessageModel EncryptMessage(MessageModel message)
        {
            var usersDB = db.GetCollection<UserModel>("users");
            int trasnmitter_key = usersDB.Find(x => x.UserName == message.Transmitter).ToList()[0].Key;
            int receiver_key = usersDB.Find(x => x.UserName == message.Receiver).ToList()[0].Key;

            DiffieHellman df = new DiffieHellman();
            int publickey = df.GetPublicKey(trasnmitter_key);
            int commonkey = df.GetCommonKey(publickey, receiver_key);

            SDES sdes = new SDES();
            sdes.SetKeys(commonkey);
            message.Content = ConvertToString(sdes.EncryptText(ConvertToByte(message.Content)));

            return message;
        }
    }
}

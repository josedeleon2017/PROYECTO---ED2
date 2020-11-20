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
            bool[] key = new bool[10] { true, true, false, true, false, true, true, false, false, true };
            BitArray bits = new BitArray(key);
            sdes.SetKeys(bits);

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
            messagesDB.InsertOne(message);
            return true;
        }
    }
}

using CHAT___Algorithms;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CHAT___TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --- PRUEBAS ---");
            Console.WriteLine("\nIngrese el primer usuario");
            string user1 = Console.ReadLine();
            Console.WriteLine("\nIngrese el segundo usuario");
            string user2 = Console.ReadLine();



            GetUsers(user1.ToUpper(), user2.ToUpper());
            Console.ReadLine();


            SDESProcess(user1.ToUpper(), user2.ToUpper());
            Environment.Exit(0);
        }
        public static void DiffieHellmanProcess(int a, int b)
        {
            Console.WriteLine("\n --- Diffie Hellman ---");

            DiffieHellman df = new DiffieHellman();
            int A = df.GetPublicKey(a);
            int B = df.GetPublicKey(b);

            Console.WriteLine($"\nA = g^({a}) mod p = " + A + "     ---------> A --------->     " + $"B = g^({b}) mod p = " + B);

            int K1 = df.GetCommonKey(A, b);
            int K2 = df.GetCommonKey(B, a);

            Console.WriteLine($"\nK = {B}^({a}) mod p = " + K1 + "    <--------- B <---------     " + $"K = {A}^({b}) mod p = " + K2);

        }

        public static void SDESProcess(string user1, string user2)
        {
            int exit = 1;

            while (exit == 1)
            {
                Console.Clear();
                Console.WriteLine(" --- PRUEBAS ---");
                Console.WriteLine("\n --- MongoDB ---");
                var client = new MongoClient("mongodb://localhost:27017");
                var db = client.GetDatabase("local");
                var messagesDB = db.GetCollection<MessageModel>("messages");
                List<MessageModel> result1 = messagesDB.Find(x => (x.Transmitter == user1 && x.Receiver == user2 && x.Type == 1) || (x.Transmitter == user2 && x.Receiver == user1 && x.Type == 1)).ToList().OrderBy(x => x.Date).ToList();
                for (int i = 0; i < result1.Count; i++)
                {
                    Console.WriteLine((i + 1) + ") " + result1[i].Transmitter + " | " + result1[i].Receiver + " | " + result1[i].Id + " | " + result1[i].Date);
                }
                Console.WriteLine("\nIngrese el número del mensaje a descrifrar");
                int option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nIngrese la llave");
                int key = Convert.ToInt32(Console.ReadLine());

                SDES sdes = new SDES();
                sdes.SetKeys(key);

                Console.WriteLine($"\nMensaje cifrado\n{result1[option - 1].Content}\n\nMensaje descifrado\n{ConvertToString(sdes.DecryptText(ConvertToByte(result1[option - 1].Content)))}");

                Console.WriteLine("\n¿Desea descifrar otro mensaje? (1) Sí (0) No");
                exit = Convert.ToInt32(Console.ReadLine());
            }

        }

        public static byte[] ConvertToByte(string content)
        {
            byte[] array = new byte[content.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToByte(content[i]);
            }
            return array;
        }
        public static string ConvertToString(byte[] content)
        {
            string result = "";
            for (int i = 0; i < content.Length; i++)
            {
                result += Convert.ToChar(content[i]);
            }
            return result;
        }
        public static void GetUsers(string user1, string user2)
        {
            Console.WriteLine("\n --- MongoDB ---\n");
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("local");
            var usersDB = db.GetCollection<UserModel>("users");

            UserModel result1 = usersDB.Find(x => x.UserName == user1).ToList()[0];
            Console.WriteLine(result1.UserName);
            Console.WriteLine(result1.Id);
            Console.WriteLine("\ta -> " + result1.Key);

            UserModel result2 = usersDB.Find(x => x.UserName == user2).ToList()[0];
            Console.WriteLine("\n" + result2.UserName);
            Console.WriteLine(result2.Id);
            Console.WriteLine("\tb -> " + result2.Key);
            DiffieHellmanProcess(result1.Key, result2.Key);
        }

    }


    public class MessageModel
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement("transmitter")]
        public string Transmitter { get; set; }
        [BsonElement("receiver")]
        public string Receiver { get; set; }
        [BsonElement("content")]
        public string Content { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("date")]
        public DateTime Date { get; set; }
        [BsonElement("type")]
        public int Type { get; set; }

        [BsonElement("registerName")]
        public string RegisterName { get; set; }
    }

    public class UserModel
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement("user")]
        public string UserName { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }
        [BsonElement("key")]
        public int Key { get; set; }
    }
}

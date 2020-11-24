using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CHAT___Algorithms
{
    public class LZW
    {
        Dictionary<int, List<byte>> Decode = new Dictionary<int, List<byte>>();
        Dictionary<string, int> Encode = new Dictionary<string, int>();
        private List<int> index = new List<int>();
        private int LengtPrincipalDictionary { get; set; }
        private double original_weight { get; set; }
        private double compressed_weight { get; set; }
        private int binaryMax { get; set; }


        public double ReductionPercentage()
        {
            return 1 - (compressed_weight / original_weight);
        }
        public double CompressionFactor()
        {
            return (original_weight / compressed_weight);
        }
        public double CompressionRatio()
        {
            return (compressed_weight / original_weight);
        }

        #region Encode
        public byte[] EncodeData(byte[] content)
        {
            StringBuilder cadenaDeBytes = new StringBuilder();

            foreach (var item in content)
            {
                if (!Encode.ContainsKey(item.ToString()))
                {
                    Encode.Add(item.ToString(), Encode.Count + 1);
                }
            }
            LengtPrincipalDictionary = Encode.Count();

            int contador = 0;
            for (int i = 0; i < content.Length; i++)
            {

                if (cadenaDeBytes.ToString() == "")
                {
                    cadenaDeBytes.Append(content[i]);
                }
                else
                {
                    cadenaDeBytes.Append("/");
                    cadenaDeBytes.Append(content[i]);
                }
                contador++;
                if (!Encode.ContainsKey(cadenaDeBytes.ToString()))
                {
                    Encode.Add(cadenaDeBytes.ToString(), Encode.Count + 1);
                    GetIndex(cadenaDeBytes.ToString());
                    cadenaDeBytes.Clear();
                    i--;
                }
            }
            if (Encode.ContainsKey(cadenaDeBytes.ToString()))
                index.Add(Encode[cadenaDeBytes.ToString()]);
            original_weight = content.Length;
            return GetBytes();
        }
        void GetIndex(string cadenaByte)
        {
            StringBuilder key = new StringBuilder();
            List<string> split = cadenaByte.Split("/").ToList();
            try
            {

                split.RemoveAt(split.Count() - 1);
                if (split.Count > 1)
                {
                    for (int i = 0; i < split.Count; i++)
                    {
                        if (key.ToString() == "")
                        {
                            key.Append(split[i]);
                        }
                        else
                        {
                            key.Append("/");
                            key.Append(split[i]);
                        }
                    }
                }
                else
                {
                    key.Append(split[0]);
                }
                if (cadenaByte.ToString() != "")
                {
                    var nf = Encode[key.ToString()];
                    index.Add(nf);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }// agraga valores ala lista de claves
        byte[] GetBytes()
        {
            List<byte> finalCompression = new List<byte>();
            string binaryCode = "";
            binaryMax = Convert.ToString(index.Max(), 2).Length;
            foreach (var item in index)
            {

                binaryCode += Convert.ToString(item, 2).PadLeft(binaryMax, '0');
                while (binaryCode.Length > 8)
                {
                    finalCompression.Add(Convert.ToByte(binaryCode.Substring(0, 8), 2));
                    binaryCode = binaryCode.Remove(0, 8);
                }
            }
            if (binaryCode.Length > 0 && binaryCode.Length < 8)
            {
                finalCompression.Add(Convert.ToByte(binaryCode.PadRight(8, '0'), 2));
                binaryCode = "";
            }
            else if (binaryCode.Length == 8)
            {
                finalCompression.Add(Convert.ToByte(binaryCode, 2));
            }
            AddMetaData(finalCompression, binaryMax);
            compressed_weight = finalCompression.Count;
            return finalCompression.ToArray();
        } // Comprime la lista de claves 
        void AddMetaData(List<byte> finalCompression, int longitudDeBits)
        {
            var key = Encode.Keys.ToList();

            if (key.Count > 0)
            {
                for (int i = LengtPrincipalDictionary - 1; i >= 0; i--)
                {
                    var item = int.Parse(key[i]);
                    finalCompression.Insert(0, Convert.ToByte(item));
                }
                finalCompression.Insert(0, Convert.ToByte(LengtPrincipalDictionary));
                finalCompression.Insert(0, Convert.ToByte(longitudDeBits));
            }
        }
        #endregion

        #region Decode
        public byte[] DecodeData(byte[] Content)
        {
            List<byte> content = GetMetadata(Content);
            List<byte> decodeContent = new List<byte>();
            List<byte> nuevaCadena = new List<byte>();
            List<byte> cadenaSalida = new List<byte>();
            GetIndex(content, binaryMax);
            byte newCaracter;
            int keyOld;
            int keyNew;

            keyOld = index[0];
            cadenaSalida.AddRange(Decode[keyOld]);
            newCaracter = cadenaSalida[0];
            decodeContent.AddRange(cadenaSalida);
            for (int i = 1; i < index.Count; i++)
            {
                keyNew = index[i];
                if (!Decode.ContainsKey(keyNew))
                {
                    cadenaSalida.AddRange(Decode[keyOld]);
                    cadenaSalida.Add(newCaracter);
                }
                else
                {
                    cadenaSalida = Decode[keyNew];
                }
                decodeContent.AddRange(cadenaSalida);
                nuevaCadena.AddRange(Decode[keyOld]);
                newCaracter = cadenaSalida[0];
                nuevaCadena.Add(newCaracter);
                Decode.Add(Decode.Count() + 1, nuevaCadena);
                keyOld = keyNew;
                nuevaCadena = new List<byte>();
                cadenaSalida = new List<byte>();
            }

            return decodeContent.ToArray();
        }
        void GetIndex(List<byte> content, int originalBinary)
        {
            string binaryCode = "";
            int ultimo = 0;
            foreach (var item in content)
            {

                binaryCode += Convert.ToString(item, 2).PadLeft(8, '0');
                while (binaryCode.Length > originalBinary)
                {
                    index.Add(Convert.ToInt32(binaryCode.Substring(0, originalBinary), 2));
                    binaryCode = binaryCode.Remove(0, originalBinary);
                }

            }
            ultimo = Convert.ToInt32(binaryCode, 2);
            if (binaryCode.Length > 0 && ultimo != 0)
            {
                index.Add(ultimo);
            }
        }
        List<byte> GetMetadata(byte[] Content)
        {
            List<byte> content = Content.ToList();
            binaryMax = content[0];
            content.RemoveAt(0);

            LengtPrincipalDictionary = content[0];
            content.RemoveAt(0);

            for (int i = 0; i < LengtPrincipalDictionary; i++)
            {
                List<byte> temp = new List<byte>();
                temp.Add(content[0]);
                Decode.Add(Decode.Count() + 1, temp);
                content.RemoveAt(0);
            }
            return content;
        }
        #endregion
    }
}

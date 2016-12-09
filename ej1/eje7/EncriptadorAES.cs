using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
namespace eje7
{
    public class EncriptadorAES:Encriptador
    {
        public EncriptadorAES() : base("AES") { }

        public override string Encriptar(string pCadena)
        {

            byte[] inputBytes = Encoding.UTF8.GetBytes(pCadena);

            byte[] encripted;

            byte[] _key = Encoding.ASCII.GetBytes("12EstaClave34es56dificil489ssswf");

            byte[] _iv = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

            RijndaelManaged cripto = new RijndaelManaged();

            //byte[] _key = cripto.Key;
            //byte[] _iv = cripto.IV;

            using (MemoryStream ms =

                new MemoryStream(inputBytes.Length))
            {

                using (CryptoStream objCryptoStream =

                    new CryptoStream(ms,

                           cripto.CreateEncryptor(_key, _iv),

                           CryptoStreamMode.Write))
                {

                    objCryptoStream.Write(inputBytes, 0, inputBytes.Length);

                    objCryptoStream.FlushFinalBlock();

                    objCryptoStream.Close();

                }

                encripted = ms.ToArray();

            }

            return Convert.ToBase64String(encripted);

        }

        public override string Desencriptar(string pCadena)
        {
            byte[] _key = Encoding.ASCII.GetBytes("12EstaClave34es56dificil489ssswf");

            byte[] _iv = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

            byte[] inputBytes = Convert.FromBase64String(pCadena);

            byte[] resultBytes = new byte[inputBytes.Length];

            string textoLimpio = String.Empty;

            RijndaelManaged cripto = new RijndaelManaged();

            using (MemoryStream ms = new MemoryStream(inputBytes))
            {

                using (CryptoStream objCryptoStream =

                new CryptoStream(ms, cripto.CreateDecryptor(_key, _iv),

                        CryptoStreamMode.Read))
                {

                    using (StreamReader sr =

                        new StreamReader(objCryptoStream, true))
                    {

                        textoLimpio = sr.ReadToEnd();

                    }

                }

            }

            return textoLimpio;
        }
    }
}
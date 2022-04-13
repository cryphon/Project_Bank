using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EncFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.Write("Message to encrypt: ");
            string msg = Console.ReadLine();
            byte[] buffer = StringEncrypt(msg, "password is currently not necessary");

            foreach(byte b in buffer)
                Console.Write(b);
        }

        //remove key from memory to for sec
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[32];

            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

            //fill array with random bytes
            for (int i = 0; i < 10; i++)
                rngCsp.GetBytes(salt);

            return salt;

        }

        private byte[] StringEncrypt(string input, string password)
        {
            byte[] salt = GenerateSalt(); //gen salt
            byte[] pwd = System.Text.Encoding.UTF8.GetBytes(password); //pwd string to byte arr. Not necessary for this right now
            byte[] EncryptedData;


            //Rijndael symetric encryption algorithm (no clue how this works)
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            //"What it does is repeatedly hash the user password along with the salt." High iteration counts.   thank you google
            var key = new Rfc2898DeriveBytes(pwd, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            //Cipher modes
            AES.Mode = CipherMode.CFB;


            ICryptoTransform encryptor = AES.CreateEncryptor(AES.Key, AES.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        //Write all data to the stream.
                        swEncrypt.Write(input);
                    }
                    EncryptedData = msEncrypt.ToArray();
                }

            }
            return EncryptedData;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace AdventOfCode_Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "wtnhxymk";
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, source, 2231253);

                Console.WriteLine("\nYour code: " + source + " \nYour Password: " + hash + ".");

            }
            Console.Read();
        }
        static string GetMd5Hash(MD5 md5Hash, string input, int index)
        {


            byte[] data = null;
            string inputCopy = input;
            StringBuilder pass = new StringBuilder("--------");
            Console.Write("\nPassword: " + pass);
            do
            {
                //Console.WriteLine("The index " + index + ".");
                inputCopy = input;
                inputCopy += index.ToString();
                data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(inputCopy));
                System.Text.StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                string hash = sBuilder.ToString();
                if (hash.StartsWith("00000"))
                {
                    char pos = hash[5];
                    if (Char.IsNumber(pos))
                    {
                        int newPos = int.Parse(pos.ToString());
                        if (newPos < 8)
                        {
                            if (pass[newPos] == '-')
                            {
                                pass[newPos] = hash[6];
                                Console.Write("\nPassword: " + pass);
                            }
                        }
                    }
                }
                index++;
            } while (pass.ToString().Contains("-"));

            return pass.ToString(); //gives the final password
        }
    }

}


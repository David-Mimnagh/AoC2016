using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AdventOfCode_Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../pathLong.txt";
            string list = File.ReadAllText(path);
            List<string> rowList = new List<string>();
            List<string> supportTLS = new List<string>();
            string[] currList = null;
            currList = list.Split('\n');
            int supportingTLS = 0;
            for (int i = 0; i < currList.Length; i++)
            {
                currList[i] = currList[i].Replace("\r", String.Empty);
                while (currList[i].Contains("["))
                {
                    int start = currList[i].IndexOf('[');
                    int to = currList[i].IndexOf(']',start);
                    string removeString = currList[i].Substring(start,to-start + 1);
                    for (int j = 0; j < removeString.Length - 3; j++)
                    {
                        char two = removeString[j + 1];
                        char three = removeString[j + 2];
                        if (two == three)
                        {
                            char one = removeString[j];
                            char four = removeString[j + 3];
                            if (one == four)
                            {
                                if (one != two)
                                {
                                    if (three != four)
                                    {
                                        currList[i] = "";
                                    }
                                }
                            }
                        }
                    }
                    currList[i] = currList[i].Replace(removeString, String.Empty);
                }

                string current = currList[i];

                if (current != "")
                {
                    for (int j = 0; j < current.Length - 3; j++)
                    {
                        char two = current[j + 1];
                        char three = current[j + 2];
                        if (two == three)
                        {
                            char one = current[j];
                            char four = current[j + 3];
                            if (one == four)
                            {
                                if (one != two)
                                {
                                    if (three != four)
                                    {
                                        supportTLS.Add(current);
                                        supportingTLS++;
                                        break;
                                    }
                                }
                            }
                        } 
                    }
                }
            }

            Console.Write("Count: " + supportingTLS);
            Console.Read();
        }
    }
}

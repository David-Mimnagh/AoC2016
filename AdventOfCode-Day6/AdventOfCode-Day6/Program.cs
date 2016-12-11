using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AdventOfCode_Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../pathLong.txt";
            string list = File.ReadAllText(path);
            List<string> rowList = new List<string>();



            List<char>Col1List = new List<char>();
            List<char> Col2List = new List<char>();
            List<char> Col3List = new List<char>();
            List<char> Col4List = new List<char>();
            List<char> Col5List = new List<char>();
            List<char> Col6List = new List<char>();
            List<char> Col7List = new List<char>();
            List<char> Col8List = new List<char>();
            string[] currList = null;
            currList = list.Split('\n');
            string current = "";
            for (int i = 0; i < currList.Length; i++)
            {
                currList[i] = currList[i].Replace("\r", String.Empty);

                for (int j = 0; j < currList[i].Length; j++)
                {
                    current = currList[i];
                    if (j == 0)
                        Col1List.Add(current[j]);
                    else if (j == 1)
                        Col2List.Add(current[j]);
                    else if (j == 2)
                        Col3List.Add(current[j]);
                    else if (j == 3)
                        Col4List.Add(current[j]);
                    else if (j == 4)
                        Col5List.Add(current[j]);
                    else if (j == 5)
                        Col6List.Add(current[j]);
                    else if (j == 6)
                        Col7List.Add(current[j]);
                    else if (j == 7)
                        Col8List.Add(current[j]);


                }
            }




            /*PART 2 - OrderBy. Part 1 - OrderByDescending*/



            var new1List = Col1List.GroupBy(x => x)
                  .OrderBy(g => g.Count())
                  .SelectMany(g => g).ToList();
            var new2List = Col2List.GroupBy(x => x)
                  .OrderBy(g => g.Count())
                  .SelectMany(g => g).ToList();
            var new3List = Col3List.GroupBy(x => x)
            .OrderBy(g => g.Count())
            .SelectMany(g => g).ToList();
            var new4List = Col4List.GroupBy(x => x)
            .OrderBy(g => g.Count())
            .SelectMany(g => g).ToList();

            var new5List = Col5List.GroupBy(x => x)
                  .OrderBy(g => g.Count())
                  .SelectMany(g => g).ToList();
            var new6List = Col6List.GroupBy(x => x)
                  .OrderBy(g => g.Count())
                  .SelectMany(g => g).ToList();
            var new7List = Col7List.GroupBy(x => x)
            .OrderBy(g => g.Count())
            .SelectMany(g => g).ToList();
            var new8List = Col8List.GroupBy(x => x)
            .OrderBy(g => g.Count())
            .SelectMany(g => g).ToList();

            Console.Write("\nYour word: " + new1List[0] + new2List[0] + new3List[0] + new4List[0] + new5List[0] + new6List[0] + new7List[0] + new8List[0] + ".");
            Console.Read();
        }
    }
}

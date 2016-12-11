using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string list = "../../triangles.txt";
            string triangleText = File.ReadAllText(list);
            List<string> initialTrianglesList = new List<string>();
            List<int> realTrianglesList = new List<int>();

            List<string> TL = new List<string>();
            List<int> firstColList = new List<int>();
            List<int> secColList = new List<int>();
            List<int> thirdColList = new List<int>();
            List<int> fakeTrianglesList = new List<int>();
            do
            {
                int from = 2;
                int to =0;
                if (triangleText.Contains("\r\n "))
                    to = triangleText.IndexOf("\r\n ");
                else
                    to = triangleText.Length;

                string oneTri = triangleText.Substring(from, to-from);
                oneTri= oneTri.Trim();
                initialTrianglesList.Add(oneTri);
                if (triangleText.Contains("\r\n "))
                    triangleText = triangleText.Replace(oneTri + "\r\n ", String.Empty);
                else
                    triangleText = "";
                
            }
            while(triangleText.Length>0);

            int firstNum, secondNum, final = 0;

            //string triangleList = triangle.("\r\n "); 

            for (int i = 0; i < initialTrianglesList.Count();i++)
            {
                initialTrianglesList[i] = System.Text.RegularExpressions.Regex.Replace(initialTrianglesList[i], @"\s+", " ");
                initialTrianglesList[i] = System.Text.RegularExpressions.Regex.Replace(initialTrianglesList[i], @"\s+", ",");

                int from = 0;
                initialTrianglesList[i] = initialTrianglesList[i].TrimStart(',');
                int to = initialTrianglesList[i].IndexOf(",");

                firstNum = Int32.Parse(initialTrianglesList[i].Substring(from, to));
                initialTrianglesList[i] = initialTrianglesList[i].Remove(from, to);
                initialTrianglesList[i] = initialTrianglesList[i].TrimStart(',');
                from = 0;
                initialTrianglesList[i] = initialTrianglesList[i].TrimStart(',');
                to = initialTrianglesList[i].IndexOf(",");
                secondNum = Int32.Parse(initialTrianglesList[i].Substring(from, to));
                initialTrianglesList[i] = initialTrianglesList[i].Remove(from, to);
                initialTrianglesList[i] = initialTrianglesList[i].TrimStart(',');
                from = 0;
                initialTrianglesList[i] = initialTrianglesList[i].TrimStart(',');
                to = initialTrianglesList[i].IndexOf(",");
                final = Int32.Parse(initialTrianglesList[i]);

                if (firstNum + secondNum <= final) ;// 1+ 2 1+3 2+3
                //fakeTrianglesList.Add(firstNum + secondNum);
                else if (firstNum + final <= secondNum) ;// 1+ 2 1+3 2+3
                // fakeTrianglesList.Add(firstNum + secondNum);
                else if (final + secondNum <= firstNum) ;// 1+ 2 1+3 2+3
                //fakeTrianglesList.Add(firstNum + secondNum);
                else
                {
                    //realTrianglesList.Add(firstNum + secondNum);
                }
                firstColList.Add(firstNum); secColList.Add(secondNum); thirdColList.Add(final);
                string value = "Side1: " + firstNum.ToString() + " Side2: " + secondNum.ToString() + " Final: " + final.ToString();
                TL.Add(value);
                initialTrianglesList[i] = "";
            }
            
                for (int i = 0; i < firstColList.Count; i++)
                {
                    if (i <= 1900)
                    {
                        int sum = firstColList.Take(2).Sum(); 
                        firstColList.RemoveRange(0,3);
                        int first = firstColList[i];
                        int sec = firstColList[i + 1];
                        int third = 0;
                        if (i == 1900)
                            third = 11110;
                        else
                            third = firstColList[i + 2];

                        if (first + sec <= third) // 1+ 2 1+3 2+3
                            fakeTrianglesList.Add(first + sec);
                        else if (first + third <= sec) // 1+ 2 1+3 2+3
                            fakeTrianglesList.Add(first + sec);
                        else if (third + sec <= first) // 1+ 2 1+3 2+3
                            fakeTrianglesList.Add(first + sec);
                        else
                        {
                            realTrianglesList.Add(first + sec);
                        }
                    }
                }
                for (int i = 0; i < secColList.Count; i++)
                {
                    if (i <= 1900)
                    {
                        int first = secColList[i];
                        int sec = secColList[i + 1];
                        int third = 0;
                        if (i == 1900)
                            third = 11110;
                        else
                            third = secColList[i + 2];

                        if (first + sec <= third) // 1+ 2 1+3 2+3
                            fakeTrianglesList.Add(first + sec);
                        else if (first + third <= sec) // 1+ 2 1+3 2+3
                            fakeTrianglesList.Add(first + sec);
                        else if (third + sec <= first) // 1+ 2 1+3 2+3
                            fakeTrianglesList.Add(first + sec);
                        else
                        {
                            realTrianglesList.Add(first + sec);
                        }
                    }
                }
                for (int i = 0; i < thirdColList.Count; i++)
                {
                    if (i <= 1900)
                    {
                        int first = thirdColList[i];
                        int sec = thirdColList[i + 1];
                        int third = 0;
                        if (i == 1900)
                            third = 11110;
                        else
                            third = thirdColList[i + 2];

                        if (first + sec <= third) // 1+ 2 1+3 2+3
                            fakeTrianglesList.Add(first + sec);
                        else if (first + third <= sec) // 1+ 2 1+3 2+3
                            fakeTrianglesList.Add(first + sec);
                        else if (third + sec <= first) // 1+ 2 1+3 2+3
                            fakeTrianglesList.Add(first + sec);
                        else
                        {
                            realTrianglesList.Add(first + sec);
                        }
                    }
                }

                Console.Write("REAL: " + realTrianglesList.Count());
            Console.Write("\nFAKE: " + fakeTrianglesList.Count());
                Console.Read();
        }
    }
}

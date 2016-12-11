using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AdventOfCode
{
    class Program
    {
        struct Person
        {
            public int positionX;
            public int positionY;
            public int direction; // 1 - NORTH, 2- EAST, 3 - SOUTH, 4- WEST
        }
        static void Main(string[] args)
        {
            string path = "../../pathLong.txt";
            string instructions = File.ReadAllText(path);
            Person p = new Person();
            p.positionX = 0;
            p.positionY = 0;
            p.direction = 1;

            List<int> xPosVisited = new List<int>();
            List<int> yPosVisited = new List<int>();
            List<string> positionsVisited = new List<string>();
            List<string> Positions = new List<string>();
            /* PART 1*/
            do
            {
                int blocksToMove = 0;
                int from = 0;
                int to;
                String result;
                if (instructions.Length > 2)
                {
                    to = instructions.IndexOf(", ");
                    result = instructions.Substring(from, to - from + 2);
                }
                else
                {
                    to = instructions.Length;
                    result = instructions.Substring(from, to - from);
                }

                instructions = instructions.Remove(0, result.Length);
                result = result.Replace(", ", "");

                if (result[0] == 'R')
                {
                    if (p.direction == 4)
                        p.direction = 1;
                    else
                        p.direction += 1;
                }
                else if (result[0] == 'L')
                {
                    if (p.direction == 1)
                        p.direction = 4;
                    else
                        p.direction -= 1;
                }

                result = result.Replace(result[0].ToString(), "");
                Int32.TryParse(result, out blocksToMove);

                if (p.direction == 1)
                {
                    /*PART 2 */
                    for (int i = 0; i < blocksToMove; i++)
                    {
                       int newX = p.positionX;
                       int newY = p.positionY + i;
                       positionsVisited.Add("X: " + newX + " Y: " + newY);
                    }
                    /* END PART 2*/
                    p.positionY += blocksToMove;
                }
                if (p.direction == 2)
                {
                    /*PART 2 */
                    for (int i = 0; i < blocksToMove; i++)
                    {
                        int newX = p.positionX + i;
                        int newY = p.positionY;
                        positionsVisited.Add("X: " + newX + " Y: " + newY);
                    }
                    /* END PART 2*/
                    p.positionX += blocksToMove;
                }
                if (p.direction == 3)
                {
                    /*PART 2 */
                    for (int i = 0; i < blocksToMove; i++)
                    {
                        int newX = p.positionX;
                        int newY = p.positionY - i;
                        positionsVisited.Add("X: " + newX + " Y: " + newY);
                    }
                    /* END PART 2*/
                    p.positionY -= blocksToMove;
                }
                if (p.direction == 4)
                {
                    /*PART 2 */
                    for (int i = 0; i < blocksToMove; i++)
                    {
                        int newX = p.positionX - i;
                        int newY = p.positionY;
                        positionsVisited.Add("X: " + newX + " Y: " + newY);
                    }
                    /* END PART 2*/
                    p.positionX -= blocksToMove;
                }
                string newPos = p.positionX.ToString() + " and " + p.positionY.ToString();
                Positions.Add(newPos);
            } while (instructions.Length > 0); /* END PART 1*/


            /*PART 2 */
            var duplicates = positionsVisited.GroupBy(a => a).SelectMany(ab => ab.Skip(1).Take(1)).ToList();
            string firstMatch = duplicates[0].ToString();
            firstMatch = firstMatch.Replace("X: ","");
            firstMatch = firstMatch.Replace(" Y: ",",");
            String[] strArray = firstMatch.Split(',');
            int[] intArray = new int[strArray.Length];
            for(int i = 0; i < strArray.Length; i++) {
                intArray[i] = Int32.Parse(strArray[i]);
            }
            int firstBlockMatch = Math.Abs(intArray[0]) + Math.Abs(intArray[1]);
            /* END PART 2*/





            int finalDistance = Math.Abs(p.positionX) + Math.Abs(p.positionY);

            Console.Write("First Match Pos: " + firstMatch);
            Console.Write("\n\nManhattan of First Match: " + firstBlockMatch);
            Console.Write("\n\nFinal Manhattan: " + finalDistance);
            Console.ReadLine();
        }
    }
}

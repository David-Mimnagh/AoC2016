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
               static void Main(string[] args)
        {
            string button1 = "../../line1.txt";
            string instructionsB1 = File.ReadAllText(button1);
            string button2 = "../../line2.txt";
            string instructionsB2 = File.ReadAllText(button2);
            string button3 = "../../line3.txt";
            string instructionsB3 = File.ReadAllText(button3);
            string button4 = "../../line4.txt";
            string instructionsB4 = File.ReadAllText(button4);
            string button5 = "../../line5.txt";
            string instructionsB5 = File.ReadAllText(button5);

            int[] keypad = new int[13];
            for (int i = 0; i < 13; i++ )
                keypad[i] = i+1;

            int currentButton = 5;
            int posOnKeypad = currentButton-1;
            int But1, But2, But3, But4, But5 = 0;
                   /*
            do
            {
                
                foreach(char c in instructionsB1)
                {
                    posOnKeypad = currentButton - 1;
                    if (c == 'L')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 7)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 8;
                    }
                    else if (c == 'U')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 6;
                    }
                    else if (c == 'R')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 3)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 6)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'D')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 7)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 8)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                    }

                    instructionsB1 = instructionsB1.Replace(c.ToString(), String.Empty);
                }
            } while (instructionsB1.Length > 0);
            But1 = currentButton;

            do
            {
                
                foreach (char c in instructionsB2)
                {
                    posOnKeypad = currentButton - 1;
                    if (c == 'L')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 7)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 8;
                    }
                    else if (c == 'U')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 6;
                    }
                    else if (c == 'R')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 3)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 6)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'D')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 7)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 8)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                    }

                    instructionsB2 = instructionsB2.Replace(c.ToString(), String.Empty);
                }
            } while (instructionsB2.Length > 0);
            But2 = currentButton;


            do
            {
                
                foreach (char c in instructionsB3)
                {
                    posOnKeypad = currentButton - 1;
                    if (c == 'L')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 7)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 8;
                    }
                    else if (c == 'U')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 6;
                    }
                    else if (c == 'R')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 3)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 6)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'D')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 7)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 8)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                    }

                    instructionsB3 = instructionsB3.Replace(c.ToString(), String.Empty);
                }
            } while (instructionsB3.Length > 0);
            But3 = currentButton;

            do
            {
                foreach (char c in instructionsB4)
                {
                    posOnKeypad = currentButton - 1;
                    if (c == 'L')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 7)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 8;
                    }
                    else if (c == 'U')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 6;
                    }
                    else if (c == 'R')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 3)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 6)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'D')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 7)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 8)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                    }

                    instructionsB4 = instructionsB4.Replace(c.ToString(), String.Empty);
                }
            } while (instructionsB4.Length > 0);
            But4 = currentButton;

            do
            {
                foreach (char c in instructionsB5)
                {
                    posOnKeypad = currentButton - 1;
                    if (c == 'L')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 7)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 8;
                    }
                    else if (c == 'U')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 6;
                    }
                    else if (c == 'R')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 3)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 6)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'D')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 7)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 8)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                    }

                    instructionsB5 = instructionsB5.Replace(c.ToString(), String.Empty);
                }
            } while (instructionsB5.Length > 0);
            But5 = currentButton;
                   */
            /* PART 1 ^^^^*/


            do
            {

                foreach (char c in instructionsB1)
                {
                    posOnKeypad = currentButton - 1;
                    if (c == 'L')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton =3;
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 10) // A
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 10;
                        else if (keypad[posOnKeypad] == 12) // C
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'U')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 12) // C
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 13) // D
                            currentButton = 11;
                    }
                    else if (c == 'R')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 12;
                        else if (keypad[posOnKeypad] == 12) // C
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'D')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 10;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 12;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 13;
                        else if (keypad[posOnKeypad] == 12) // C
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }

                    instructionsB1 = instructionsB1.Replace(c.ToString(), String.Empty);
                }
            } while (instructionsB1.Length > 0);
            But1 = currentButton;


            do
            {

                foreach (char c in instructionsB2)
                {
                    posOnKeypad = currentButton - 1;
                    if (c == 'L')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 10) // A
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 10;
                        else if (keypad[posOnKeypad] == 12) // C
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'U')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 12) // C
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 13) // D
                            currentButton = 11;
                    }
                    else if (c == 'R')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 12;
                        else if (keypad[posOnKeypad] == 12) // C
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'D')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 10;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 12;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 13;
                        else if (keypad[posOnKeypad] == 12) // C
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }

                    instructionsB2 = instructionsB2.Replace(c.ToString(), String.Empty);
                }
            } while (instructionsB2.Length > 0);
            But2 = currentButton;
            do
            {

                foreach (char c in instructionsB3)
                {
                    posOnKeypad = currentButton - 1;
                    if (c == 'L')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 10) // A
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 10;
                        else if (keypad[posOnKeypad] == 12) // C
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'U')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 12) // C
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 13) // D
                            currentButton = 11;
                    }
                    else if (c == 'R')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 12;
                        else if (keypad[posOnKeypad] == 12) // C
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'D')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 10;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 12;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 13;
                        else if (keypad[posOnKeypad] == 12) // C
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }

                    instructionsB3 = instructionsB3.Replace(c.ToString(), String.Empty);
                }
            } while (instructionsB3.Length > 0);
            But3 = currentButton;

            do
            {

                foreach (char c in instructionsB4)
                {
                    posOnKeypad = currentButton - 1;
                    if (c == 'L')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 10) // A
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 10;
                        else if (keypad[posOnKeypad] == 12) // C
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'U')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 12) // C
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 13) // D
                            currentButton = 11;
                    }
                    else if (c == 'R')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 12;
                        else if (keypad[posOnKeypad] == 12) // C
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'D')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 10;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 12;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 13;
                        else if (keypad[posOnKeypad] == 12) // C
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }

                    instructionsB4 = instructionsB4.Replace(c.ToString(), String.Empty);
                }
            } while (instructionsB4.Length > 0);
            But4 = currentButton;

            do
            {

                foreach (char c in instructionsB5)
                {
                    posOnKeypad = currentButton - 1;
                    if (c == 'L')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 5;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 9)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 10) // A
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 10;
                        else if (keypad[posOnKeypad] == 12) // C
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'U')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 1;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 2;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 12) // C
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 13) // D
                            currentButton = 11;
                    }
                    else if (c == 'R')
                    {
                        if (keypad[posOnKeypad] == 1)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 4;
                        else if (keypad[posOnKeypad] == 4)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 5)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 9;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 12;
                        else if (keypad[posOnKeypad] == 12) // C
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }
                    else if (c == 'D')
                    {
                        if (keypad[posOnKeypad] == 1)
                            currentButton = 3;
                        else if (keypad[posOnKeypad] == 2)
                            currentButton = 6;
                        else if (keypad[posOnKeypad] == 3)
                            currentButton = 7;
                        else if (keypad[posOnKeypad] == 4)
                            currentButton = 8;
                        else if (keypad[posOnKeypad] == 5)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 6)
                            currentButton = 10;
                        else if (keypad[posOnKeypad] == 7)
                            currentButton = 11;
                        else if (keypad[posOnKeypad] == 8)
                            currentButton = 12;
                        else if (keypad[posOnKeypad] == 9)
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 10) // A
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 11) // B
                            currentButton = 13;
                        else if (keypad[posOnKeypad] == 12) // C
                            Console.Write("\nAt edge, ignoring command");
                        else if (keypad[posOnKeypad] == 13) // D
                            Console.Write("\nAt edge, ignoring command");
                    }

                    instructionsB5 = instructionsB5.Replace(c.ToString(), String.Empty);
                }
            } while (instructionsB5.Length > 0);
            But5 = currentButton;
            string Combination = "";
            if (But1 == 10)
                Combination += "A";
            else if (But1 == 11)
                Combination += "B";
            else if (But1 == 12)
                Combination += "C";
            else if (But1 == 13)
                Combination += "D";
            else
                Combination += But1.ToString();
            if (But2 == 10)
                Combination += "A";
            else if (But2 == 11)
                Combination += "B";
            else if (But2 == 12)
                Combination += "C";
            else if (But2 == 13)
                Combination += "D";
            else
                Combination += But2.ToString();
            if (But3 == 10)
                Combination += "A";
            else if (But3 == 11)
                Combination += "B";
            else if (But3 == 12)
                Combination += "C";
            else if (But3 == 13)
                Combination += "D";
            else
                Combination += But3.ToString();
            if (But4 == 10)
                Combination += "A";
            else if (But4 == 11)
                Combination += "B";
            else if (But4 == 12)
                Combination += "C";
            else if (But4 == 13)
                Combination += "D";
            else
                Combination += But4.ToString();
            if (But5 == 10)
                Combination += "A";
            else if (But5 == 11)
                Combination += "B";
            else if (But5 == 12)
                Combination += "C";
            else if (But5 == 13)
                Combination += "D";
            else
                Combination += But5.ToString();
                Console.Write("Combination: " + Combination);
            Console.Write("\n\n\t\t");
            for (int i = 0; i < 13; i++)
            {
                Console.Write(" ");
                if (i == 0)
                {
                    Console.Write("  ");
                    Console.Write(keypad[i]);
                    Console.Write("\n");
                    Console.Write("\t\t");
                }
                else
                if (i == 4)
                {   
                    Console.Write("\n");
                    Console.Write("\t");

                    Console.Write("       ");
                    Console.Write(keypad[i]);
                }
                else if (i == 9)
                {
                    Console.Write("\n");
                    Console.Write("\t\t ");
                    Console.Write("A");
                }
                else if (i == 10)
                    Console.Write("B");
                else if (i == 11)
                {
                    Console.Write("C");
                    Console.Write("\n");
                    Console.Write("\t\t");
                }
                else if (i == 12)
                    Console.Write("  D");
                else
                    Console.Write(keypad[i]);
            }
            Console.ReadLine();
        }
    }
}

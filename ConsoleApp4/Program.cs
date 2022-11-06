using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SoundPlayer player = new SoundPlayer();//Object of SoundPlayer Class from System.Media to reach functions inside it and play a background music
            player.SoundLocation = "";//location of the music file
            player.Play();//starts playing the sound file

            Random random = new Random(); //Object of random Class to reach functions inside it

            //declaring variables
            string StateA,StateB,StateC,fighters,Ax1,Ay1;
            int Ax,Ay,Bx, By, Cx, Cy,Round, Attack_ScoreA, Attack_ScoreB, Attack_ScoreC;
            int ABManDis, ACManDis, BCManDis, AxP, AyP, BxP, ByP, CxP, CyP, SetA, SetB, SetC, HPA, HPB, HPC;
            double ABDis, ACDis, BCDis;
            char charA, charB, charC;
            charA = 'A';
            charB = 'B';
            charC = 'C';


            Console.WriteLine("ARE YOU READY TO PLAY THE BEST GAME EVER!!!!!!!!!");
            Thread.Sleep(1000);
            Console.Write("3\t");
            Thread.Sleep(1000);
            Console.Write("2\t");
            Thread.Sleep(1000);
            Console.WriteLine("1\t");
            Thread.Sleep(1000);
            Console.WriteLine(":)\t:)\t:)\t:)\t:)");
            Thread.Sleep(1500);

            Console.Clear();


            //asking user to enter the Ax and Ay values
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter the location of A:");
            Console.ForegroundColor = ConsoleColor.Magenta;//changing color of the font
            Console.Write("AX:  ");
            Ax1=Console.ReadLine();
            Console.Write("AY:  ");
            Ay1 =Console.ReadLine();

            //This if statement is to avoid user entering other data types than Integer 
            if ((Information.IsNumeric(Ax1)) || (Information.IsNumeric(Ay1)) ) {
                
                //Converting inputs which are in string form to integers
                Ax = Convert.ToInt32(Ax1);
                Ay = Convert.ToInt32(Ay1);

                //This if statement is used to prevent user entering a number greater than 10 and less than -10 ,as Ax and Ay values
                if (!(Ax > 10 || Ax < -10 || Ay > 10 || Ay < -10))
                {
                    Bx = random.Next(-10, 11);
                    By = random.Next(-10, 11);
                    Cx = random.Next(-10, 11);
                    Cy = random.Next(-10, 11);

                    //This if statement is used to change the location of user if they are in the same point
                    if ((Ax == Bx & Ay == By) || (Ax == Cx & Ay == Cy) || (Bx == Cx & By == Cy))
                    {
                        Bx = random.Next(-10, 11);
                        By = random.Next(-10, 11);
                        Cx = random.Next(-10, 11);
                        Cy = random.Next(-10, 11);
                    }

                    //A randomly selects a number between 1 and 3 for it's Set number
                    SetA = random.Next(1, 4);
                    SetB = 0;
                    SetC = 0;
                    //The probability that A selects 1
                    if (SetA == 1)
                    {
                        SetB = random.Next(2, 4);
                        if (SetB == 2)//The probability that A selects 1 and B selects 2
                        {
                            SetC = 3;
                        }
                        else if (SetB == 3)//The probability that A selects 1 and B selects3
                        {
                            SetC = 2;
                        }
                    }
                    //The probability that A selects 2
                    else if (SetA == 2)
                    {
                        SetB = random.Next(2, 4);
                        if (SetB == 2)//The probability that A selects 2 , B selects 1 and C selects 3 
                        {
                            SetB = 1;
                            SetC = 3;
                        }
                        else if (SetB == 3)//The probability that A selects 2 , B selects 3 and C selects 1
                        {
                            SetC = 1;
                        }
                    }
                    //The probability that A selects 3 
                    else
                    {
                        SetB = random.Next(1, 3);
                        if (SetB == 1)//The probability that A selects 3 , B selects 1 and C selects 2 
                        {
                            SetC = 2;
                        }
                        else if (SetB == 2)//The probability that A selects 3 , B selects 2 and C selects 1
                        {
                            SetC = 1;
                        }
                    }

                    //A randomly selects a number between 1 and 3 for it's Health
                    HPA = random.Next(1, 4);
                    HPB = 0;
                    HPC = 0;
                    //The probability that A selects 60  
                    if (HPA == 1)
                    {
                        HPA = 60;
                        HPB = random.Next(2, 4);
                        if (HPB == 2)//The probability that A selects 60 , B selects 80 and C selects 100
                        {
                            HPB = 80;
                            HPC = 100;
                        }
                        else if (HPB == 3)//The probability that A selects 60 , B selects 100 and C selects 80
                        {
                            HPB = 100;
                            HPC = 80;
                        }
                    }
                    //The probability that A selects 80 
                    else if (HPA == 2)
                    {
                        HPA = 80;
                        HPB = random.Next(2, 4);
                        if (HPB == 2)//The probability that A selects 80 , B selects 60 and C selects 100
                        {
                            HPB = 60;
                            HPC = 100;
                        }
                        else if (HPB == 3)//The probability that A selects 80 , B selects 100 and C selects 60
                        {
                            HPB = 100;
                            HPC = 60;
                        }
                    }
                    //The probability that A selects 100
                    if (HPA == 3)
                    {
                        HPA = 100;
                        HPB = random.Next(1, 3);
                        if (HPB == 2)//The probability that A selects 100 , B selects 80 and C selects 60
                        {
                            HPB = 80;
                            HPC = 60;
                        }
                        else if (HPB == 1)//The probability that A selects 100 , B selects 60 and C selects 80
                        {
                            HPB = 60;
                            HPC = 80;
                        }
                    }

                    Thread.Sleep(1000);//The console waits for a second
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    //printing which location ,Set number, Health and name of the players
                    Console.WriteLine("{0}:  ({1},{2})\tSet {3}\tHealth:{4}", charA, Ax, Ay, SetA, HPA);
                    Console.WriteLine("{0}:  ({1},{2})\tSet {3}\tHealth:{4}", charB, Bx, By, SetB, HPB);
                    Console.WriteLine("{0}:  ({1},{2})\tSet {3}\tHealth:{4}\n\n", charC, Cx, Cy, SetC, HPC);
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    
                    //printing the map
                    Console.WriteLine("   + - - - - - - - - - - ^ - - - - - - - - - - +\n" +
                                      " 10| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "  9| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "  8| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "  7| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "  6| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "  5| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "  4| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "  3| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "  2| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "  1| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "  0| - - - - - - - - - - + - - - - - - - - - - |\n" +
                                      " -1| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      " -2| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      " -3| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      " -4| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      " -5| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      " -6| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      " -7| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      " -8| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      " -9| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "-10| . . . . . . . . . . | . . . . . . . . . . |\n" +
                                      "   + - - - - - - - - - - - - - - - - - - - - - +\n" +
                                      "     0 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 0  ");
                    // we use 2x+25 to locate user according the x-axis
                    // we use 19-y to locate user according the y-axis
                    Thread.Sleep(1000);
                    AxP = 2 * Ax + 25;
                    AyP = 19 - Ay;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    //we use the SetCursorPosition() function to locate users in the map
                    Console.SetCursorPosition(AxP, AyP);
                    Console.WriteLine("A");

                    Thread.Sleep(1000);
                    BxP = 2 * Bx + 25;
                    ByP = 19 - By;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(BxP, ByP);
                    Console.WriteLine("B");

                    Thread.Sleep(1000);
                    CxP = 2 * Cx + 25;
                    CyP = 19 - Cy;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(CxP, CyP);
                    Console.WriteLine("C");

                    //Calculating the Shortest distances between players
                    Console.ForegroundColor = ConsoleColor.White;
                    ABDis = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2));
                    ACDis = Math.Sqrt(Math.Pow(Ax - Cx, 2) + Math.Pow(Ay - Cy, 2));
                    BCDis = Math.Sqrt(Math.Pow(Bx - Cx, 2) + Math.Pow(By - Cy, 2));

                    //Setting Cursor back to the last line of the console
                    Console.SetCursorPosition(0, 32);
                    Console.WriteLine();

                    //Calculating Manhattan distances between players
                    ABManDis = Math.Abs(Ax - Bx) + Math.Abs(Ay - By);
                    ACManDis = Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy);
                    BCManDis = Math.Abs(Bx - Cx) + Math.Abs(By - Cy);

                    Thread.Sleep(2000);
                    //if the distance between A and B is the shortest distance and it is also smaller than 15
                    if ((ABDis < ACDis) & (ABDis < BCDis) & (ABDis <= 15))
                    {
                        //All possibilities that A Wins against B 
                        if ((SetA == 1 & SetB == 3) || (SetA == 2 & SetB == 1) || (SetA == 3 & SetB == 2))
                        {
                            Round = 1;
                            fighters = "A-B";
                            StateA = "Survivor";
                            StateB = "Defeated";
                            StateC = "Non_fighter";
                            HPA -= 25;//Updating the health of A
                            HPB = 0;//Updating the health of B
                            Attack_ScoreA = 10 * ABManDis + 100 - HPA;//Calculating the Attack score of A
                            Attack_ScoreB = 0;
                            Attack_ScoreC = 0;
                            //printing the results of the first round
                            Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charA, StateA, HPA, Attack_ScoreA);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charB, StateB, HPB, Attack_ScoreB);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}\n", charC, StateC, HPC, Attack_ScoreC);

                            //After A defeated B ,if the distance between A and C is shorter than 15 they fight
                            //if A wins against B ,then it has to lose against C
                            if (ACDis <= 15)
                            {
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "A-C";
                                StateA = "Defeated";
                                StateB = "Defeated";
                                StateC = "Survivor";
                                HPA = 0;
                                HPC -= 25;
                                Attack_ScoreC = 10 * ACManDis + 100 - HPC;
                                Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                                Thread.Sleep(500);
                                Console.WriteLine("A:{0}\tHealth:{1}\tScore:{2}", StateA, HPA, Attack_ScoreA);
                                Thread.Sleep(500);
                                Console.WriteLine("B:{0}\tHealth:{1}\tScore:{2}", StateB, HPB, Attack_ScoreB);
                                Thread.Sleep(500);
                                Console.WriteLine("C:{0}\tHealth:{1}\tScore:{2}\n", StateC, HPC, Attack_ScoreC);
                                Console.ForegroundColor = ConsoleColor.DarkRed;

                                //Camparing which player has the maximum score 
                                if (Attack_ScoreA < Attack_ScoreC)
                                {
                                    Console.WriteLine("{0} has the maximum Score ({1})", charC, Attack_ScoreC);
                                }
                                else
                                {
                                    Console.WriteLine("{0} has the maximum Score ({1})", charA, Attack_ScoreA);
                                }
                            }
                            else
                            {
                                //The possibilities that the distance between A and C is greater than 15 and no one fights in second round
                                Thread.Sleep(2000);
                                Console.WriteLine("Round  {0}:    {1}", Round, fighters);
                                Console.WriteLine("Too Distant, no attack ");
                                Console.WriteLine("{0} has the maximum score  ({1})", charA, Attack_ScoreA);
                            }
                        }
                        //All posibilities that A loses against B
                        else
                        {
                            Round = 1;
                            fighters = "A-B";
                            StateA = "Defeated";
                            StateB = "Survivor";
                            StateC = "Non-fighter";
                            HPA = 0;
                            HPB -= 25;
                            Attack_ScoreA = 0;
                            Attack_ScoreB = 10 * ABManDis + 100 - HPB;
                            Attack_ScoreC = 0;
                            Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charA, StateA, HPA, Attack_ScoreA);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charB, StateB, HPB, Attack_ScoreB);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}\n", charC, StateC, HPC, Attack_ScoreC);

                            //After B defeated A ,if the distance between B and C is shorter than 15 they fight
                            //if B wins against A ,then it has to lose against C
                            if (BCDis <= 15)
                            {
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "B-C";
                                StateA = "Defeated";
                                StateB = "Defeated";
                                StateC = "Survivor";
                                HPB = 0;
                                HPC -= 25;
                                Attack_ScoreC = 10 * ACManDis + 100 - HPC;
                                Console.WriteLine("Round  {0}:    {1}", Round, fighters);
                                Thread.Sleep(500);
                                Console.WriteLine("A:{0}\tHealth:{1}\tScore:{2}", StateA, HPA, Attack_ScoreA);
                                Thread.Sleep(500);
                                Console.WriteLine("B:{0}\tHealth:{1}\tScore:{2}", StateB, HPB, Attack_ScoreB);
                                Thread.Sleep(500);
                                Console.WriteLine("C:{0}\tHealth:{1}\tScore:{2}", StateC, HPC, Attack_ScoreC);

                                //Camparing which player has the maximum score
                                if (Attack_ScoreB < Attack_ScoreC)
                                {
                                    Console.WriteLine("{0} has the maximum Score ({1})", charC, Attack_ScoreC);
                                }
                                else
                                {
                                    Console.WriteLine("{0} has the maximum Score ({1})", charB, Attack_ScoreB);
                                }
                            }
                            else
                            {
                                //The possibility that the distance between B and C is greater than 15 and no one fights in second round
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "B-C";
                                Console.WriteLine("Round  {0}:    {1}", Round, fighters);
                                Console.WriteLine("Too Distant, no attack ");
                                Console.WriteLine("{0} has the maximum score  ({1})", charB, Attack_ScoreB);
                            }
                        }
                    }



                    //if the distance between A and C is the shortest distance and it is also smaller than 15
                    else if ((ACDis < ABDis) & (ACDis < BCDis) & (ACDis <= 15))
                    {
                        //All possibilities that A Wins against C 
                        if ((SetA == 1 & SetC == 3) || (SetA == 2 & SetC == 1) || (SetA == 3 & SetC == 2))
                        {
                            Round = 1;
                            fighters = "A-C";
                            StateA = "Survivor";
                            StateB = "Non-figther";
                            StateC = "Defeated";
                            HPA -= 25;
                            HPC = 0;
                            Attack_ScoreA = 10 * ABManDis + 100 - HPA;
                            Attack_ScoreB = 0;
                            Attack_ScoreC = 0;
                            Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charA, StateA, HPA, Attack_ScoreA);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charB, StateB, HPB, Attack_ScoreB);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}\n", charC, StateC, HPC, Attack_ScoreC);
                            
                            //After A defeated C ,if the distance between A and B is shorter than 15 they fight
                            //if A wins against C ,then it has to lose against B
                            if (ABDis <= 15)
                            {
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "A-B";
                                StateA = "Defeated";
                                StateB = "Survivor";
                                StateC = "Defeated";
                                HPA = 0;
                                HPB -= 25;
                                Attack_ScoreB = 10 * ABManDis + 100 - HPB;
                                Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charA, StateA, HPA, Attack_ScoreA);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charB, StateB, HPB, Attack_ScoreB);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}\n", charC, StateC, HPC, Attack_ScoreC);                              
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                //Camparing which player has the maximum score
                                if (Attack_ScoreA < Attack_ScoreB)
                                {
                                    Console.WriteLine("{0} has the maximum Score ({1})", charB, Attack_ScoreB);
                                }
                                else
                                {
                                    Console.WriteLine("{0} has the maximum Score ({1})", charA, Attack_ScoreA);
                                }
                            }
                            //The possibilities that the distance between A and B is greater than 15 and no one fights in second round
                            else
                            {
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "A-B";
                                Console.WriteLine("Round  {0}:    {1}", Round, fighters);
                                Console.WriteLine("Too Distant, no attack ");
                                Console.WriteLine("{0} has the maximum score  ({1})", charA, Attack_ScoreA);
                            }
                        }
                        //All possibilities that A loses against C 
                        else
                        {
                            Round = 1;
                            fighters = "A-C";
                            StateA = "Defeated";
                            StateB = "Non-figther";
                            StateC = "Survivor";
                            HPC -= 25;
                            HPA = 0;
                            Attack_ScoreA = 0;
                            Attack_ScoreB = 0;
                            Attack_ScoreC = 10 * ACManDis + 100 - HPC;
                            Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charA, StateA, HPA, Attack_ScoreA);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charB, StateB, HPB, Attack_ScoreB);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}\n", charC, StateC, HPC, Attack_ScoreC);
                           
                            //After C defeated A ,if the distance between B and C is shorter than 15 they fight
                            //if C wins against A ,then it has to lose against B
                            if (BCDis <= 15)
                            {
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "C-B";
                                StateB = "Survivor";
                                StateC = "Defeated";
                                HPC = 0;
                                HPB -= 25;
                                Attack_ScoreB = 10 * ABManDis + 100 - HPB;
                                Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charA, StateA, HPA, Attack_ScoreA);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charB, StateB, HPB, Attack_ScoreB);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}\n", charC, StateC, HPC, Attack_ScoreC);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                //Camparing which player has the maximum score 
                                if (Attack_ScoreC < Attack_ScoreB)
                                {
                                    Console.WriteLine("{0} has the maximum Score ({1})", charB, Attack_ScoreB);
                                }
                                else
                                {
                                    Console.WriteLine("{0} has the maximum Score ({1})", charC, Attack_ScoreC);
                                }
                            }
                            //The possibility that the distance between C and B is greater than 15 and no one fights in second round
                            else
                            {
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "C-B";
                                Console.WriteLine("Round  {0}:    {1}", Round, fighters);
                                Console.WriteLine("Too Distant, no attack ");
                                Console.WriteLine("{0} has the maximum score  ({1})", charC, Attack_ScoreC);
                            }
                        }
                    }


                    //if the distance between B and C is the shortest distance and it is also smaller than 15
                    else if ((BCDis < ABDis) & (BCDis < ACDis) & (BCDis <= 15))
                    {
                        //All possibilities that B Wins against C
                        if ((SetB == 1 & SetC == 3) || (SetB == 2 & SetC == 1) || (SetB == 3 & SetC == 2))
                        {
                            Round = 1;
                            fighters = "B-C";
                            StateA = "Non-figther";
                            StateB = "Survivor";
                            StateC = "Defeated";
                            HPB -= 25;
                            HPC = 0;
                            Attack_ScoreA = 0;
                            Attack_ScoreB = 10 * BCManDis + 100 - HPB;
                            Attack_ScoreC = 0;
                            Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charA, StateA, HPA, Attack_ScoreA);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charB, StateB, HPB, Attack_ScoreB);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}\n", charC, StateC, HPC, Attack_ScoreC);

                            //After B defeated C ,if the distance between A and B is shorter than 15 they fight
                            //if B wins against C ,then it has to lose against A
                            if (ABDis <= 15)
                            {
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "A-B";
                                StateA = "Survivor";
                                StateB = "Defeated";
                                HPB = 0;
                                HPA -= 25;
                                Attack_ScoreA = 10 * ABManDis + 100 - HPA;
                                Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charA, StateA, HPA, Attack_ScoreA);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charB, StateB, HPB, Attack_ScoreB);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}\n", charC, StateC, HPC, Attack_ScoreC);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                //Camparing which player has the maximum score
                                if (Attack_ScoreB < Attack_ScoreA)
                                {
                                    Console.WriteLine("{0} has the maximum Score ( {1} )", charA, Attack_ScoreA);
                                }
                                else
                                {
                                    Console.WriteLine("{0} has the maximum Score ( {1} )", charB, Attack_ScoreB);
                                }
                            }
                            //The possibility that the distance between A and B is greater than 15 and no one fights in second round
                            else
                            {
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "A-B";
                                Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                                Console.WriteLine("Too Distant, no attack ");
                                Console.WriteLine("{0} has the maximum score  ({1})", charB, Attack_ScoreB);
                            }
                        }
                        //All possibilities that B loses against C
                        else
                        {
                            Round = 1;
                            fighters = "B-C";
                            StateA = "Non-figther";
                            StateB = "Defeated";
                            StateC = "Survivor";
                            HPC -= 25;
                            HPB = 0;
                            Attack_ScoreA = 0;
                            Attack_ScoreB = 0;
                            Attack_ScoreC = 10 * BCManDis + 100 - HPC;
                            Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charA, StateA, HPA, Attack_ScoreA);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charB, StateB, HPB, Attack_ScoreB);
                            Thread.Sleep(500);
                            Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}\n", charC, StateC, HPC, Attack_ScoreC);

                            //After C defeated B ,if the distance between A and C is shorter than 15 they fight
                            //if C wins against B ,then it has to lose against A
                            if (ACDis <= 15)
                            {
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "A-C";
                                StateA = "Survivor";
                                StateC = "Defeated";
                                HPC = 0;
                                HPA -= 25;
                                Attack_ScoreA = 10 * ACManDis + 100 - HPA;
                                Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charA, StateA, HPA, Attack_ScoreA);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}", charB, StateB, HPB, Attack_ScoreB);
                                Thread.Sleep(500);
                                Console.WriteLine("{0}:{1}\tHealth:{2}\tScore:{3}\n", charC, StateC, HPC, Attack_ScoreC);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                
                                //Camparing which player has the maximum score
                                if (Attack_ScoreC < Attack_ScoreA)
                                {
                                    Console.WriteLine("{0} has the maximum Score ( {1} )", charA, Attack_ScoreA);
                                }
                                else
                                {
                                    Console.WriteLine("{0} has the maximum Score ( {1} )", charC, Attack_ScoreC);
                                }
                            }
                            //The possibility that the distance between A and C is greater than 15 and no one fights in second round
                            else
                            {
                                Thread.Sleep(2000);
                                Round = 2;
                                fighters = "A-C";
                                Console.WriteLine("Round  {0}:\t{1}", Round, fighters);
                                Console.WriteLine("Too Distant, no attack ");
                                Console.WriteLine("{0} has the maximum score  ( {1} )", charC, Attack_ScoreC);
                            }
                        }
                    }
                    else
                    {
                        //If all the distinces between players are greater than 15 ,no one fights at all
                        Thread.Sleep(2000);
                        Console.WriteLine("Too distant no attack");
                    }


                }
                else
                {
                    //The message which user receives ,if enters a number greater than 10 or less than -10 as Ax and Ay values
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n.................................................");
                    Console.WriteLine(" The AX and AY values must be between 10 and -10");
                    Console.WriteLine(".................................................");
                }
            }
            else 
            {
                //The message which user receives ,if enters anything other than an integer as Ax and Ay values
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n.......................................................");
                Console.WriteLine(" The AX and AY values must be between an integer number");
                Console.WriteLine(".......................................................");
                Console.ForegroundColor = ConsoleColor.Gray;

            }

            //Generally it takes input from user but in here is used to keep the Console open until user presses the enter key
                Console.Read();

            //stops the background music
            player.Stop();
        }      
    }
}
    

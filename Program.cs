using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tICK_tAK_tOE
{
    class Program
    {
        static string Player1;
        static string Player2;
        static char[,] myArray = new char[,]
            {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' },
            };

        static void Main(string[] args)
        {
            SetField();
            SetPlayer();
            SetPlayerOneInput(); // this function Contains 2nd Players input ALso
            Console.ReadKey();
        }
        public static void SetField()

        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t{0}\t{1}\t{2}", myArray[0, 0], myArray[0, 1], myArray[0, 2]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t{0}\t{1}\t{2}", myArray[1, 0], myArray[1, 1], myArray[1, 2]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t{0}\t{1}\t{2}", myArray[2, 0], myArray[2, 1], myArray[2, 2]);

        }
        public static void SetPlayer()
        {
            Console.WriteLine("Enter Name");
            Player1 = Console.ReadLine();
            Console.WriteLine("Enter Name");
            Player2 = Console.ReadLine();
            Console.Write("Player one is {0} \n", Player1);
            Console.Write("Player two is {0} \n", Player2);

        }

        public static void SetPlayerOneInput()
        {

            bool x = true;

            while (x)
            {
                Console.WriteLine("Player {0} turn ", Player1);
                Console.WriteLine();
                string input1 = Console.ReadLine();
                switch (input1)
                {
                    // Ist Row Changing
                    case "1": myArray[0, 0] = 'X'; break;
                    case "2": myArray[0, 1] = 'X'; break;
                    case "3": myArray[0, 2] = 'X'; break;
                    // 2nd Row Changing

                    case "4": myArray[1, 0] = 'X'; break;
                    case "5": myArray[1, 1] = 'X'; break;
                    case "6": myArray[1, 2] = 'X'; break;

                    // 3rd Row Changing

                    case "7": myArray[2, 0] = 'X'; break;
                    case "8": myArray[2, 1] = 'X'; break;
                    case "9": myArray[2, 2] = 'X'; break;
                    default: x = false; break;

                }
                Console.Clear(); // Clearing Screen
                SetField(); // Caling Dash Board

                // Player One Check 
                if (myArray[0, 0] == 'X' && myArray[0, 1] == 'X' && myArray[0, 2] == 'X')
                {
                    Console.WriteLine("Player {0} Won \n", Player1);
                    break;
                }
                else if (myArray[1, 0] == 'X' && myArray[1, 1] == 'X' && myArray[1, 2] == 'X')
                {
                    Console.WriteLine("Player {0} Won \n", Player1); break;
                }
                else if (myArray[2, 0] == 'X' && myArray[2, 1] == 'X' && myArray[2, 2] == 'X')
                {
                    Console.WriteLine("Player {0} Won \n", Player1); break;
                }
                else if (myArray[0, 0] == 'X' && myArray[1, 0] == 'X' && myArray[2, 0] == 'X')
                {
                    Console.WriteLine("Player {0} Won \n", Player1); break;
                }
                else if (myArray[0, 1] == 'X' && myArray[1, 1] == 'X' && myArray[2, 1] == 'X')
                {
                    Console.WriteLine("Player {0} Won \n", Player1); break;
                }
                else if (myArray[0, 2] == 'X' && myArray[1, 2] == 'X' && myArray[2, 2] == 'X')
                {
                    Console.WriteLine("Player {0} Won \n", Player1); break;
                }
                else if (myArray[0, 0] == 'X' && myArray[1, 1] == 'X' && myArray[2, 2] == 'X')
                {
                    Console.WriteLine("Player {0} Won \n", Player1); break;
                }
                else if (myArray[0, 2] == 'X' && myArray[1, 1] == 'X' && myArray[2, 0] == 'X')
                {
                    Console.WriteLine("Player {0} Won \n", Player1); break;
                }

                SetPlayerTwoInput(); // Player Two Related Function
                // Player Two Check
            if (myArray[0, 0] == 'Y' && myArray[0, 1] == 'Y' && myArray[0, 2] == 'Y')
                {
                    Console.WriteLine("Player {0} Won \n", Player2);
                    break;
                }
                else if (myArray[1, 0] == 'Y' && myArray[1, 1] == 'Y' && myArray[1, 2] == 'Y')
                {
                    Console.WriteLine("Player {0} Won \n", Player2); break;
                }
                else if (myArray[2, 0] == 'Y' && myArray[2, 1] == 'Y' && myArray[2, 2] == 'Y')
                {
                    Console.WriteLine("Player {0} Won \n", Player2); break;
                }
                else if (myArray[0, 0] == 'Y' && myArray[1, 0] == 'Y' && myArray[2, 0] == 'Y')
                {
                    Console.WriteLine("Player {0} Won \n", Player2); break;
                }
                else if (myArray[0, 1] == 'Y' && myArray[1, 1] == 'Y' && myArray[2, 1] == 'Y')
                {
                    Console.WriteLine("Player {0} Won \n", Player2); break;
                }
                else if (myArray[0, 2] == 'Y' && myArray[1, 2] == 'Y' && myArray[2, 2] == 'Y')
                {
                    Console.WriteLine("Player {0} Won \n", Player2); break;
                }
                else if (myArray[0, 0] == 'Y' && myArray[1, 1] == 'Y' && myArray[2, 2] == 'Y')
                {
                    Console.WriteLine("Player {0} Won \n", Player2); break;
                }
                else if (myArray[0, 2] == 'Y' && myArray[1, 1] == 'Y' && myArray[2, 0] == 'Y')
                {
                    Console.WriteLine("Player {0} Won \n", Player2); break;
                }
            }


        }
        public static void SetPlayerTwoInput()
        {
            Console.WriteLine("Player {0} turn ", Player2);
            Console.WriteLine();
            string input2 = Console.ReadLine();
            switch (input2)
            {
                // Ist Row Changing
                case "1": myArray[0, 0] = 'Y'; break;
                case "2": myArray[0, 1] = 'Y'; break;
                case "3": myArray[0, 2] = 'Y'; break;
                // 2nd Row Changing

                case "4": myArray[1, 0] = 'Y'; break;
                case "5": myArray[1, 1] = 'Y'; break;
                case "6": myArray[1, 2] = 'Y'; break;

                // 3rd Row Changing

                case "7": myArray[2, 0] = 'Y'; break;
                case "8": myArray[2, 1] = 'Y'; break;
                case "9": myArray[2, 2] = 'Y'; break;
                default:
                    Console.WriteLine("You have Entered Wrong Input\n");
                    break;
            }
            Console.Clear(); // Clearing Screen
            SetField(); // Caling Dash Board


        }

    }


}


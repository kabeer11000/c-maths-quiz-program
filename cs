using System;

namespace try_app
{
    class Program
    {

        static void Main(string[] args)
        {
            Random numbergenerator = new Random();
 
            string appnaem = " Addition Quiz";
            string appversion = " 1.0.1";
            string appauthor = " kabeer jaffri";


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: version {1} by {2}", appnaem, appversion, appauthor);

            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" whats your name? ");
            Console.ResetColor();

            Console.WriteLine();
            Console.Write(" ");
            string input1 = Console.ReadLine();

            Console.Beep();
            // start
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine(" Hello  " + input1);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(input1 + " , " + " what a nice name");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();

            //Console.WriteLine();
            Console.WriteLine(" whats your age? ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(" ");
            
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  you are " + input1 + " and you are " + age + " years old right ");
            
            Console.WriteLine();
            Console.WriteLine("  Press enter to proceed tp the game...");
            Console.ReadLine();
            Console.WriteLine("     Ok  " + input1);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("     lets play a game");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" We'll play a simple number addition quiz game");


            Console.ResetColor();
            Console.WriteLine("\n  \n  \n This Is a addition Practice \n  Program for simple \n addition quiz");

            Console.WriteLine("");
            Console.WriteLine("  First Question");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Green;

            

            int num5 = 0;
            do
            {



                
                int num01 = numbergenerator.Next(50, 400);
                int num02 = numbergenerator.Next(20, 300);
                Console.WriteLine("");
                Console.WriteLine(" what is  " + num01 + " plus " + num02);

                int answer = Convert.ToInt32(Console.ReadLine());


                if (answer == num01 + num02)
                {
                    int responsiveindex2 = numbergenerator.Next(1, 4);
                    switch (responsiveindex2)
                    {
                        case 7:
                            Console.WriteLine("");
                            Console.WriteLine("VERY good");

                            break;

                        case 8:
                            Console.WriteLine("");
                            Console.WriteLine("Right answer");

                            break;
                            
                        case 9:
                            Console.WriteLine("");
                            Console.WriteLine("good job");

                            break;

                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Correct Answer");
                            Console.BackgroundColor = ConsoleColor.Green;

                            break;


                    }








                }
                else
                {
                    Console.BackgroundColor = ConsoleColor. Red;
                    int responseindex = numbergenerator.Next(1, 4);
                    switch (responseindex)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("are u even trying");
                            break;

                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("what the heck bro");

                            break;

                        case 3:
                            Console.WriteLine("");

                            Console.WriteLine("the fuck im going");

                            break;

                        default:
                            Console.WriteLine("");
                            Console.WriteLine("the answer was incorrect");
                            break;


                    }


                }
            } while (num5 < 99999);

            Console.ReadLine();




            



        }
    }
}    

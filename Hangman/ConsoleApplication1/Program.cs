using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {

            string menuInput = null;
            int menuOption = 0;
            bool menu = true;
            bool running = true;

            while (running == true)
            {



                while (menu == true)
                {


                    Console.WriteLine("Hangman Menu:\n");
                    Console.WriteLine("1. Play Hangman\n");
                    Console.WriteLine("2. Exit Program\n");

                    menuInput = Console.ReadLine();

                    int.TryParse(menuInput, out menuOption);

                    if (menuOption != 1 && menuOption != 2)
                    {
                        Console.WriteLine("Please choose a valid option");
                        menu = true;
                    }

                    else if (menuOption == 1 || menuOption == 2)
                    {
                        menu = false;
                    }
                }


                Console.Clear();
                if (menuOption == 1)
                {
                    Console.WriteLine("Your choice is {0}", menuOption);
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Under construction.\nRouting back to menu...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    menu = true;
                }

                else if (menuOption == 2)
                {
                    Console.WriteLine("Your choice is {0}", menuOption);
                    running = false;

                }



            }
            //System.Threading.Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("Closing application");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Application closed");
            Console.ReadKey();
        }
    }
}

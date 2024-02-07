using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Earmad_bandit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string LeverPull = "";
            int bet = 0;
            int Current_Tokens = 10;
            Random slots = new Random();

            Console.WriteLine("To play 'The one Armed Bandit,' you must first place a bet.\nPlace a bet with tokens below. You can only bet your maximum value of tokens, and you have to place a bet. \nYour currently have " + Current_Tokens + " tokens.");
            
            FuncBet();
            Console.WriteLine("You've placed a bet of " + bet + " tokens.");

            Console.WriteLine("Now it's time to pull the lever of the machine.\n Press 'P' to pull the lever...");
            FuncLever();

            void FuncBet()
            {
                while (true) 
                {
                    Console.WriteLine("Place a bet between 1 and " + Current_Tokens);
                    bet = Convert.ToInt32(Console.ReadLine());


                    if (bet > Current_Tokens)
                    {
                        Console.WriteLine("You can't bet that high...");
                    }

                    if (bet == 0)
                    {
                        Console.WriteLine("You have to place a bet of tokens...");
                    }
                
                    if (bet <= Current_Tokens && bet > 0)
                    {
                        Current_Tokens = Current_Tokens - bet;
                        break;
                    }
                    
                
                }
            }

            void FuncLever()
            { 
                

                while (true) 
                {
                   LeverPull = Console.ReadLine();

                    if (LeverPull != "p" || LeverPull != "P")
                    {
                        Console.WriteLine("It only works if you press 'p' on your keyboard...");
                    }

                }


            
            }

        }
        
    }
}

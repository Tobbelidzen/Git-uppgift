using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[3]; 
            {
                for (int i = 0; i < 3; i++) 
                {
                    Console.WriteLine("Type name " + (i + 1));
                    name[i] = Console.ReadLine();             
                }
                
                for (int p = 0; p < 3; p++)
                {
                    Console.WriteLine(name[p]);           
                }
            }               
        }
    }
}

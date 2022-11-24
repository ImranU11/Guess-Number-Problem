using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Number_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int num = rd.Next(1, 101);
            Console.WriteLine(num);
            bool correct = false;
            
            while (!correct)
            {
                Console.WriteLine("please guess a number between 1 - 100");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice > num)
                {
                    
                    Console.WriteLine("To high, go lower");
                }
                else if (choice < num)
                {
                    Console.WriteLine("To low, go higher");
                }
                else if (choice == num)
                {
                    Console.WriteLine("Well done, the number is {0}", choice);
                    correct = true;
                }
                else
                {
                    Console.WriteLine("that is not a valid input");
                }
                Console.ReadLine();

            }


        }

    }
}
        

              
         

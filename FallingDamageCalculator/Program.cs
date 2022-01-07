using FallingDamageCalculator.Models;
using System;

namespace FallingDamageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, time to kill some Player Characters");
            
            int fall = 0;
            string quit = "";
            CalculateDamage damage;
            
            while (true)
            {
                try
                {
                    Console.WriteLine("How long have we been falling?");
                    fall = Convert.ToInt32(Console.ReadLine());
                    if (fall < 10)
                    {
                        Console.WriteLine("You take no falling damage");
                    }
                    else
                    {
                        damage = new CalculateDamage(fall);
                        Console.WriteLine("Damage taken: " + damage.CalculateFall());
                        Console.WriteLine();
                        Console.WriteLine("Do you want to quit?");
                        quit = Console.ReadLine();
                    }
                    
                    
                    if (quit == "yes" || quit == "Yes" || quit == "YES")
                    {
                        return;
                    }
                    
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("Write in digits please");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            
            
        }
    }
}

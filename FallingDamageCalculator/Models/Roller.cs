using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingDamageCalculator.Models
{
    public class Roller
    {
        public Random roll { get; set; }

        public Roller()
        {
            roll = new Random();
        }

        public int RollDice(int amount)
        {
            int result = 0;
            int rull = 0;
            int tix = 0;
            for (int i = 0; i < amount; ++i)
            {
                rull = roll.Next(1, 7);
                ++tix;
                result += rull;
            }
            Console.WriteLine($"Character will take {tix}d6's of falling damage");
            
            return result;
        }
        
    }
}

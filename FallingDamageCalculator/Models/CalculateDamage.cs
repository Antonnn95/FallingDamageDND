using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingDamageCalculator.Models
{
    public class CalculateDamage
    {
        public Creature creature { get; set; }
        public Roller Roller { get; set; }
        
       

        public CalculateDamage(int fall)
        {
            creature = new Creature(fall);
            Roller = new Roller();
            
        }

        

        public int CalculateFall()
        {
            double resultDUO = 0;
            double rounded = 0;
            resultDUO = (creature.CurrentVelocity / creature.TerminalVelocity) * 20;
            rounded = Math.Round(resultDUO);
            int result = 0;
            result = Convert.ToInt32(rounded);
            if (result > 20)
            {
                return Roller.RollDice(20);
            }
            else
            {
                return Roller.RollDice(result);
            }
            
            

        }

        


    }
}

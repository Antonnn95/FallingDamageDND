using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingDamageCalculator.Models
{
    public class Creature
    {
        public double DragCoefficient { get; set; }
        public double BodyArea { get; set; }
        public double Weight { get; set; }


        public double TerminalVelocity { get; set; }
        public double CurrentVelocity { get; set; }
        public double Falling { get; set; }

        public Creature(int fall)
        {
            DragCoefficient = 1.2;
            BodyArea = 0.6;
            Weight = 70;
            Falling = CalculateDistanceFallen(fall);
            TerminalVelocity = CalculateTerminalVelocity();
            CurrentVelocity = CalculateCurrentVelocity();
        }

        public double CalculateTerminalVelocity()
        {
            double result = 0;
            result = Math.Sqrt((2 *9.8* Weight) / (1.25 *BodyArea * DragCoefficient));
            return result;
        }

        public double CalculateCurrentVelocity()
        {
            double result = 0;
            double co = 0.25; 
            for (int i = 0; i <= Falling ; ++i)
            {
                
                result = TerminalVelocity * Math.Tanh((9.8 * co) / TerminalVelocity);
                co += 0.25 - result / TerminalVelocity * (0.25 - (0.3048 / 53));

            }
            
            return result;
        }

        public double CalculateDistanceFallen(int feet)
        {
            double time = feet*0.3048*0.25;
            return time;

        }
    }
}

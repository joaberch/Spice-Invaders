using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Display;

namespace Model
{
    public class Score
    {
        public int score = 0;                       //Variable taking the score
        Playground playground = new Playground();   //Using the playground to be able to dispay the score

        /// <summary>
        /// Adding 10 points in the score
        /// </summary>
        public void AddScore(int s)
        {
            score += 10*s;
        }

        /// <summary>
        /// Displaying the score by going on the Display library
        /// </summary>
        public void DisplayScore()
        {
            playground.DisplayScore(score);
        }
    }
}

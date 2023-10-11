using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Display
{

    public class Playground
    {
        //Sprite of the ammo
        private const string AMMOSPRITE = "|"; 

        //Sprite of the enemy
        public string[] ennemySprite1 =
        {
            @".-.",
            @"|-|",
            @"` '"
        };

        //Sprite of the player
        public string[] PlayerSprite1 =
{
            @"   __",
            @"  /__\",
            @" /(__)\",
            @"(__)(__)",
     };

        /// <summary>
        /// Display the ammo at the position selected
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void DisplayAmmunition(int x, int y)
        {
            Console.SetCursorPosition(x+4, y);
            Console.WriteLine(AMMOSPRITE);
        }

        /// <summary>
        /// Display the enemy at the position selected
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void DisplayEnemy1(int x, int y)
        {
            for(int i=0;i<3;++i)
            {
                Console.SetCursorPosition(x, y+i);
                Console.Write(ennemySprite1[i]);
            }
        }

        /// <summary>
        /// Display the player at the position selected
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void DisplayShip(int x, int y)
        {
            for (int i = 0; i < 4; ++i)
            {
                Console.SetCursorPosition(x, y+i);
                Console.Write(PlayerSprite1[i]);
            }
        }

        /// <summary>
        /// Display the score
        /// </summary>
        /// <param name="score"></param>
        public void DisplayScore(int score)
        {
            Console.SetCursorPosition(Config.WINDOW_WIDTH-15, 0);
            Console.WriteLine($"Score : {score}");
        }
    }
}

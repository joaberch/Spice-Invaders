using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Display
{

    public class Playground
    {
        private const string AMMOSPRITE = "|";

        public string[] ennemySprite1 =
        {
            @".-.",
            @"|-|",
            @"` '"
        };
        public string[] PlayerSprite1 =
{
            @"   __",
            @"  /__\",
            @" /(__)\",
            @"(__)(__)",
     };

        public void DisplayAmmunition(int x, int y)
        {
            Console.SetCursorPosition(x+4, y);
            Console.WriteLine(AMMOSPRITE);
        }
        public void DisplayEnemy1(int x, int y)
        {
            for(int i=0;i<3;++i)
            {
                 Console.SetCursorPosition(x, y+i);
                Console.Write(ennemySprite1[i]);
            }
        }

        public void DisplayShip(int x, int y)
        {
            for (int i = 0; i < 4; ++i)
            {
                Console.SetCursorPosition(x, y+i);
                Console.Write(PlayerSprite1[i]);
            }
        }
    }
}

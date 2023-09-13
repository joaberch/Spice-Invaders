using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_Invaders
{
    internal class Vaisseau
    {
        public int x = 0;
        public int y = Console.WindowHeight-HAUTEURVAISSEAU;
        const int HAUTEURVAISSEAU = 4;
        public string[] PlayerSprite =                      //Sprite du parachutiste sans parachute
{
            @"   __",
            @"  /__\",
            @" /(__)\",
            @"(__)(__)",
     };
        public Vaisseau(int vieVaisseau)                    //Constructeur 1
        {

        }

        public void show()                                  //Afficher le vaisseau du joueur
        {
            for (int i = 0; i < HAUTEURVAISSEAU; ++i)
            {
                Console.SetCursorPosition(x, Console.WindowHeight-HAUTEURVAISSEAU+i);   //Sélectionne le bas de l'écran + 1
                Console.WriteLine(PlayerSprite[i]);
            }
        }

        public void MovingLeft()
        {
            if(x <= 1)
            {

            }
            else
            {
                --x;
            }
        }

        public void MovingRight()
        {
            if (x >= Console.WindowWidth-4-PlayerSprite.Length)
            {

            }
            else
            {
                ++x;
            }
        }

        public void Shoot()
        {
            Ammunition ammo = new Ammunition(x, y);
        }

    }
}

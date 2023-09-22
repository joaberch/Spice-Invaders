using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Display;

namespace Model
{
    internal class Player
    {
        Playground playground = new Playground();
        public int x = 0;
        public int y = Console.WindowHeight - HAUTEURVAISSEAU;
        const int HAUTEURVAISSEAU = 4;

        public Player(int vieVaisseau)                    //Constructeur 1
        {

        }

        public void show()                                  //Afficher le vaisseau du joueur
        {
            for (int i = 0; i < HAUTEURVAISSEAU; ++i)
            {
                Console.SetCursorPosition(x, Console.WindowHeight - HAUTEURVAISSEAU + i);   //Sélectionne le bas de l'écran + 1
                playground.DisplayShip(x, y);
            }
        }

        public void MovingLeft()
        {
            if (x <= 1)
            {

            }
            else
            {
                --x;
            }
        }

        public void MovingRight()
        {
            if (x >= Console.WindowWidth - 4 - playground.PlayerSprite1.Length)
            {

            }
            else
            {
                ++x;
            }
        }

        public void Shoot()
        {
            Ammo ammo = new Ammo(x, y);
        }
    }
}

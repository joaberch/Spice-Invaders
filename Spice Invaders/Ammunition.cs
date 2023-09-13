using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_Invaders
{
    internal class Ammunition
    {
        //Collection of bullet
        public List<Ammunition> ammoshooted = new List<Ammunition>();
        public const string AMMOSPRITE = "|";
        public int xammo;
        public int yammo;
        public int compteur = 0;
        public Ammunition(int x, int y)    //Constructeur
        {
            xammo = x;
            yammo = y;
        }

        public void show()
        {
            if (yammo-compteur >= 1) //Si le missile atteint la fin de l'écran il n'est plus affiché
            {
                Console.SetCursorPosition(xammo + 4, yammo - compteur);
                Console.Write(AMMOSPRITE);
            }
        }

        public void move()
        {
            if (yammo - compteur >= 1) //Si le missile atteint la fin de l'écran il n'est plus calculé
            {
                ++compteur;
            }
        }

    }
}

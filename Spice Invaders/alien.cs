using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_Invaders
{
    internal class alien
    {
        public string[] ennemySprite1 =
        {
            @".-.",
            @"|-|",
            @"` '"
        };
        List<alien> alive = new List<alien>();
        public alien(string shooter)  //Constructeur 1 (weak ennemy white)
        {

        }
        public alien(int x)  //Constructeur 2 (average ennemy green)
        {

        }
        public alien()      //Constructeur 3 (strong ennemy blue)
        {

        }
        public void creatingenemy(int p)
        {
            for(int i = 0; i<=p;++i)
            {
                alive.Add(new alien(i));
            }
        }
        
    }
}

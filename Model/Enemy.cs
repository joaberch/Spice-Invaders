using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Enemy
    {
        List<Enemy> alive = new List<Enemy>();
        public Enemy(string shooter)  //Constructeur 1 (weak ennemy white)
        {

        }
        public Enemy(int x)  //Constructeur 2 (average ennemy green)
        {

        }
        public Enemy()      //Constructeur 3 (strong ennemy blue)
        {

        }
        public void creatingenemy(int p)
        {
            for (int i = 0; i <= p; ++i)
            {
                alive.Add(new Enemy(i));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Display;
namespace Model
{

    public class Ammo
    {
        Playground playground = new Playground();
        //Collection of bullet
        public List<Ammo> ammoshooted = new List<Ammo>();
        public int x;
        public int y;
        public int compteur = 0;
        public Ammo(int x, int y)    //Constructeur
        {
            this.x = x;
            this.y = y;
        }

        public void show()
        {
            y -= 1;
            playground.DisplayAmmunition(x, y);
        }

        public void move()
        {
            ++compteur;
        }
    }
}
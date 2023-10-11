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

        //TODO : dette technique bool
        //public List<Ammo> ammoshooted = new List<Ammo>(); 
        public int x;                       //coordinate x of the ammo
        public int y;                       //coordinate y of the ammo
        public bool hastouched = false;     //check if the ammo has touched an enemy so that it can be removed
        //public int compteur = 0;

        /// <summary>
        /// Constructor of the ammo, we get the x and y coordinate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Ammo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Display the ammo at the x and y coordinate
        /// </summary>
        public void show()
        {
            playground.DisplayAmmunition(x, y);
        }

        /// <summary>
        /// making the ammo move by going up
        /// </summary>
        public void move()
        {
            y--;
        }
    }
}
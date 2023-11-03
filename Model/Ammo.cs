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

        public int x_position;                       //Coordinate x of the ammo
        public int y_position;                       //Coordinate y of the ammo
        public bool hastouched;                      //Check if the ammo has touched an enemy so that it can be removed

        /// <summary>
        /// Constructor of the ammo, we get the x and y coordinate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Ammo(int x, int y)
        {
            this.x_position = x;
            this.y_position = y;
        }

        /// <summary>
        /// Display the ammo at the x and y coordinate
        /// </summary>
        public void show()
        {
            playground.DisplayAmmunition(x_position, y_position);
        }

        /// <summary>
        /// Making the ammo move by going up
        /// </summary>
        public void move()
        {
            y_position--;
        }
    }
}
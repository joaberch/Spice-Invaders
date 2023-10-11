using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Display;

namespace Model
{
    public class Player
    {
        Playground playground = new Playground();               //Instantiating the playground so that i can display the player
        public int x = 0;                                       //Variable taking the x position of the ship
        public int y = Config.WINDOW_HEIGHT - HAUTEURVAISSEAU;  //Variable taking the y position of the ship
        const int HAUTEURVAISSEAU = 4;                          //constant taking the height of the sprite of the ship

        /// <summary>
        /// Constructor of the ship
        /// </summary>
        /// <param name="vieVaisseau"></param>
        public Player(int vieVaisseau)
        {

        }

        /// <summary>
        /// Displaying the ship of the player
        /// </summary>
        public void show()
        {
            playground.DisplayShip(x, y);
        }

        /// <summary>
        /// Making the ship moving to the left
        /// </summary>
        public void MovingLeft()
        {
            if (x >= 1)                     //If it hasn't reached the left border it goes to the left
            {
                --x;
            }
        }

        /// <summary>
        /// Making the ship moving to the right
        /// </summary>
        public void MovingRight()           //If it hasn't reached the right border it goes to the right
        {
            if (x <= Config.WINDOW_WIDTH - 4 - playground.PlayerSprite1.Length)
            {
                ++x;
            }
        }

        /*public void Shoot()
        {
            Ammo ammo = new Ammo(x, y);
        }*/
    }
}

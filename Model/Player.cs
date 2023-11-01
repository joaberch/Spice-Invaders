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
        public int x_position = 0;                                       //Variable taking the x position of the ship
        public int y_position = Config.WINDOW_HEIGHT - HAUTEURVAISSEAU;  //Variable taking the y position of the ship
        const int HAUTEURVAISSEAU = 4;                          //Constant taking the height of the sprite of the ship

        /// <summary>
        /// Displaying the ship of the player
        /// </summary>
        public void show()
        {
            playground.DisplayShip(x_position, y_position);
        }

        /// <summary>
        /// Making the ship moving to the left
        /// </summary>
        public void MovingLeft()
        {
            if (x_position >= 1)                     //If it hasn't reached the left border it goes to the left
            {
                --x_position;
            }
        }

        /// <summary>
        /// Making the ship moving to the right
        /// </summary>
        public void MovingRight()           //If it hasn't reached the right border it goes to the right
        {
            if (x_position <= Config.WINDOW_WIDTH - 4 - playground.PlayerSprite1.Length)
            {
                this.x_position++;
            }
        }
    }
}

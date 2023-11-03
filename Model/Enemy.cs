using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Display;

namespace Model
{
    public class Enemy
    {
        Playground playground = new Playground();                   //Instantiating the playground in order to use the sprite of the enemy
        public int _x_position = 3;                                 //Variable taking the x poisition of the enemy
        public int _y_position;                                     //Variable taking the y position of the enemy
        public int numberofenemy;                                   //Variable taking the number of enemy
        public bool IsItGoingToTheRight = true;                     //Boolean variable who tell if the enemy is moving to the right or to the left
        public int _Enemy_lifePoint;                                //Variable taking the number of life point of the enemy

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="Enemy_LifePoint"></param>
        public Enemy(int _position, int Enemy_LifePoint)
        {
            _x_position = _position;                                //The x position of the enemy is the one choosen when the enemy are instantiate
            _y_position = 3;                                        //The y position of the enemy is 3 by default
            _Enemy_lifePoint = Enemy_LifePoint;                     //The number of life point of the enemy is the one choosen in when the enemy is instantiate
        }

        /// <summary>
        /// Displaying each enemy
        /// </summary>
        public void show()
        {
            playground.DisplayEnemy1(_x_position, _y_position);
        }

        /// <summary>
        /// Making each enemy move
        /// </summary>
        public void move()
        {
            if (IsItGoingToTheRight)                                //If the enemy should go to the right it go to the right else it go to the left
            {
                _x_position++;
            }
            else
            {
                _x_position--;
            }
        }

        /// <summary>
        /// Making the enemy go down
        /// </summary>
        public void moveDown()
        {
            this._y_position += 1;                                  //Do it twice so go down twice, it make the enemy go down by 1 pixel 2 times (so make the enemy go down by 2 pixel)

            if(IsItGoingToTheRight)                                 //If it was going to the right it start going to the left
            {
                IsItGoingToTheRight=false;
            }
            else                                                    //If it was going to the left it start going to the right
            {
                IsItGoingToTheRight = true;
            }
        }

        /// <summary>
        /// Making the enemy loose a life point
        /// </summary>
        public void takeDamage()
        {
            this._Enemy_lifePoint--;                                //Make the enemy lose life point
        }
    }
}

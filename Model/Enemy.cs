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
        Playground playground = new Playground();       //Instantiating the playground in order to use the sprite of the enemy
        List<Enemy> alive = new List<Enemy>();          //Collection of the enemy alive TODO 
        public int _x = 3;                              //Variable taking the x poisition of the enemy
        public int _y;                                  //Variable taking the y position of the enemy
        public int nbrenemy;                            //Variable taking the number of enemy
        public bool IsGoingToTheRight = true;           //Boolean variable who tell if the enemy is moving to the right or to the left
        public int _lifePoint;                          //Variable taking the number of life point of the enemy

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="lifePoint"></param>
        public Enemy(int x, int lifePoint)
        {
            _x = x;                                     //The x position of the enemy is the one choosen when the enemy are instantiate
            _y = 3;                                     //The y position of the enemy is 3
            _lifePoint = lifePoint;                     //The number of life point of the enemy is the one choosen in when the enemy is instantiate
        }

        /// <summary>
        /// Creating enemy
        /// </summary>
        /// <param name="p"></param>
        public void creatingenemy(int p)
        {
            for (int i = 0; i <= p; ++i)
            {
                alive.Add(new Enemy(i, 1));
            }
        }


        /// <summary>
        /// Displaying each enemy
        /// </summary>
        public void show()
        {
            playground.DisplayEnemy1(_x, _y);
        }

        /// <summary>
        /// Making each enemy move
        /// </summary>
        public void move()
        {
            if (IsGoingToTheRight)
            {
                _x++;
            }
            else
            {
                _x--;
            }
        }

        /// <summary>
        /// Making the enemy go down
        /// </summary>
        public void moveDown()
        {
            this._y += 1; //Do it twice so go down twice
            if(IsGoingToTheRight)
            {
                IsGoingToTheRight=false;
            }
            else
            {
                IsGoingToTheRight = true;
            }
        }

        /// <summary>
        /// Making the enemy loose a life point
        /// </summary>
        public void takeDamage()
        {
            this._lifePoint--;
        }
    }
}

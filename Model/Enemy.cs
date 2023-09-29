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
        Playground playground = new Playground();
        List<Enemy> alive = new List<Enemy>();
        public int _x = 3;
        public int _y;
        public int nbrenemy;
        public bool IsGoingToTheRight = true;
        public int _lifePoint;
        public Enemy(int x, int lifePoint)  //Constructor 1 (weak enemy, white)
        {
            _x = x;
            _y = 0;
            _lifePoint = lifePoint;
        }
        
        public void creatingenemy(int p)
        {
            for (int i = 0; i <= p; ++i)
            {
                alive.Add(new Enemy(i, 1));
            }
        }

        public void show()
        {
            if (this._lifePoint > 0)
            {
                if (this._y < 3) { this._y = 3; }
                playground.DisplayEnemy1(_x, _y);
            }
        }
        public void move()
        {
            if (this._lifePoint > 0)
            {
                if (IsGoingToTheRight)
                {
                    this._x++;
                }
                else
                {
                    this._x--;
                }

                if (this._x >= Console.WindowWidth - 5)
                {
                    IsGoingToTheRight = false;
                    _y += 3;
                }

                if (this._x <= 0)
                {
                    _y += 3;
                    IsGoingToTheRight = true;
                    
                }
            }
        }
        public void takeDamage()
        {
            this._lifePoint--;

            if(this._lifePoint <= 0)
            {

            }
        }
    }
}

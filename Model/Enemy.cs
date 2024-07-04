using System;
using Display;

namespace Model
{
	public class Enemy
	{
		Playground playground = new Playground(); // Instantiating the playground in order to use the sprite of the enemy
		public int _x_position = 3;               // Variable taking the x position of the enemy
		public int _y_position;                   // Variable taking the y position of the enemy
		public int numberofenemy;                 // Variable taking the number of enemy
		public bool IsItGoingToTheRight = true;   // Boolean variable to tell if the enemy is moving to the right or to the left
		public int _Enemy_lifePoint;              // Variable taking the number of life points of the enemy

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="_position"></param>
		/// <param name="Enemy_LifePoint"></param>
		public Enemy(int _position, int Enemy_LifePoint)
		{
			_x_position = _position;              // The x position of the enemy is the one chosen when the enemy is instantiated
			_y_position = 3;                      // The y position of the enemy is 3 by default
			_Enemy_lifePoint = Enemy_LifePoint;   // The number of life points of the enemy is the one chosen when the enemy is instantiated
		}

		/// <summary>
		/// Displaying each enemy
		/// </summary>
		public void show()
		{
			//Console.WriteLine($"Displaying enemy at {_x_position}, {_y_position}");
			playground.DisplayEnemy1(_x_position, _y_position);
		}

		/// <summary>
		/// Making each enemy move
		/// </summary>
		public void move()
		{
			if (IsItGoingToTheRight)              // If the enemy should go to the right it goes to the right, else it goes to the left
			{
				_x_position++;
			}
			else
			{
				_x_position--;
			}
			//Console.WriteLine($"Enemy moved to {_x_position}, {_y_position}");
		}

		/// <summary>
		/// Making the enemy go down
		/// </summary>
		public void moveDown()
		{
			_y_position += 1;                     // Move down by 1 pixel

			if (IsItGoingToTheRight)              // If it was going to the right, it starts going to the left
			{
				IsItGoingToTheRight = false;
			}
			else                                  // If it was going to the left, it starts going to the right
			{
				IsItGoingToTheRight = true;
			}

			//Console.WriteLine($"Enemy moved down to {_x_position}, {_y_position}");
		}

		/// <summary>
		/// Making the enemy lose a life point
		/// </summary>
		public void takeDamage()
		{
			_Enemy_lifePoint--;                   // Make the enemy lose a life point
			//Console.WriteLine($"Enemy took damage. Life points left: {_Enemy_lifePoint}");
		}
	}
}

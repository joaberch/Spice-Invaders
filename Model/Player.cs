using System;
using Display;

namespace Model
{
	public class Player
	{
		Playground playground = new Playground();                           // Instantiating the playground so that I can display the player
		public int x_position = 0;                                          // Variable taking the x position of the ship
		public int y_position = Config.WINDOW_HEIGHT - HAUTEURVAISSEAU;     // Variable taking the y position of the ship
		const int HAUTEURVAISSEAU = 4;                                      // Constant taking the height of the sprite of the ship

		/// <summary>
		/// Displaying the ship of the player
		/// </summary>
		public void show()
		{
			//Console.WriteLine($"Displaying player at ({x_position}, {y_position})");
			playground.DisplayShip(x_position, y_position);
		}

		/// <summary>
		/// Making the ship move to the left
		/// </summary>
		public void MovingLeft()
		{
			if (x_position > 0)                                             // If it hasn't reached the left border it goes to the left
			{
				--x_position;
				//Console.WriteLine($"Player moved left to {x_position}");
			}
		}

		/// <summary>
		/// Making the ship move to the right
		/// </summary>
		public void MovingRight()
		{
			int shipWidth = 40;
			if (x_position < Config.WINDOW_WIDTH - shipWidth)               // If it hasn't reached the right border it goes to the right
			{
				++x_position;
				//Console.WriteLine($"Player moved right to {x_position}");
			}
		}
	}
}

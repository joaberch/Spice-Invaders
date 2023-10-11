using Model;
using Display;

class Program
{
    static void Main()
    {
        //Instantiating the object
        Config config = new Config();
        config.configurateScreen();
        Player joueur = new Player(3);
        Enemy mechant = new Enemy(0, 0);
        Score score = new Score();

        //assigning the variable (TODO : rename all comments in english and comments) 

        Console.CursorVisible = false;                  //Not displaying the cursor
        ConsoleKeyInfo keyPressed;                      //Will get the user input
        const int NBRENEMY = 10;                        //Choosing the number of enemy per wave
        int nbrframe = 0;                               //Calculate the number of frame
        int wave = 1;                                   //Calculate the number of wave

        mechant.creatingenemy(NBRENEMY);                //Instantiating the number of enemy choosen
        mechant.nbrenemy = NBRENEMY;                    //Getting the number of enemy in the enemy class

        List<Ammo> shooted = new List<Ammo>();          //Collection of bullet shooted
        List<Enemy> enemyalive = new List<Enemy>();     //Collection of enemy alive

        //Instantiating enemy
        for (int i = 0; i <= NBRENEMY; ++i)
        {
            enemyalive.Add(new Enemy(i * 4, 1));
        }

        //Game engine
        while (true)
        {
            Console.Clear();    //Clear Screen
            joueur.show();      //Display Player

            //Displaying the score
            score.DisplayScore();

            //If all enemy are dead we create more enemy
            if (enemyalive.Count <= 0)
            {
                for (int i = 1; i < 10; ++i)
                {
                    enemyalive.Add(new Enemy(i * 4, wave));
                }
                ++wave;
            }

            //Display and move ammo
            foreach (Ammo ammo in shooted)
            {
                ammo.show();
                ammo.move();
            }

            //Kill ammo
            for (int i = 0; i < shooted.Count; ++i)
            {
                if (shooted[i].y <= 1)
                {
                    shooted.Remove(shooted[i]);
                }
            }

            //Display and move alien
            foreach (Enemy alien in enemyalive)
            {
                alien.show();
                if (nbrframe % 1 == 0)
                {
                    alien.move();
                }
                if (alien._x >= Console.WindowWidth - 5 || alien._x <= 0)
                {
                    for(int i = 0; i<enemyalive.Count();++i)
                    {
                        enemyalive[i].moveDown();
                    }
                }
            }

            //Kill dead enemy
            for (int i = 0; i < enemyalive.Count; ++i)
            {
                if (enemyalive[i]._lifePoint <= 0)
                {
                    enemyalive.Remove(enemyalive[i]);
                }
            }

            //Check if an ammo is touching an enemy
            foreach (Ammo ammo in shooted)
            {
                foreach (Enemy alien in enemyalive)
                {
                    if ((alien._y == ammo.y || alien._y - 1 == ammo.y || alien._y + 1 == ammo.y) && (alien._x - 2 == ammo.x || alien._x - 3 == ammo.x || alien._x - 4 == ammo.x))
                    {
                        alien.takeDamage();
                        ammo.hastouched = true;
                        score.AddScore();
                    }
                }
            }

            //Kill ammo if it has touched an enemy
            for(int i = 0; i < shooted.Count(); ++i)
            {
                if (shooted[i].hastouched == true)
                {
                    shooted.Remove(shooted[i]);
                }
            }

            //Check if the player has pressed any button
            if (Console.KeyAvailable)                               //If the user press any touch
            {

                keyPressed = Console.ReadKey(false);
                switch (keyPressed.Key)
                {
                    case ConsoleKey.LeftArrow:                      //If the user press the left arrow key
                        joueur.MovingLeft();
                        break;

                    case ConsoleKey.RightArrow:                     //If the user press the right arrow key
                        joueur.MovingRight();
                        break;

                    case ConsoleKey.Spacebar:                       //If the user press the space bar
                        if(shooted.Count() < 5)                     //Can't shoot if there's more than 5 ammo already on the screen, that way the player can't spam button
                        {
                            //joueur.Shoot();
                            shooted.Add(new Ammo(joueur.x, joueur.y));
                        }
                        break;

                    case ConsoleKey.Escape:                         //If the user press the touch escape
                        Environment.Exit(0);                        //Exit the program
                        break;
                }
            }

            ++nbrframe;             //Incrementing the nuber of frame
            Thread.Sleep(10);       //Making the program wait so that the user have the time to see what happened
        }
    }
}

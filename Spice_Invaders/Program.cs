using Model;
using Display;

class Program
{
    static void Main()
    {

        Config config = new Config();
        config.configurateScreen();
        Player joueur = new Player(3);
        Enemy mechant = new Enemy(0, 0);
        Score score = new Score();

        //Assignation des variables (TODO : rename all comments in english and comments)

        Console.CursorVisible = false;  //Not displaying the cursor
        ConsoleKeyInfo keyPressed;      //Will get the user input
        const int NBRENEMY = 10;
        int nbrframe = 0;

        mechant.creatingenemy(NBRENEMY);
        mechant.nbrenemy = NBRENEMY;

        List<Ammo> shooted = new List<Ammo>(); //Collection of bullet shoot
        List<Enemy> enemyalive = new List<Enemy>();

        //Instanciating enemy
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

            //if all enemy are dead we create more enemy
            if (enemyalive.Count <= 0)
            {
                for (int i = 1; i < 10; ++i)
                {
                    enemyalive.Add(new Enemy(i * 4, 1));
                }
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

            //check if an ammo is touching an enemy
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

            //Check if the player has pressed a button
            if (Console.KeyAvailable)                               //L'utilisateur a pressé une touche
            {

                keyPressed = Console.ReadKey(false);
                switch (keyPressed.Key)
                {
                    case ConsoleKey.LeftArrow:                      //Si l'utilisateur a appuyé sur la flèche de gauche
                        joueur.MovingLeft();
                        break;

                    case ConsoleKey.RightArrow:                     //Si l'utilisateur a appuyé sur la flèche de droite
                        joueur.MovingRight();
                        break;

                    case ConsoleKey.Spacebar:                       //if the player is pressing the spacebar
                        joueur.Shoot();
                        shooted.Add(new Ammo(joueur.x, joueur.y));
                        break;

                    case ConsoleKey.Escape:                         //Si l'utilisateur a appuyé sur exit
                        Environment.Exit(0);                         //Quitter le programme
                        break;
                }
            }

            ++nbrframe;
            Thread.Sleep(10);       //15 is equivalent to 60fps (TODO: check that)
        }
    }
}

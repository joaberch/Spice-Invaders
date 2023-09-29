﻿using Model;
using Display;

class Program
{
    static void Main()
    {
        Config config = new Config();
        config.configurateScreen();
        Player joueur = new Player(3);
        Enemy mechant = new Enemy(0, 0);

        //Assignation des variables (TODO : rename all comments in english)

        Console.CursorVisible = false;  //Not displaying the cursor
        ConsoleKeyInfo keyPressed;      //Will get the user input
        const int NBRENEMY = 10;
        int nbrframe = 0;

        mechant.creatingenemy(NBRENEMY);
        mechant.nbrenemy = NBRENEMY;

        List<Ammo> shooted = new List<Ammo>(); //Collection of bullet shoot
        List<Enemy> enemyalive = new List<Enemy>();

        //Menu

        for (int i = 0; i <= NBRENEMY; ++i)
        {
            enemyalive.Add(new Enemy(i*4, 1));
        }

        //Game engine
        while (true)
        {
            Console.Clear();    //Clear Screen
            joueur.show();      //Display Player

            //Display and move ammo
            foreach (Ammo ammo in shooted)
            {
                ammo.show();
                ammo.move();
            }

            //Display and move alien
            foreach (Enemy alien in enemyalive)
            {
                alien.show();
                if(nbrframe % 1 == 0)
                {
                    alien.move();
                }
            }

            //Kill dead enemy
            for(int i = 0; i<enemyalive.Count;++i)
            {
                if (enemyalive[i]._lifePoint <= 0)
                {
                    enemyalive.Remove(enemyalive[i]);
                }
            }
            
            //check if an ammo is touching an enemy
            foreach (Ammo ammo in shooted)
            {
                foreach(Enemy alien in enemyalive)
                {
                    if((alien._y == ammo.y || alien._y-1==ammo.y||alien._y+1 == ammo.y) && (alien._x-2 == ammo.x || alien._x-3 == ammo.x || alien._x-4==ammo.x))
                    {
                        alien.takeDamage();
                        
                    }
                }
            }

            //if the player has pressed a button
            if (Console.KeyAvailable)                               //L'utilisateur a pressé une touche
            {

                keyPressed = Console.ReadKey(false);
                switch (keyPressed.Key)
                {
                    case ConsoleKey.LeftArrow:                       //Si l'utilisateur a appuyé sur flèche de gauche
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
            Thread.Sleep(25);       //15 is equivalent to 60fps (TODO: check that)
        }
    }
}

using Spice_Invaders;

Vaisseau joueur = new Vaisseau(3);
alien alien = new alien();

//Assignation des variables (TODO : rename all comments in english)

Console.CursorVisible = false;  //Unshowing the cursor
ConsoleKeyInfo keyPressed;      //Will get the user input
const int NBRENEMY = 10;
alien.creatingenemy(NBRENEMY);

List<Ammunition> shooted = new List<Ammunition>(); //Collection of bullet shoot
List<alien> enemyalive = new List<alien>();



//Menu

for(int i=0; i <= NBRENEMY; ++i)
{

}

while (true)     //game engine
{
    Console.Clear();    //Nettoyer l'écran
    joueur.show();      //Afficher le joueur

    foreach(Ammunition ammo in shooted)
    {
        ammo.show();
        ammo.move();
    }
    //foreach()
    

    if (Console.KeyAvailable)                               // L'utilisateur a pressé une touche
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
                shooted.Add(new Ammunition(joueur.x, joueur.y));
                break;

            case ConsoleKey.Escape:                         //Si l'utilisateur a appuyé sur exit
                Environment.Exit(0);                         //Quitter le programme
                break;
        }
    }

    Thread.Sleep(25);       //15 is equivalent to 60fps (TODO: check that)
}
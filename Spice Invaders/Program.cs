using Spice_Invaders;

Vaisseau joueur = new Vaisseau(10);

//Assignation des variables (TODO : rename all comments in english)
Console.CursorVisible = false;
ConsoleKeyInfo keyPressed;      //Préparer la variable pour récupérer la saisie
//TODO : collection ennemi mort
List<Ammunition> shooted = new List<Ammunition>(); 



//Menu

while (true)     //game engine
{
    Console.Clear();    //Nettoyer l'écran
    joueur.show();      //Afficher le joueur

    foreach(Ammunition ammo in shooted)
    {
        ammo.show();
        ammo.move();
    }

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

    Thread.Sleep(50);       //equivalent to 60fps (TODO: check)
}
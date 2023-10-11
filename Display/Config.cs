namespace Display
{
    public class Config
    {
        public const int WINDOW_WIDTH = 150;                        //Constant taking the window width
        public const int WINDOW_HEIGHT = 40;                        //Constant taking the window height

        public void configurateScreen() 
        {
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);     //Define the size of the window of the game
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);     //Make the game fluid
        }
    }
}
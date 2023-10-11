namespace Display
{
    public class Config
    {
        public const int WINDOW_WIDTH = 150;
        public const int WINDOW_HEIGHT = 40;

        public void configurateScreen()
        {
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);
        }
    }
}
﻿namespace Display
{
    public class Config
    {
        const int WINDOW_WIDTH = 150;
        const int WINDOW_HEIGHT = 40;

        public void configurateScreen()
        {
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
        }
    }
}
namespace SnakeGame
{
    using System;

    public static class ConsoleKeyManager
    {
        public static bool IsArrowKey(ConsoleKey keyPressed)
        {
            if (keyPressed == ConsoleKey.LeftArrow
                || keyPressed == ConsoleKey.RightArrow
                || keyPressed == ConsoleKey.UpArrow
                || keyPressed == ConsoleKey.DownArrow)
            {
                return true;
            }

            return false;
        }

        public static bool IsArrowKey(ConsoleKeyInfo keyPressed)
        {
            if (keyPressed.Key == ConsoleKey.LeftArrow
                || keyPressed.Key == ConsoleKey.RightArrow
                || keyPressed.Key == ConsoleKey.UpArrow
                || keyPressed.Key == ConsoleKey.DownArrow)
            {
                return true;
            }

            return false;
        }

        public static bool PauseMenyAllowedKeys(ConsoleKey keyPressed)
        {
            if (keyPressed == ConsoleKey.Escape || IsArrowKey(keyPressed))
            {
                return true;
            }

            return false;
        }

        public static bool IsValidContinueGameKey(ConsoleKeyInfo keyPressed)
        {
            if (keyPressed.KeyChar == 'y' || keyPressed.KeyChar == 'Y')
            {
                return true;
            }

            return false;
        }
    }
}

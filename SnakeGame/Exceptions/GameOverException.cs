namespace SnakeGame.Exceptions
{
    using System;

    public class GameOverException : Exception
    {
        public GameOverException() : base()
        { }

        public GameOverException(string message) : base (message)
        { }
    }
}

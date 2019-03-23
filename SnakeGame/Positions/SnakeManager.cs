namespace SnakeGame.Positions
{
    using SnakeGame.Exceptions;
    using SnakeGame.GlobalConstants;
    using System;
    using System.Linq;

    public static class SnakeManager
    {
        public static Snake Update(Snake snake, Point newDirection, bool ateFood)
        {
            //Take tail coordinates
            var oldHead = snake.Body.Last();

            //Make new head
            Point newHead = new Point(oldHead.Row + newDirection.Row, oldHead.Col + newDirection.Col);

            if (!ateFood)
            {
                snake.Body.Dequeue();
            }

            //Check if is not touching something
            //Print Game Over! message 
            if (newHead.Row <= 1 || newHead.Col < 1
                || newHead.Row >= Console.WindowHeight - 2
                || newHead.Col >= Console.WindowWidth - 1)
            {
                throw new GameOverException(Constants.GameOverMessage);
            }
            //Print tail bite messsage
            if (snake.Body.Any(h => h.Row == newHead.Row && h.Col == newHead.Col)
)
            {
                throw new GameOverException(Constants.TailBitMessage);
            }

            //Return new head's Position
            snake.Body.Enqueue(newHead);

            return snake;
        }
    }
}

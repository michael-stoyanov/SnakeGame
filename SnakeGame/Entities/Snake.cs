namespace SnakeGame
{
    using System.Collections.Generic;

    public class Snake
    {
        public Queue<Point> Body = new Queue<Point>();

        public Snake()
        {
            for (int i = 1; i <= 6; i++)
            {
                this.Body.Enqueue(new Point(2, i));
            }
        }
    }
}

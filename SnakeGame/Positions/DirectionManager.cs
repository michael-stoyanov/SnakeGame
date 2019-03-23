namespace SnakeGame.Positions
{
    using System;

    public static class DirectionManager
    {
        private static Point[] directionsPoints = new Point[]
        {
                new Point(0, 1),  //Right
                new Point(0, -1), //Left
                new Point(-1, 0), //Up
                new Point(1, 0)   //Down
        };

        public static Point GetNextMoveDirection(ConsoleKey arrowKey)
        {
            Point nextDirection = new Point(0, 0);

            if (arrowKey == ConsoleKey.RightArrow)
            {
                nextDirection = directionsPoints[0];
            }
            else if (arrowKey == ConsoleKey.LeftArrow)
            {
                nextDirection = directionsPoints[1];
            }
            else if (arrowKey == ConsoleKey.UpArrow)
            {
                nextDirection = directionsPoints[2];
            }
            else if (arrowKey == ConsoleKey.DownArrow)
            {
                nextDirection = directionsPoints[3];
            }

            return nextDirection;
        }

        public static Point GetNextMoveDirection(ConsoleKeyInfo arrowKey)
        {
            Point nextDirection = new Point(0, 0);

            if (arrowKey.Key == ConsoleKey.RightArrow)
            {
                nextDirection = directionsPoints[0];
            }
            else if (arrowKey.Key == ConsoleKey.LeftArrow)
            {
                nextDirection = directionsPoints[1];
            }
            else if (arrowKey.Key == ConsoleKey.UpArrow)
            {
                nextDirection = directionsPoints[2];
            }
            else if (arrowKey.Key == ConsoleKey.DownArrow)
            {
                nextDirection = directionsPoints[3];
            }

            return nextDirection;
        }
    }
}

namespace SnakeGame.Positions
{
    using SnakeGame.Exceptions;
    using System;
    using System.Linq;

    public static class PositionManager
    {
        private static Random rnd = new Random();

        public static bool CheckIfMoveIsValid(Point oldDirection, Point nextDirection)
        {
            bool isValid = true;

            int[] positionElements = new int[2];
            positionElements[0] = nextDirection.Row + oldDirection.Row;
            positionElements[1] = nextDirection.Col + oldDirection.Col;

            foreach (int element in positionElements)
            {
                if (element != 0)
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public static Point SpawnFood()
        {
            var foodRow = rnd.Next(1, Console.WindowHeight - 3);
            var foodCol = rnd.Next(1, Console.WindowWidth - 2);
            var food = new Point(foodRow, foodCol);

            while (isHittingWall(food))
            {
                foodRow = rnd.Next(1, Console.WindowHeight - 3);
                foodCol = rnd.Next(1, Console.WindowWidth - 2);
                food = new Point(foodRow, foodCol);
            }

            return food;
        }

        public static bool CheckIfSnakeAte(Snake snake, Point food)
        {
            var snakeHead = snake.Body.First();

            if (snakeHead.Row == food.Row && snakeHead.Col == food.Col)
            {
                return true;
            }

            return false;
        }

        private static bool isHittingWall(Point point)
        {
            //Check if is not touching borders
            if (point.Row <= 2 || point.Col < 1
                || point.Row >= Console.WindowHeight - 2
                || point.Col >= Console.WindowWidth - 1)
            {
                return true;
            }

            return false;
        }
    }
}

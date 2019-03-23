namespace SnakeGame.Visualisation
{
    using SnakeGame.GlobalConstants;
    using System.Threading;

    public static class SnakeSpeedManager
    {
        public static void CurrentSpeed(bool snakeAte)
        {
            double speed = Constants.SnakeMovementSpeed;

            if (snakeAte)
            {
                speed -= 0.5d;
            }

            Thread.Sleep((int)speed);
        }
    }
}

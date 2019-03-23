namespace SnakeGame.GlobalConstants
{
    using System;

    public static class Constants
    {
        public static string HighScorePath = "...//...//HighScore.txt";

        public static int SnakeMovementSpeed = 100;

        public static string SnakeBodyElement = "*";
        public static string FoodElement = "@";

        public static string ScreenWidthDashes = new String('-', Console.WindowWidth - 1);

        public static string ScoreLabel = "Score: ";
        public static string PlayerScoreMessage = "Your final score is: {0}";
        public static string CreatorName = "Snake Game by Michael Stoyanov - 2018";

        public static string GameOverMessage = "Game Over!";
        public static string TailBitMessage = "Don't bite your tail!";
        public static string ContinueMessage = "If you want to continue press: 'Y'";

        public static string PauseMenu = "PAUSED!";

        public static int MiddleOfScreenWidth = Console.WindowWidth / 2;
        public static int MiddleOfScreenHeight = Console.WindowHeight / 2;

        public static int RightBorder = Console.WindowWidth - 1;
        public static int BottomBorder = Console.WindowHeight - 2;

    }
}

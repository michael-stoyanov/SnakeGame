namespace SnakeGame
{
    using System;
    using Exceptions;
    using GlobalConstants;
    using Positions;
    using Visualisation;

    public class StartUp
    {
        public static Snake snake = new Snake();
        public static bool ateFood;

        public static void Main()
        {
            PlayGame:

            Console.Title = "Snake Game";
            Console.CursorVisible = false;

            ConsolePrinter.DrawField(HighScoreManager.GetCurrentScore());
            ConsolePrinter.PrintSnake(snake);

            Point oldDirection = DirectionManager.GetNextMoveDirection(ConsoleKey.RightArrow);
            Point newDirection = DirectionManager.GetNextMoveDirection(ConsoleKey.RightArrow);

            Point food = PositionManager.SpawnFood();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo currDirection = Console.ReadKey();

                    if (ConsoleKeyManager.IsArrowKey(currDirection))
                    {
                        newDirection = DirectionManager.GetNextMoveDirection(currDirection);
                    }

                    //Check if "Esc" key is pressed
                    if (currDirection.Key == ConsoleKey.Escape)
                    {
                        ConsolePrinter.PrintPauseMenu();
                        currDirection = Console.ReadKey();

                        while (!ConsoleKeyManager.PauseMenyAllowedKeys(currDirection.Key))
                        {
                            if (currDirection.Key == ConsoleKey.Escape)
                            {
                                goto Print;
                            }

                            currDirection = Console.ReadKey();
                        }
                    }

                    var isValidMove = PositionManager.CheckIfMoveIsValid(oldDirection, newDirection);

                    if (isValidMove)
                    {
                        newDirection = oldDirection.Coordinates();
                    }

                    oldDirection = newDirection.Coordinates();
                }

                ateFood = PositionManager.CheckIfSnakeAte(snake, food);

                try
                {
                    snake = SnakeManager.Update(snake, newDirection, ateFood);
                    food = ateFood ? PositionManager.SpawnFood() : food;
                    HighScoreManager.IncreaseScore(ateFood);
                    goto Print;
                }
                catch (GameOverException goe)
                {
                    ConsolePrinter.PrintGameOverScreen(goe.Message);
                    ConsolePrinter.PrintPlayerScore(HighScoreManager.GetCurrentScore());
                    ConsolePrinter.PrintContinueScreen(Constants.ContinueMessage);

                    goto GameOver;
                }

                Print:

                ConsolePrinter.DrawField(HighScoreManager.GetCurrentScore());
                ConsolePrinter.PrintFood(food);
                ConsolePrinter.PrintSnake(snake);
                SnakeSpeedManager.CurrentSpeed(ateFood);
            }

            GameOver:

            ConsoleKeyInfo playerChoice = Console.ReadKey();

            if (ConsoleKeyManager.IsValidContinueGameKey(playerChoice))
            {
                goto PlayGame;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
namespace SnakeGame.Visualisation
{
    using SnakeGame.GlobalConstants;
    using System;

    public static class ConsolePrinter
    {
        public static void PrintSnake(Snake snake)
        {
            foreach (Point position in snake.Body)
            {
                Console.SetCursorPosition(position.Col, position.Row);
                Console.Write(Constants.SnakeBodyElement);
            }
        }

        public static void PrintFood(Point food)
        {
            Console.SetCursorPosition(food.Col, food.Row);
            Console.Write(Constants.FoodElement);
        }

        public static void PrintGameOverScreen(string exceptionMessage)
        {
            //Print Game Over! in the middle of the screen
            Console.SetCursorPosition(Constants.MiddleOfScreenWidth - (exceptionMessage.Length / 2), Constants.MiddleOfScreenHeight - 2);
            Console.Write(exceptionMessage);
        }

        public static void PrintContinueScreen(string continueMessage)
        {
            //Print continue game message
            Console.SetCursorPosition(Constants.MiddleOfScreenWidth - (continueMessage.Length / 2), Constants.MiddleOfScreenHeight + 1);
            Console.WriteLine(continueMessage);

            //Align cursor for => Press any key to continue . . .
            Console.SetCursorPosition(Constants.MiddleOfScreenWidth - 17, Constants.MiddleOfScreenHeight + 2);
        }

        public static void DrawField(int scores)
        {
            Console.Clear();
            Console.BufferHeight = Console.WindowHeight;

            //Player score label
            Console.SetCursorPosition(1,0);
            Console.Write(Constants.ScoreLabel + scores);
            
            //Draw first row dashes
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(Constants.ScreenWidthDashes);

            //Draw last row dashes
            Console.SetCursorPosition(1, Console.WindowHeight - 3);
            Console.WriteLine(Constants.ScreenWidthDashes);

            var creatorNameOffset = (Console.WindowWidth - 1) - Constants.CreatorName.Length;

            //Write my name at the right bottom side of the screen
            Console.SetCursorPosition(creatorNameOffset, Constants.BottomBorder);
            Console.Write(Constants.CreatorName);

            //Draw frame pipes
            for (int row = 0; row < Constants.BottomBorder; row++)
            {
                Console.SetCursorPosition(0, row);
                Console.Write("|");
                Console.SetCursorPosition(Console.WindowWidth - 1, row);
                Console.Write("|");
            }
        }

        public static void PrintPauseMenu()
        {
            Console.SetCursorPosition(Constants.MiddleOfScreenWidth, Constants.MiddleOfScreenHeight);
            Console.Write(Constants.PauseMenu);
        }

        public static void PrintPlayerScore(int scores)
        {
            var formattedPlayerScores = String.Format(Constants.PlayerScoreMessage, scores);
            Console.SetCursorPosition(Constants.MiddleOfScreenWidth - (formattedPlayerScores.Length / 2), Constants.MiddleOfScreenHeight - 1);
            Console.Write(formattedPlayerScores);
        }
    }
}

namespace SnakeGame.Visualisation
{
    public static class HighScoreManager
    {
        private static int currentScores = 0;

        public static int GetCurrentScore() 
        {
            return currentScores;
        }

        public static void IncreaseScore(bool ateFood)
        {
            currentScores += ateFood ? 100 : 0;
        }


    }
}

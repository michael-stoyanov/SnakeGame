namespace SnakeGame
{
    public class Point
    {
        private int row;
        private int col;

        public Point(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }
        public int Col
        {
            get { return this.col; }
            set { this.col = value; }
        }

        public Point Coordinates()
        {
            return new Point(this.Row, this.Col);
        }
    }
}

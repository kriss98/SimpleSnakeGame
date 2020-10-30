namespace SimpleSnakeGame
{
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down,
    }
    public class Settings
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int Speed { get; set; }

        public int Score { get; set; }

        public int Points { get; set; }

        public bool GameOver { get; set; }

        public Direction Direction { get; set; }

        public Settings()
        {
            this.Width = 16;
            this.Height = 16;
            this.Speed = 20;
            this.Score = 0;
            this.Points = 100;
            this.GameOver = false;
            this.Direction = Direction.Down;
        }
    }
}

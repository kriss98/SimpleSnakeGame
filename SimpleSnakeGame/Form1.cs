using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSnakeGame
{
    public partial class Form1 : Form
    {
        private List<Circle> snake = new List<Circle>();

        private Circle food = new Circle();

        private Settings settings = new Settings();

        public Form1()
        {
            InitializeComponent();

            this.gameTimer.Interval = 1000 / this.settings.Speed;
            this.gameTimer.Tick += updateScreen;
            this.gameTimer.Start();

            this.startGame();
        }

        private void updateScreen(Object sender, EventArgs args)
        {
            if (this.settings.GameOver)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    this.startGame();
                }
            }
            else
            {
                if (Input.KeyPress(Keys.Right) && this.settings.Direction != Direction.Left)
                {
                    this.settings.Direction = Direction.Right;
                }
                else if (Input.KeyPress(Keys.Left) && this.settings.Direction != Direction.Right)
                {
                    this.settings.Direction = Direction.Left;
                }
                else if (Input.KeyPress(Keys.Up) && this.settings.Direction != Direction.Down)
                {
                    this.settings.Direction = Direction.Up;
                }
                else if (Input.KeyPress(Keys.Down) && this.settings.Direction != Direction.Up)
                {
                    this.settings.Direction = Direction.Down;
                }

                this.movePlayer();
            }

            this.pbCanvas.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {

        }

        private void startGame()
        {

        }

        private void movePlayer()
        {
            for (int i = this.snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (this.settings.Direction)
                    {
                        case Direction.Right:
                            this.snake[i].X++;
                            break;
                        case Direction.Left:
                            this.snake[i].X--;
                            break;
                        case Direction.Up:
                            this.snake[i].Y--;
                            break;
                        case Direction.Down:
                            this.snake[i].Y++;
                            break;
                    }

                    var maxXpos = this.pbCanvas.Size.Width / this.settings.Width;
                    var maxYpos = this.pbCanvas.Size.Height / this.settings.Height;

                    if (this.snake[i].X < 0 || this.snake[i].Y < 0 || this.snake[i].X > maxXpos ||
                        this.snake[i].Y > maxYpos)
                    {
                        this.die();
                    }

                    for (int j = 1; j < this.snake.Count; j++)
                    {
                        if (this.snake[i].X == this.snake[j].X && this.snake[i].Y == this.snake[j].Y)
                        {
                            this.die();
                        }
                    }

                    if (this.snake[0].X == this.food.X && this.snake[0].Y == this.food.Y)
                    {
                        this.eat();
                    }
                }
                else
                {
                    this.snake[i].X = this.snake[i - 1].X;
                    this.snake[i].Y = this.snake[i - 1].Y;
                }
            }
        }

        private void generateFood()
        {

        }

        private void eat()
        {

        }

        private void die()
        {

        }
    }
}

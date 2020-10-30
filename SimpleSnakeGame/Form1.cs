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

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {

        }

        private void startGame()
        {

        }

        private void movePlayer()
        {

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

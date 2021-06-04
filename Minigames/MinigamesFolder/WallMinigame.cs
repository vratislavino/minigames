using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigames
{
    public partial class WallMinigame : UserControl, IMinigame
    {
        int points = 0;

        public int Points => points;

        public event Action MinigameEnded;

        public WallMinigame()
        {
            InitializeComponent();
        }

        public void Start()
        {
            
        }


        class Track {
            public bool IsActive;
            public bool IsMirrored;
            public int Height;
            public int Width;
            public int Order;

            private static SolidBrush activeColor = new SolidBrush(Color.LimeGreen);
            private static SolidBrush inactiveColor = new SolidBrush(Color.Plum);

            public Ball ball;
            public List<Wall> walls;

            public Track(int order, int width, int height)
            {
                Order = order;
                Width = width;
                Height = height;
                IsMirrored = order % 2 == 1;
                IsActive = false;

                ball = new Ball(order * height + height / 2, Color.Black);
                // create walls
            }

            public void Draw(Graphics g)
            {
                g.FillRectangle(IsActive ? activeColor : inactiveColor,
                    0, Order * Height, Width, Height);

                g.DrawRectangle(Pens.Black, 0, Order * Height, Width, Height);

                ball.Draw(g);
                walls.ForEach(x => x.Draw(g));
            }
        }

        class Ball {
            public Point position;
            public int size;
            public SolidBrush color;

            public Ball(int y, Color color)
            {
                position = new Point(50, y);
                size = 30;
                this.color = new SolidBrush(color);
            }

            public void Draw(Graphics g)
            {
                g.FillEllipse(color, position.X, position.Y - size / 2, size, size);
            }
        }

        class Wall
        {
            public Point position;
            public Size size;
            public SolidBrush color;

            public Wall(Point position, int size, Color c)
            {
                this.position = position;
                this.color = new SolidBrush(c);
                this.size = new Size(10, size);
            }

            public void Move(int speed)
            {
                position.X -= speed;
            }

            public void Draw(Graphics g)
            {
                g.FillRectangle(color, position.X, position.Y, size.Width, size.Height);
            }
        }

    }
}

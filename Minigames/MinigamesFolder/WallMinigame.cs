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

        List<Track> tracks;
        Timer timer;

        List<Keys> pressedKeys = new List<Keys>();

        public WallMinigame()
        {
            InitializeComponent();
        }

        public void Start()
        {
            this.Focus();
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += OnTick;
            timer.Start();

            tracks = new List<Track>();
            int count = 4;
            int trackHeight = Height / count;

            var walls = new List<Wall>();
            Random r = new Random();

            for (int i = 0; i < 7; i++)
            {
                int rand = r.Next(0, 2);
                Point position = new Point(150 + i * 100, rand * trackHeight / 2);
                int size = trackHeight / 2;
                walls.Add(new Wall(position, size, Color.RosyBrown, rand == 0));
            }


            for(int i = 0; i < count; i++)
            {
                tracks.Add(new Track(i, this.Width, trackHeight, walls));
            }
        }

        private void OnTick(object sender, EventArgs e)
        {
            tracks.ForEach(track => track.walls.ForEach(wall => wall.Move(1)));

            //Console.WriteLine(string.Join(",", pressedKeys));
            if(pressedKeys.Count > 0)
            {
                var key = pressedKeys.First();
                if (key == Keys.W)
                    tracks.ForEach(track => track.Move(-1));
                if (key == Keys.S)
                    tracks.ForEach(track => track.Move(1));
            } else
            {
                tracks.ForEach(track => track.Move(0));
            }
            Refresh();
        }

        private void WallMinigame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tracks.ForEach(track => track.Draw(e.Graphics));
        }

        private void WallMinigame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                if(!pressedKeys.Contains(Keys.W))
                    pressedKeys.Add(Keys.W);
            if (e.KeyCode == Keys.S)
                if (!pressedKeys.Contains(Keys.S))
                    pressedKeys.Add(Keys.S);
        }

        private void WallMinigame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                pressedKeys.Remove(Keys.W);
            if (e.KeyCode == Keys.S)
                pressedKeys.Remove(Keys.S);
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

            public Track(int order, int width, int height, List<Wall> walls)
            {
                Order = order;
                Width = width;
                Height = height;
                IsMirrored = order % 2 == 1;
                IsActive = false;

                ball = new Ball(order * height + height / 2, Color.Black);
                this.walls = walls;
            }

            public void Move(int dir)
            {
                ball.Move(Height / 4 * (IsMirrored ? -dir : dir));
            }

            public void Draw(Graphics g)
            {
                g.FillRectangle(IsActive ? activeColor : inactiveColor,
                    0, Order * Height, Width, Height);

                g.DrawRectangle(Pens.Black, 0, Order * Height, Width, Height);

                ball.Draw(g);
                walls.ForEach(x => x.Draw(g, Order, IsMirrored));
            }
        }

        class Ball {
            public Point position;
            private Point defaultPosition;
            public int size;
            public SolidBrush color;

            public Ball(int y, Color color)
            {
                defaultPosition = new Point(50, y);
                position = new Point(50, y);
                size = 30;
                this.color = new SolidBrush(color);
            }

            public void Move(int dir)
            {
                position = new Point(defaultPosition.X, defaultPosition.Y + dir);
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

            public bool isUpper;

            public Wall(Point position, int size, Color c, bool isUpper)
            {
                this.position = position;
                this.color = new SolidBrush(c);
                this.size = new Size(10, size);
                this.isUpper = isUpper;
            }

            public void Move(int speed)
            {
                position.X -= speed;
            }

            public void Draw(Graphics g, int order, bool isMirrored)
            {
                Point pos = new Point(position.X, position.Y);
                
                if(isMirrored && isUpper)
                {
                    pos.Y += size.Height;
                } 
                if(isMirrored && !isUpper)
                {
                    pos.Y -= size.Height;
                }
                pos.Y += order * 2 * size.Height;

                g.FillRectangle(color, pos.X, pos.Y, size.Width, size.Height);
            }
        }

    }
}

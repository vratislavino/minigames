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
    public partial class LetterMinigame : UserControl, IMinigame
    {
        public event Action MinigameEnded;

        private Timer timer;

        private Keys randomLetter;

        private int initialInterval = 100;
        private int remainingIntervalsToGameOver;

        private int points = 0;
        public int Points => points;

        public LetterMinigame() {
            InitializeComponent();
        }


        public void Start() {
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += OnTimerTick;
            remainingIntervalsToGameOver = initialInterval;
            CreateRandomLetter();
            timer.Start();

            this.Focus();
        }

        private void CreateRandomLetter() {
            randomLetter = (Keys) (new Random().Next(65, 91));
            label1.Text = randomLetter.ToString();
        }

        private void OnTimerTick(object sender, EventArgs e) {
            remainingIntervalsToGameOver--;
            if(remainingIntervalsToGameOver == 0) {
                StopMinigame();
            } else {
                float perc = (float) remainingIntervalsToGameOver / initialInterval;
                pictureBox1.Width = (int) (600 * perc);
            }
        }

        private void LetterMinigame_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == randomLetter) {
                points++;
                pointsLabel.Text = points.ToString();
                if(points == 8) {
                    StopMinigame();
                } else {
                    CreateRandomLetter();
                    initialInterval = (int) (0.9f * initialInterval);
                    remainingIntervalsToGameOver = initialInterval;
                }
            } else {
                StopMinigame();
            }
        }

        private void StopMinigame() {
            timer.Stop();
            MinigameEnded?.Invoke();
        }
    }
}

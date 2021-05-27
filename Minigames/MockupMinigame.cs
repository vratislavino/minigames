using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigames
{
    public partial class MockupMinigame : UserControl, IMinigame
    {
        public event Action MinigameEnded;
        private Timer timer;

        public int Points {
            get {
                return new Random().Next(8);
            }
        }

        public MockupMinigame() {
            InitializeComponent();
        }
        public void Start() {
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += OnTick;
            timer.Start();
        }

        private void OnTick(object sender, EventArgs e) {
            timer.Stop();
            MinigameEnded?.Invoke();
        }
    }
}

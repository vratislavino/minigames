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
    public partial class GameForm : Form
    {
        private Character character1;
        private Character character2;

        private IMinigame currentMinigame = null;

        public GameForm() {
            InitializeComponent();
        }

        public void SetCharacters(Character char1, Character char2) {
            character1 = char1;
            character2 = char2;

            char1UI.Character = character1;
            char2UI.Character = character2;
        }

        public void StartRandomMinigame() {
            Random r = new Random();
            int index = r.Next(0, 1);

            var minigame = GetMinigameByIndex(index);

            currentMinigame = minigame;
            minigame.MinigameEnded += OnMinigameEnded;
            minigamePanel.Controls.Add(minigame as Control);
            minigame.Start();
        }

        private void OnMinigameEnded() {
            int points = currentMinigame.Points;
            character2.Hp -= points * character1.Damage;
            minigamePanel.Controls.Clear();
        }

        private IMinigame GetMinigameByIndex(int index) {
            switch(index) {
                case 0: return new LetterMinigame();
            }

            return new LetterMinigame();
        }

        private void GameForm_Shown(object sender, EventArgs e) {
            StartRandomMinigame();
        }
    }
}

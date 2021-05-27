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
        private Character character1; // player
        private Character character2; // enemy

        private Character offense;
        private Character defense;

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

            if (offense == character2)
                index = -1;

            var minigame = GetMinigameByIndex(index);

            currentMinigame = minigame;
            minigame.MinigameEnded += OnMinigameEnded;
            minigamePanel.Controls.Add(minigame as Control);
            minigame.Start();
        }

        private void OnMinigameEnded() {
            
            int points = currentMinigame.Points;
            Random rand = new Random();

            bool crit = rand.NextDouble() < offense.ChanceToCrit;

            int totalDamage = (int)(points * offense.Damage * (crit ? 1.5 : 1));

            if(rand.NextDouble() > defense.Dexterity) {
                defense.Hp -= totalDamage;
            }

            minigamePanel.Controls.Clear();

            Character winner = CheckForDead();
            if(winner == null) {
                MessageBox.Show("Enterem spustíte nový round!");
                StartRound();
            } else {
                ShowWinScreen(winner);
            }
        }   

        private Character CheckForDead() {
            if (character1.Hp <= 0)
                return character2;
            if (character2.Hp <= 0)
                return character1;
            return null;
        }

        private void ShowWinScreen(Character winner) {
            MessageBox.Show("Vyhrál " + winner.Name);

            this.Close();
        }

        private IMinigame GetMinigameByIndex(int index) {
            switch(index) {
                case -1: return new MockupMinigame();
                case 0: return new LetterMinigame();
            }

            return new LetterMinigame();
        }

        private void GameForm_Shown(object sender, EventArgs e) {
            StartRound();
        }

        private void StartRound() {
            PrepareForAttack();
            StartRandomMinigame();
        }

        private void PrepareForAttack() {
            Random r = new Random();
            int sumSpeed = character1.Speed + character2.Speed;
            var rand = r.Next(sumSpeed);
            if(rand < character1.Speed) {
                offense = character1;
                defense = character2;
            } else {
                offense = character2;
                defense = character1;
            }
        }
    }
}

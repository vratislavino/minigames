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
    public partial class CharSelectForm : Form
    {
        List<Character> characters = new List<Character>() {
            Characters.Eagle,
            Characters.Shadow,
            Characters.Wizard
        };


        public CharSelectForm() {
            InitializeComponent();

            characters.ForEach(ch => AddCharacter(ch));
        }

        public void AddCharacter(Character ch) {
            var ui = new CharacterMinUI();
            ui.Character = ch;
            ui.CharacterClicked += OnCharacterClicked;

            flowLayoutPanel1.Controls.Add(ui);
        }

        private void OnCharacterClicked(Character character) {
            characterUI1.Character = character;
            characterUI2.Character = characters[new Random().Next(characters.Count)];
        }

        private void fightButton_Click(object sender, EventArgs e) {
            // TODO: Přechod do hry + lore!
        }
    }
}

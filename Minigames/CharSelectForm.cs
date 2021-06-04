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
    /*
     
       TODO: LORE!!! 

     */


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
            fightButton.Enabled = true;

            characterUI1.Character = character;
            characterUI2.Character = characters[new Random().Next(characters.Count)];
        }

        private void fightButton_Click(object sender, EventArgs e) {
            //  Přechod do hry



            GameForm form = new GameForm();
            form.SetCharacters(
                (Character)characterUI1.Character.Clone(), 
                (Character)characterUI2.Character.Clone()
                );

            form.FormClosing += (s, evt) => {
                this.Show();
            };
            this.Hide();

            form.Show();
        }
    }
}

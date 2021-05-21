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
    public partial class CharacterGameUI : UserControl, ICharacterUI
    {
        Character character;
        public Character Character {
            get { return character; }
            set {
                character = value;
                if (character != null) {
                    UpdateCharacter();
                    character.HealthChanged += OnHealthChanged;
                }
            }
        }

        public CharacterGameUI() {
            InitializeComponent();
        }
         
        private void OnHealthChanged() {
            hpBar.Current = character.Hp;
        }

        private void UpdateCharacter() {
            nameLabel.Text = character.Name;
            charImage.BackgroundImage = character.Image;
            hpBar.InitValues(0, character.Hp, Color.DarkRed);
            hpBar.Current = character.Hp;
        }
    }
}

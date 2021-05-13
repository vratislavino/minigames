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
    public partial class CharacterMinUI : UserControl, ICharacterUI
    {
        public event Action<Character> CharacterClicked;

        Character character;
        public Character Character {
            get { return character; }
            set {
                character = value;
                UpdateCharacter();
            }
        }

        public CharacterMinUI() {
            InitializeComponent();
        }

        private void UpdateCharacter() {
            BackgroundImage = Character.Image;
            
        }

        private void CharacterMinUI_Click(object sender, EventArgs e) {
            CharacterClicked?.Invoke(Character);
        }
    }
}

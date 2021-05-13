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
    public partial class CharacterUI : UserControl, ICharacterUI
    {
        private Character character;

        public Character Character { 
            get { return character; } 
            set {
                character = value;
                UpdateCharacter();
            } 
        }

        public CharacterUI() {
            InitializeComponent();

            hpBar.InitValues(100, 200, Color.Green);
            hpBar.BarName = "Health";

            damageBar.InitValues(13, 41, Color.Red);
            damageBar.BarName = "Damage";

            dexterityBar.InitValues(0.08, 0.18, Color.Yellow);
            dexterityBar.BarName = "Dexterity";

            chanceToCritBar.InitValues(0, 0.3, Color.DarkRed);
            chanceToCritBar.BarName = "Chance to crit";

            speedBar.InitValues(12, 31, Color.Blue);
            speedBar.BarName = "Speed";
        }

        private void UpdateCharacter() {
            if (character == null)
                return;

            charName.Text = Character.Name;
            charImage.BackgroundImage = Character.Image;
            charDescription.Text = Character.Description;
            hpBar.Current = Character.Hp;
            damageBar.Current = Character.Damage;
            dexterityBar.Current = Character.Dexterity;
            chanceToCritBar.Current = Character.ChanceToCrit;
            speedBar.Current = Character.Speed;
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Minigames
{
    public class Characters
    {
        public static Character Eagle = new Character("images/Eagle.png") {
            Name = "Eagle",
            Description = "Flying creature killing by his huge claws.",
            Lore = "Originated in Lord of the Rings world, came here to fight his mortal enemies",
            Hp = 200,
            Dexterity = 0.15,
            Damage = 13,
            ChanceToCrit = 0.3,
            Speed = 31
        };
        public static Character Shadow = new Character("images/Shadow_2.png") {
            Name = "Shadow",
            Description = "Unknown",
            Lore = "Unknown",
            Hp = 160,
            Dexterity = 0.18,
            Damage = 19,
            ChanceToCrit = 0.14,
            Speed = 12
        };
        public static Character Wizard = new Character("images/Wizard.png") {
            Name = "Wizard",
            Description = "Longbearded guy casting spells",
            Lore = "Merlin's descendant, who stole dragon's heart in his middle age.",
            Hp = 100,
            Dexterity = 0.08,
            Damage = 41,
            ChanceToCrit = 0,
            Speed = 16
        };
    }

    public class Character
    {
        private string name;
        private string description;
        private string lore;
        private int hp;
        private double dexterity;
        private int damage;
        private double chanceToCrit;
        private int speed;
        private Image image;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Lore { get => lore; set => lore = value; }
        public int Hp { get => hp; set => hp = value; }
        public double Dexterity { get => dexterity; set => dexterity = value; }
        public int Damage { get => damage; set => damage = value; }
        public double ChanceToCrit { get => chanceToCrit; set => chanceToCrit = value; }
        public int Speed { get => speed; set => speed = value; }
        public Image Image { get => image; set => image = value; }

        public Character(string imagePath) {
            image = Image.FromFile(imagePath);
        }
    }
}

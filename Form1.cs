using OOPGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPGame
{
    public partial class Form1 : Form
    {
        public static Player hero;
        public static List<Zombie> zombies;
        public Form1()
        {
            InitializeComponent();
            hero = new Player(20, 20, Resources.hero, 80, 80, 100, 5);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(hero.getImage(),hero.getX(),hero.getY(),hero.getWidth(),hero.getHeight());
        }
    }
}

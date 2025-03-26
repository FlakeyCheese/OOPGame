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
        public  Player hero;
        public  List<Zombie> zombies= new List<Zombie>();
        public Form1()
        {
            
            InitializeComponent();
            hero = new Player(20, 20, Resources.hero, 80, 80, 100, 10);
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Zombie tempZombie = new Zombie(this.Width - 100, rnd.Next(10, this.Height - 100), Resources.blob, 40, 40, 20, 15);
                zombies.Add(tempZombie);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(hero.getImage(),hero.getX(),hero.getY(),hero.getWidth(),hero.getHeight());
            bool isNullOrEmpty = zombies?.Any() != true;//empty list??
            if (isNullOrEmpty) { return; }
            else
            {
                foreach (Zombie z in zombies)
                {
                    e.Graphics.DrawImage(z.getImage(), z.getX(), z.getY(), z.getWidth(), z.getHeight());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Zombie z in zombies)
            {
                z.Update(hero.getX(), hero.getY());
                Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch  (e.KeyCode)
            {
                case Keys.A:
                    hero.Update(true, false, false, false);
                    break;
                case Keys.D:
                    hero.Update(false, true, false, false);
                    break;
                case Keys.W:
                    hero.Update(false, false, true, false);
                    break;
                case Keys.S:
                    hero.Update(false, false, false, true);
                    break;
                default:
                    break;
            }
        }
    }
}

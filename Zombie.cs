using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGame
{
    public class Zombie:Player
    {
        public Zombie(int newX, int newY, Image newImage, int imgHeight, int imgWidth, int hitPoints, int newSpeed)
            : base(newX, newY, newImage, imgHeight, imgWidth, hitPoints, newSpeed)
        { }
    public void Update(int heroX, int heroY)
    {
        if (heroX< this.x) { this.x-=5; }
        if (heroY< this.y) { this.y-=5; }
        if (heroX>this.x) { this.x+=5; }
        if (heroY>this.y) {this.y+=5; }

    }

    }
    
}

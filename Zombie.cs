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
        {
        //nothing new to do in this constructor
        }

     public void Animate()
     {
            // call this to give the correct animation for the player
     }
        public void Update(int playerX, int playerY)
    {
        if (playerX< this.x) { this.x-=speed; }
        if (playerY< this.y) { this.y-=speed; }
        if (playerX>this.x) { this.x+=speed; }
        if (playerY>this.y) {this.y+=speed; }

    }

    }
    
}

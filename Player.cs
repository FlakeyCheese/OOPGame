using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGame
{
    public class Player: Obstacle
    {
        protected int hp; //hit points
        protected int speed;//number of pixels to move each turn

        
        public Player(int newX, int newY, Image newImage, int imgHeight, int imgWidth, int hitPoints, int newSpeed)
            : base(newX,newY,newImage,imgHeight, imgWidth) 
        {
            hp = hitPoints;
            speed = newSpeed;

        }
        

        public void Update(bool left, bool right, bool up, bool down)
        {
            if (left) { this.x--; }
            if (right) { this.x++; }
            if (up) { this.y--; }
            if (down) { this.y++; }

        }
    }
}

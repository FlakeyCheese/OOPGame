using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGame
{
    public class Obstacle
    {
       protected int x;//location x
       protected int y;//location y
        protected Rectangle bounds;
        protected int width; //width of the image
       protected int height;//height of the image
        protected Image image; //the image

       public Obstacle(int newX, int newY, Image newImage, int imgHeight, int imgWidth)
        {
            this.x = newX;
            this.y = newY;
            this.image = newImage;
            this.width = imgWidth;
            this.height = imgHeight;
            bounds = new Rectangle(x, y, width, height);
        }
        public Rectangle getBounds()
        {return bounds;}
        public Image getImage()
        {return image;}
        public int getX()
        { return x; }
        public int getY()
        { return y; }
        public int getWidth()
        { return width; }
        public int getHeight()
        { return height; }
    }
}

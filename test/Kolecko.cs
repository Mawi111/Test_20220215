using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Kolecko
    {
        public int Velikost { get; set; }
        public Color Barva1 { get; set; }
        public Color Barva2 { get; set; }
        public Color Barva3 { get; set; }
        public Color Barva4 { get; set; }
        public Color Barva5 { get; set; }

        public Point Lokace { get; set; }

        public Kolecko(int velikost, Color barva1, Color barva2, Color barva3, Color barva4, Color barva5, Point lokace)
        {
            Velikost = velikost;
            Barva1 = barva1;
            Barva2 = barva2;
            Barva3 = barva3;
            Barva4 = barva4;
            Barva5 = barva5;
            Lokace = lokace;
        }
        public void Draw(Graphics graphics)
        {
            Pen pen1 = new Pen(Barva1); 
            Pen pen2 = new Pen(Barva2);
            Pen pen3 = new Pen(Barva3);
            Pen pen4 = new Pen(Barva4);
            Pen pen5 = new Pen(Barva5);
            graphics.DrawEllipse(pen1, Lokace.X - (Velikost / 1.5F) * 1.9F, Lokace.Y, Velikost, Velikost);
            graphics.DrawEllipse(pen2, Lokace.X - (Velikost / 1.9F) * 0F, Lokace.Y, Velikost, Velikost);
            graphics.DrawEllipse(pen3, Lokace.X + (Velikost / 1.5F) * 1.9F, Lokace.Y, Velikost, Velikost);
            graphics.DrawEllipse(pen4, Lokace.X - (Velikost / 3) * 1.9F, Lokace.Y + (Velikost / 1.5F) * 0.8F, Velikost, Velikost);
            graphics.DrawEllipse(pen5, Lokace.X + (Velikost / 3) * 1.9F, Lokace.Y + (Velikost / 1.5F) * 0.8F, Velikost, Velikost);


        }
    }
}

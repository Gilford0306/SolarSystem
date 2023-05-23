using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float angelmerc = 0, mecr_velosity = 4;
        float angelven = 0, ven_velosity = 1.6F;
        float angelearth = 0, earth_velosity = 1;
        float angelmars = 0, mars_velosity = 0.53F;
        float angeljup = 0, jup_velosity = 0.03F;
        float angelsat = 0, sat_velosity = 0.03F;
        float angelur = 0, ur_velosity = 0.011F;
        float angelnep = 0, nep_velosity = 0.006F;


        int px = 500, py = 500, dst = 50;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TranslateTransform(px, py, MatrixOrder.Append);
            g.DrawEllipse(Pens.White, -140, -150, 300, 300);
            g.ResetTransform();



            //g.FillEllipse(Brushes.Yellow, px-6, py-10, 25, 25);

            Image Sun = Properties.Resources.sun;
            e.Graphics.DrawImage(Sun, px - 4, py - 9, 25, 25);
            Image Mercyri = Properties.Resources.Mercyri;
            int x = distanseX(20, angelmerc);
            int y = distanseY(20, angelmerc);
            e.Graphics.DrawImage(Mercyri, (int)x, (int)y, 10, 10);

            Image Ven = Properties.Resources.Ven;
            x = r_distanseX(40, angelven);
            y = r_distanseY(40, angelven);
            //g.FillEllipse(Brushes.Orange, (int)x, (int)y, 10, 10);
            e.Graphics.DrawImage(Ven, (int)x, (int)y, 10, 10);

            Image Earht = Properties.Resources.earth;
            x = distanseX(80, angelearth);
            y = distanseY(80, angelearth);
            //g.FillEllipse(Brushes.Aqua, (int)x, (int)y, 10, 10);

            e.Graphics.DrawImage(Earht, (int)x, (int)y, 10, 10);

            //g.DrawEllipse(Pens.White, (int)x - 10, (int)y - 10, 30, 30);
            int x1 = (int)(x + 15 * Math.Sin(angelearth * Math.PI));
            int y1 = (int)(y + 15 * Math.Cos(angelearth * Math.PI));
            g.FillEllipse(Brushes.Wheat, (int)x1, (int)y1, 5, 5);

            Image Mars = Properties.Resources.mars;
            x = distanseX(120, angelmars);
            y = distanseY(120, angelmars);
            //g.FillEllipse(Brushes.Red, (int)x, (int)y, 10, 10);
            e.Graphics.DrawImage(Mars, (int)x, (int)y, 10, 10);
            x1 = (int)(x + 15 * Math.Sin(angelmars * Math.PI+1f));
            y1 = (int)(y + 15 * Math.Cos(angelmars * Math.PI + 1F));
            int x2 = (int)(x + 20 * Math.Sin(angelmars * Math.PI));
            int y2 = (int)(y + 20 * Math.Cos(angelmars * Math.PI));
            g.FillEllipse(Brushes.Wheat, (int)x1, (int)y1, 5, 5);
            g.FillEllipse(Brushes.Wheat, (int)x2, (int)y2, 5, 5);

            x = distanseX(200, angeljup);
            y = distanseY(200, angeljup);
            Image JUPITER = Properties.Resources.mars;
            //g.FillEllipse(Brushes.Brown, (int)x, (int)y, 18, 18);
            e.Graphics.DrawImage(JUPITER, (int)x, (int)y, 18, 18);
            x1 = (int)(x + 35 * Math.Sin(angelmars * Math.PI + 2F));
            y1 = (int)(y + 35 * Math.Cos(angelmars * Math.PI+2F));
            x2 = (int)(x + 20 * Math.Sin(angelmars * Math.PI));
            y2 = (int)(y + 20 * Math.Cos(angelmars * Math.PI));
            g.FillEllipse(Brushes.Wheat, (int)x1, (int)y1, 8, 8);
            g.FillEllipse(Brushes.Wheat, (int)x2, (int)y2, 5, 5);
            x1 = (int)(x + 25 * Math.Sin(angelmars * Math.PI));
            y1 = (int)(y + 25 * Math.Cos(angelmars * Math.PI));
            x2 = (int)(x + 30 * Math.Sin(angelmars * Math.PI- 2f));
            y2 = (int)(y + 30 * Math.Cos(angelmars * Math.PI - 2f));
            g.FillEllipse(Brushes.Wheat, (int)x1, (int)y1, 4, 4);
            g.FillEllipse(Brushes.Wheat, (int)x2, (int)y2, 7, 7);


            Image Sat = Properties.Resources.sat;
            x = distanseX(280, angelsat);
            y = distanseY(280, angelsat);
            //g.FillEllipse(Brushes.Purple, (int)x, (int)y, 15, 15);
            e.Graphics.DrawImage(Sat, (int)x, (int)y, 15, 15);
            x1 = (int)(x + 35 * Math.Sin(angelmars * Math.PI + 3F));
            y1 = (int)(y + 35 * Math.Cos(angelmars * Math.PI + 3F));
            x2 = (int)(x + 20 * Math.Sin(angelmars * Math.PI));
            y2 = (int)(y + 20 * Math.Cos(angelmars * Math.PI));
            g.FillEllipse(Brushes.Wheat, (int)x1, (int)y1, 8, 8);
            g.FillEllipse(Brushes.Wheat, (int)x2, (int)y2, 5, 5);
            x1 = (int)(x + 25 * Math.Sin(angelmars * Math.PI));
            y1 = (int)(y + 25 * Math.Cos(angelmars * Math.PI));
            x2 = (int)(x + 30 * Math.Sin(angelmars * Math.PI - 1f));
            y2 = (int)(y + 30 * Math.Cos(angelmars * Math.PI - 1f));
            g.FillEllipse(Brushes.Wheat, (int)x1, (int)y1, 4, 4);
            g.FillEllipse(Brushes.Wheat, (int)x2, (int)y2, 7, 7);

            Image uranus = Properties.Resources.uranus;
            x = r_distanseX(350, angelur);
            y = r_distanseY(350, angelur);
            //g.FillEllipse(Brushes.Blue, (int)x, (int)y, 13, 13);
            e.Graphics.DrawImage(uranus, (int)x, (int)y, 13, 13);
            x1 = (int)(x + 35 * Math.Sin(angelmars * Math.PI + 2F));
            y1 = (int)(y + 35 * Math.Cos(angelmars * Math.PI + 2F));
            x2 = (int)(x + 20 * Math.Sin(angelmars * Math.PI));
            y2 = (int)(y + 20 * Math.Cos(angelmars * Math.PI));
            g.FillEllipse(Brushes.Wheat, (int)x1, (int)y1, 8, 8);
            g.FillEllipse(Brushes.Wheat, (int)x2, (int)y2, 5, 5);
            x1 = (int)(x + 25 * Math.Sin(angelmars * Math.PI));
            y1 = (int)(y + 25 * Math.Cos(angelmars * Math.PI));
            x2 = (int)(x + 30 * Math.Sin(angelmars * Math.PI - 3));
            y2 = (int)(y + 30 * Math.Cos(angelmars * Math.PI - 3f));
            g.FillEllipse(Brushes.Wheat, (int)x1, (int)y1, 4, 4);
            g.FillEllipse(Brushes.Wheat, (int)x2, (int)y2, 5, 5);

            Image nep = Properties.Resources.nep;
            x = r_distanseX(430, angelnep);
            y = r_distanseY(430, angelnep);
            g.FillEllipse(Brushes.Purple, (int)x, (int)y, 15, 15);
            e.Graphics.DrawImage(nep, (int)x, (int)y, 15, 15);
            x1 = (int)(x + 35 * Math.Sin(angelmars * Math.PI + 2F));
            y1 = (int)(y + 35 * Math.Cos(angelmars * Math.PI + 2F));
            x2 = (int)(x + 20 * Math.Sin(angelmars * Math.PI));
            y2 = (int)(y + 20 * Math.Cos(angelmars * Math.PI));
            g.FillEllipse(Brushes.Wheat, (int)x1, (int)y1, 8, 8);
            g.FillEllipse(Brushes.Wheat, (int)x2, (int)y2, 5, 5);

            angelmerc -= mecr_velosity;
            angelven -= ven_velosity;
            angelearth -= earth_velosity;
            angelmars -= mars_velosity;
            angeljup -= jup_velosity;
            angelsat -= sat_velosity;
            angelur -= ur_velosity;
            angelnep += nep_velosity;



        }
        int distanseX(int dst, float angel)
        {
            return (int)(px + dst * Math.Sin(angel - Math.PI / 182.5f));
        }
        int distanseY(int dst , float angel)
        {
            return (int)(py + dst * Math.Cos(angel - Math.PI / 182.5f));
        }

        int r_distanseX(int dst, float angel)
        {
            return (int)(px + dst * Math.Sin((angel * -1) - Math.PI / 182.5f));
        }
        int r_distanseY(int dst, float angel)
        {
            return (int)(py + dst * Math.Cos((angel * -1) - Math.PI / 182.5f));
        }
    }
}

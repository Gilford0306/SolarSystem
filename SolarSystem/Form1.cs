using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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


        int px = 350, py = 300, dst = 50;

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
            g.DrawEllipse(Pens.White, -95, -100, 200, 200);
            g.ResetTransform();



            //g.FillEllipse(Brushes.Yellow, px-6, py-10, 25, 25);
            Image Sun= Image.FromFile(@"D:\Projects\5.WinForms\SolarSystem\SolarSystem\sun.png");
            e.Graphics.DrawImage(Sun, px - 6, py - 10, 25, 25);

            Image Mercyri = Image.FromFile(@"D:\Projects\5.WinForms\SolarSystem\SolarSystem\Mercyri.png");      
            int x = distanseX(20, angelmerc);
            int y = distanseY(20, angelmerc);
            e.Graphics.DrawImage(Mercyri, (int)x, (int)y, 10, 10);

            Image Ven= Image.FromFile(@"D:\Projects\5.WinForms\SolarSystem\SolarSystem\Ven.png");
            x = r_distanseX(40, angelven) ;
            y = r_distanseY(40, angelven) ;
            //g.FillEllipse(Brushes.Orange, (int)x, (int)y, 10, 10);
            e.Graphics.DrawImage(Ven, (int)x, (int)y, 10, 10);

            Image Earht = Image.FromFile(@"D:\Projects\5.WinForms\SolarSystem\SolarSystem\earth.png");
            x = distanseX(60, angelearth);
            y = distanseY(60, angelearth);
            //g.FillEllipse(Brushes.Aqua, (int)x, (int)y, 10, 10);
            e.Graphics.DrawImage(Earht, (int)x, (int)y, 10, 10);

            Image Mars = Image.FromFile(@"D:\Projects\5.WinForms\SolarSystem\SolarSystem\mars.png");
            x = distanseX(80, angelmars);
            y = distanseY(80, angelmars);
            //g.FillEllipse(Brushes.Red, (int)x, (int)y, 10, 10);
            e.Graphics.DrawImage(Mars, (int)x, (int)y, 10, 10);

            x = distanseX(120, angeljup);
            y = distanseY(120, angeljup);
            Image JUPITER = Image.FromFile(@"D:\Projects\5.WinForms\SolarSystem\SolarSystem\JUPITER.png");
            //g.FillEllipse(Brushes.Brown, (int)x, (int)y, 18, 18);
            e.Graphics.DrawImage(JUPITER, (int)x, (int)y, 18, 18);

            Image Sat = Image.FromFile(@"D:\Projects\5.WinForms\SolarSystem\SolarSystem\sat.png");
            x = distanseX(150, angelsat);
            y = distanseY(150, angelsat);
            //g.FillEllipse(Brushes.Purple, (int)x, (int)y, 15, 15);
            e.Graphics.DrawImage(Sat, (int)x, (int)y, 15, 15);

            Image uranus = Image.FromFile(@"D:\Projects\5.WinForms\SolarSystem\SolarSystem\uranus.png");
            x = r_distanseX(180, angelur);
            y = r_distanseY(180, angelur);
            //g.FillEllipse(Brushes.Blue, (int)x, (int)y, 13, 13);
            e.Graphics.DrawImage(uranus, (int)x, (int)y, 13, 13);

            Image nep = Image.FromFile(@"D:\Projects\5.WinForms\SolarSystem\SolarSystem\nep.png");
            x = r_distanseX(210, angelnep);
            y = r_distanseY(210, angelnep);
            g.FillEllipse(Brushes.Purple, (int)x, (int)y, 15, 15);
            e.Graphics.DrawImage(nep, (int)x, (int)y, 15, 15);

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

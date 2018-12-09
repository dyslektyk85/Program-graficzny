using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grafika1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (tlo==2)
            {
                Graphics g = this.CreateGraphics();
                Font f = new Font("Times New Roman", 10, FontStyle.Bold);

                Brush b = Brushes.DarkBlue;
                g.DrawString("Witaj w kreatorze kartki swiatecznej, ktory pozwoli ci stworzyc wlasna kartke z gotowych szablonow.", f, b, 10, 100);
                g.DrawString("Tworzenie kartki muszisz rozpoczac od wyboru tla. Zmiana tla usuwa elementow.", f, b, 10, 130);


            }
        }
        public int b = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            b = 0;
            Graphics g = this.CreateGraphics();
            Pen p;
            if (tlo == 0)
            {
                p = new Pen(Color.DarkBlue, 40);
                g.DrawEllipse(p, 295, 195, 40, 40);
                p = new Pen(Color.DarkBlue, 60);
                g.DrawEllipse(p, 285, 280, 60, 60);

                p = new Pen(Color.DarkBlue, 80);
                g.DrawEllipse(p, 275, 400, 80, 80);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawEllipse(p, 315, 480, 2, 2);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawEllipse(p, 315, 440, 2, 2);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawEllipse(p, 315, 400, 2, 2);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawEllipse(p, 315, 280, 2, 2);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawEllipse(p, 315, 310, 2, 2);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawEllipse(p, 315, 340, 2, 2);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawEllipse(p, 300, 200, 2, 2);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawEllipse(p, 330, 200, 2, 2);

                p = new Pen(Color.DarkBlue, 40);
                g.DrawRectangle(p, 305, 120, 20, 35);

                p = new Pen(Color.DarkBlue, 5);
                g.DrawLine(p, 315, 215, 345, 215);


                p = new Pen(Color.DarkBlue, 2);
                g.DrawLine(p, 330, 230, 330, 235);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawLine(p, 325, 230, 325, 235);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawLine(p, 320, 230, 320, 235);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawLine(p, 315, 230, 315, 235);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawLine(p, 310, 230, 310, 235);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawLine(p, 305, 230, 305, 235);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawLine(p, 300, 230, 300, 235);

                p = new Pen(Color.DarkBlue, 2);
                g.DrawLine(p, 335, 230, 335, 235);




                p = new Pen(Color.DarkBlue, 4);
                g.DrawLine(p, 255, 310, 130, 250);
                p = new Pen(Color.DarkBlue, 4);
                g.DrawLine(p, 130, 250, 115, 230);
                p = new Pen(Color.DarkBlue, 4);
                g.DrawLine(p, 130, 250, 105, 238);
                p = new Pen(Color.DarkBlue, 4);
                g.DrawLine(p, 130, 250, 105, 250);


                p = new Pen(Color.DarkBlue, 4);
                g.DrawLine(p, 375, 310, 500, 250);
                p = new Pen(Color.DarkBlue, 4);
                g.DrawLine(p, 500, 250, 515, 230);
                p = new Pen(Color.DarkBlue, 4);
                g.DrawLine(p, 500, 250, 525, 238);
                p = new Pen(Color.DarkBlue, 4);
                g.DrawLine(p, 500, 250, 525, 250);
            }
            if (tlo == 1)
            {
                p = new Pen(Color.DarkRed, 40);
                g.DrawEllipse(p, 295, 195, 40, 40);
                p = new Pen(Color.DarkRed, 60);
                g.DrawEllipse(p, 285, 280, 60, 60);

                p = new Pen(Color.DarkRed, 80);
                g.DrawEllipse(p, 275, 400, 80, 80);

                p = new Pen(Color.DarkRed, 2);
                g.DrawEllipse(p, 315, 480, 2, 2);

                p = new Pen(Color.DarkRed, 2);
                g.DrawEllipse(p, 315, 440, 2, 2);

                p = new Pen(Color.DarkRed, 2);
                g.DrawEllipse(p, 315, 400, 2, 2);

                p = new Pen(Color.DarkRed, 2);
                g.DrawEllipse(p, 315, 280, 2, 2);

                p = new Pen(Color.DarkRed, 2);
                g.DrawEllipse(p, 315, 310, 2, 2);

                p = new Pen(Color.DarkRed, 2);
                g.DrawEllipse(p, 315, 340, 2, 2);

                p = new Pen(Color.DarkRed, 2);
                g.DrawEllipse(p, 300, 200, 2, 2);

                p = new Pen(Color.DarkRed, 2);
                g.DrawEllipse(p, 330, 200, 2, 2);

                p = new Pen(Color.DarkRed, 40);
                g.DrawRectangle(p, 305, 120, 20, 35);

                p = new Pen(Color.DarkRed, 5);
                g.DrawLine(p, 315, 215, 345, 215);


                p = new Pen(Color.DarkRed, 2);
                g.DrawLine(p, 330, 230, 330, 235);

                p = new Pen(Color.DarkRed, 2);
                g.DrawLine(p, 325, 230, 325, 235);

                p = new Pen(Color.DarkRed, 2);
                g.DrawLine(p, 320, 230, 320, 235);

                p = new Pen(Color.DarkRed, 2);
                g.DrawLine(p, 315, 230, 315, 235);

                p = new Pen(Color.DarkRed, 2);
                g.DrawLine(p, 310, 230, 310, 235);

                p = new Pen(Color.DarkRed, 2);
                g.DrawLine(p, 305, 230, 305, 235);

                p = new Pen(Color.DarkRed, 2);
                g.DrawLine(p, 300, 230, 300, 235);

                p = new Pen(Color.DarkRed, 2);
                g.DrawLine(p, 335, 230, 335, 235);




                p = new Pen(Color.DarkRed, 4);
                g.DrawLine(p, 255, 310, 130, 250);
                p = new Pen(Color.DarkRed, 4);
                g.DrawLine(p, 130, 250, 115, 230);
                p = new Pen(Color.DarkRed, 4);
                g.DrawLine(p, 130, 250, 105, 238);
                p = new Pen(Color.DarkRed, 4);
                g.DrawLine(p, 130, 250, 105, 250);


                p = new Pen(Color.DarkRed, 4);
                g.DrawLine(p, 375, 310, 500, 250);
                p = new Pen(Color.DarkRed, 4);
                g.DrawLine(p, 500, 250, 515, 230);
                p = new Pen(Color.DarkRed, 4);
                g.DrawLine(p, 500, 250, 525, 238);
                p = new Pen(Color.DarkRed, 4);
                g.DrawLine(p, 500, 250, 525, 250);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            b = 1;

            Pen p;
            if (tlo == 0 || tlo == 1)
            {
                p = new Pen(Color.White, 40);
                g.DrawEllipse(p, 295, 195, 40, 40);
                p = new Pen(Color.White, 60);
                g.DrawEllipse(p, 285, 280, 60, 60);

                p = new Pen(Color.White, 80);
                g.DrawEllipse(p, 275, 400, 80, 80);

                p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, 315, 480, 2, 2);

                p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, 315, 440, 2, 2);

                p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, 315, 400, 2, 2);

                p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, 315, 280, 2, 2);

                p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, 315, 310, 2, 2);

                p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, 315, 340, 2, 2);

                p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, 300, 200, 2, 2);

                p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, 330, 200, 2, 2);

                p = new Pen(Color.Black, 40);
                g.DrawRectangle(p, 305, 120, 20, 35);

                p = new Pen(Color.Orange, 5);
                g.DrawLine(p, 315, 215, 345, 215);


                p = new Pen(Color.Black, 2);
                g.DrawLine(p, 330, 230, 330, 235);

                p = new Pen(Color.Black, 2);
                g.DrawLine(p, 325, 230, 325, 235);

                p = new Pen(Color.Black, 2);
                g.DrawLine(p, 320, 230, 320, 235);

                p = new Pen(Color.Black, 2);
                g.DrawLine(p, 315, 230, 315, 235);

                p = new Pen(Color.Black, 2);
                g.DrawLine(p, 310, 230, 310, 235);

                p = new Pen(Color.Black, 2);
                g.DrawLine(p, 305, 230, 305, 235);

                p = new Pen(Color.Black, 2);
                g.DrawLine(p, 300, 230, 300, 235);

                p = new Pen(Color.Black, 2);
                g.DrawLine(p, 335, 230, 335, 235);




                p = new Pen(Color.Brown, 4);
                g.DrawLine(p, 255, 310, 130, 250);
                p = new Pen(Color.Brown, 4);
                g.DrawLine(p, 130, 250, 115, 230);
                p = new Pen(Color.Brown, 4);
                g.DrawLine(p, 130, 250, 105, 238);
                p = new Pen(Color.Brown, 4);
                g.DrawLine(p, 130, 250, 105, 250);


                p = new Pen(Color.Brown, 4);
                g.DrawLine(p, 375, 310, 500, 250);
                p = new Pen(Color.Brown, 4);
                g.DrawLine(p, 500, 250, 515, 230);
                p = new Pen(Color.Brown, 4);
                g.DrawLine(p, 500, 250, 525, 238);
                p = new Pen(Color.Brown, 4);
                g.DrawLine(p, 500, 250, 525, 250);
            }
        }
        public int tlo =2;
        public void button3_Click(object sender, EventArgs e)
        { if (tlo != 0) { 
             tlo=0;
            Graphics g = this.CreateGraphics();
            Pen p;
                if (tlo == 0)
                {
                    p = new Pen(Color.DarkBlue, 1000);
                    g.DrawRectangle(p, 0, 0, 1000, 1000);
                }
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (tlo != 1)
            {
                tlo = 1;
                Graphics g = this.CreateGraphics();
                Pen p;
                if (tlo == 1)
                {
                    p = new Pen(Color.DarkRed, 1000);
                    g.DrawRectangle(p, 0, 0, 1000, 1000);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p;
            if (tlo == 0)
            {
                p = new Pen(Color.DarkBlue, 60);
                g.DrawRectangle(p, 0, 30, 1000, 40);
                Font f = new Font("Times New Roman", 21, FontStyle.Bold);

                Brush b = Brushes.DarkRed;
                g.DrawString("Wesolych Swiat", f, b, 220, 50);
            }
            if (tlo == 1)
            {
                p = new Pen(Color.DarkRed, 60);
                g.DrawRectangle(p, 0, 30, 1000, 40);
                Font f = new Font("Times New Roman", 21, FontStyle.Bold);

                Brush b = Brushes.DarkBlue;
                g.DrawString("Wesolych Swiat", f, b, 220, 50);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p;
            if (tlo == 0)
            {
                p = new Pen(Color.DarkBlue, 60);
                g.DrawRectangle(p, 0, 30, 1000, 40);
                Font f = new Font("Times New Roman", 21, FontStyle.Bold);

                Brush b = Brushes.DarkRed;
                g.DrawString("Wesolego Jajka", f, b, 220, 50);
            }
            if (tlo == 1)
            {
                p = new Pen(Color.DarkRed, 60);
                g.DrawRectangle(p, 0, 30, 1000, 40);
                Font f = new Font("Times New Roman", 21, FontStyle.Bold);

                Brush b = Brushes.DarkBlue;
                g.DrawString("Wesolego Jajka", f, b, 220, 50);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p;
            if (tlo == 0)
            {
                p = new Pen(Color.DarkBlue, 60);
                g.DrawRectangle(p, 0, 30, 1000, 40);
            }
            if(tlo==1)
            {
                p = new Pen(Color.DarkRed, 60);
                g.DrawRectangle(p, 0, 30, 1000, 40);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tlo = 2;
            Graphics g = this.CreateGraphics();
            Pen p;
            p = new Pen(Color.GhostWhite, 1000);
            g.DrawRectangle(p, 0, 0, 1000, 1000);
            Font f = new Font("Times New Roman", 10, FontStyle.Bold);

            Brush b = Brushes.DarkBlue;
            g.DrawString("Witaj w kreatorze kartki swiatecznej, ktory pozwoli ci stworzyc wlasna kartke z gotowych szablonow.", f, b, 10, 100);
            g.DrawString("Tworzenie kartki muszisz rozpoczac od wyboru tla.Zmiana tla usuwa reszte elementow.", f, b, 10, 130);

        }
    }
}
    


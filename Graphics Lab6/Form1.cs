using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graphics_Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush myNos = new SolidBrush(Color.Red);
            SolidBrush myBody = new SolidBrush(Color.Blue);
            SolidBrush myCabin = new SolidBrush(Color.DeepSkyBlue);
            SolidBrush myWindow = new SolidBrush(Color.White);
            SolidBrush myPipe1 = new SolidBrush(Color.Chocolate);
            SolidBrush myPipe2 = new SolidBrush(Color.Brown);
            SolidBrush myWheel1 = new SolidBrush(Color.Black);
            SolidBrush myWheel2 = new SolidBrush(Color.Gray);
            SolidBrush myRailWay = new SolidBrush(Color.Silver);
            SolidBrush myCloud = new SolidBrush(Color.LightGray);
            Pen p = new Pen(Color.Black, 1);
            g.FillRectangle(myRailWay, 0, 450, 980, 20);
            g.FillRectangle(myBody, 330, 300, 280, 120);
            g.DrawRectangle(p, 330, 300, 280, 120);
            for (int y = 350; y <= 610; y += 90)
            {
                g.FillEllipse(myWheel1, y, 390, 60, 60);
                g.FillEllipse(myWheel2, y + 20, 410, 20, 20);
                g.DrawEllipse(p, y, 390, 60, 60);
                g.DrawEllipse(p, y + 20, 410, 20, 20);
            }
            g.FillRectangle(myCabin, 470, 225, 140, 75);
            g.DrawRectangle(p, 470, 225, 140, 75);
            g.FillEllipse(myNos, 450, 210, 180, 25);
            g.DrawEllipse(p, 450, 210, 180, 25);
            g.FillRectangle(myWindow, 500, 260, 80, 40);
            g.FillRectangle(myPipe1, 330, 260, 20, 40);
            g.FillRectangle(myPipe1, 370, 210, 40, 90);
            g.DrawRectangle(p, 330, 260, 20, 40);
            g.DrawRectangle(p, 370, 210, 40, 90);
            g.FillEllipse(myPipe2, 330, 255, 20, 10);
            g.FillEllipse(myPipe2, 370, 200, 40, 20);
            g.DrawEllipse(p, 330, 255, 20, 10);
            g.DrawEllipse(p, 370, 200, 40, 20);
            g.FillPie(myNos, 290, 300, 80, 120, 90, 180);
            g.DrawRectangle(p, 0, 450, 980, 20);
            g.DrawRectangle(p, 500, 260, 80, 40);
            g.DrawPie(p, 290, 300, 80, 120, 90, 180);
            g.FillEllipse(myCloud,400,100,60,60);
            g.FillEllipse(myCloud, 380, 100, 40, 40);
            g.FillEllipse(myCloud, 380, 120, 40, 40);
            g.FillEllipse(myCloud, 400, 80, 40, 40);
            g.FillEllipse(myCloud, 420, 80, 40, 40);
            g.FillEllipse(myCloud, 400, 140, 40, 40);
            g.FillEllipse(myCloud, 510, 30, 30, 30);
            g.FillEllipse(myCloud, 500, 40, 30, 30);
            g.FillEllipse(myCloud, 510, 40, 60, 60);
            g.FillEllipse(myCloud, 530, 20, 40, 40);
            g.FillEllipse(myCloud, 550, 40, 30, 30);
            g.FillEllipse(myCloud, 550, 20, 30, 30);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace График
{
    public partial class Form1 : Form
    {
        int i = 0;
        Pen redPen = new Pen(Color.Red, 5);            
        Pen bluePen = new Pen(Color.Blue, 5);
        Pen yellowPen = new Pen(Color.Yellow, 5);
        Pen blackPen = new Pen(Color.Black, 5);
         bool heigth = false;
         bool weidth = false;
        int x = 100;
        int y = 100;
        private Point startPoint;
      


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(redPen, 40, 40, 100, 140);         
            g.DrawRectangle(bluePen, 40, 40, 90, 130);      
            g.DrawRectangle(yellowPen, 40, 40, 80, 120);
            g.DrawRectangle(blackPen, 200, 101, 240, 340);
            g.DrawRectangle(bluePen, 100, 10, 100, 10);





            g.Dispose();
        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(redPen, 200, 101, 240, 340);
            g.Dispose();

        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(yellowPen, 200, 101, 240, 340);
            g.DrawEllipse(blackPen, 40, 40, 100, 140);
            g.DrawEllipse(redPen, 40, 40, 90, 130);
            g.DrawEllipse(redPen, 40, 40, 80, 120);

            g.Dispose();
        }

        private void шестиугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point[] point = { new Point(20, 100), new Point(50, 150), new Point(145, 70) , new Point(220, 220), new Point(100, 200), new Point(90, 170) };
            Graphics g = this.CreateGraphics();
            g.DrawPolygon(redPen, point);
            g.Dispose();


        }

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Point[] point = { new Point(20, 100), new Point(50, 150), new Point(145, 70) };
             Graphics g = this.CreateGraphics(); 
            g.DrawPolygon(redPen, point);
            g.Dispose();
        }

      

        private void прямоугольникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.FillRectangle(Brushes.Green, 100, 100, 500, 500);
            g.FillRectangle(Brushes.Black, 220, 220, 100, 200);
            g.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
        }

        private void трапецияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point[] point = { new Point(50, 100), new Point(100, 50), new Point(300, 200), new Point(200,300)};
            Graphics g = this.CreateGraphics();
            g.DrawPolygon(redPen, point);
            g.Dispose();
        }

        private void кругToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Green, 40, 40, 100, 140);
        }

        private void трапецияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] point = { new Point(50, 100), new Point(100, 50), new Point(300, 200), new Point(200, 300) };
            g.FillPolygon(Brushes.Green, point);
            g.Dispose();
        }

        private void шестиугольникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] point = { new Point(20, 100), new Point(50, 150), new Point(145, 70), new Point(220, 220), new Point(100, 200), new Point(90, 170) };
            g.FillPolygon(Brushes.Green, point);
            g.Dispose();
        }

        private void треугольникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] point = { new Point(20, 100), new Point(50, 150), new Point(145, 70) };
            g.FillPolygon(Brushes.Red, point);
            g.Dispose();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point[] point = { new Point(395, 170), new Point(445, 185), new Point(395, 190) };
            Point[] point1 = { new Point(360, 130), new Point(380, 50), new Point(420, 50),  new Point(440, 130) };
            g.FillPolygon(Brushes.DarkOrange, point);
            g.FillEllipse(Brushes.Snow, 350, 110, 100, 100);
            g.FillEllipse(Brushes.Snow, 300, 200, 200, 200);
            g.FillEllipse(Brushes.Snow, 250, 350, 300, 300 );
            g.FillEllipse(Brushes.Black, 375, 150, 15, 15);
            g.FillEllipse(Brushes.Black, 405, 150, 15, 15);
            g.FillPolygon(Brushes.DarkOrange, point);
            g.FillPolygon(Brushes.Gray, point1);
            Point[] point2 = { new Point(700, 400), new Point(600, 650), new Point(800,650) };
            g.FillPolygon(Brushes.DarkGreen, point2);
            Point[] point3 = { new Point(700, 200), new Point(640, 450), new Point(760, 450) };
            g.FillPolygon(Brushes.DarkGreen, point3);
            Point[] point4 = { new Point(700, 100), new Point(680, 250), new Point(720, 250) };
            g.FillPolygon(Brushes.DarkGreen, point4);









        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {   
           
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            Graphics g = this.CreateGraphics();
        
          
            
           
                g.Clear(Color.White);
                g.DrawEllipse(bluePen, x, y, 5, 5);

                if (x == 848)
                    weidth = true;
                if (x == 0)
                    weidth = false;
                if (y == 677)
                    heigth = true;
                if (y == 33)
                    heigth = false;
                if (weidth == true) x--;
                else x++;
                if (heigth == true) y--;
                else y++;
                Thread.Sleep(10);
            
            g.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            Graphics g = this.CreateGraphics();
            double x0, y0, x1, y1, x2, y2;
            g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen myPen = new Pen(Color.BlueViolet);
            g.DrawLine(Pens.Black, this.Width / 2, 0, this.Width / 2, this.Height);
            g.DrawLine(Pens.Black, 0, this.Height /2, this.Width, this.Height /2);
            x0 = this.Width / 2;
            y0 = this.Height / 2;
            x1 = -900;
            y1 = Math.Pow(x1, 2);
            for (int i = -900; i < 901; i++)
            {
                x2 = i;y2 = Math.Pow(x2, 2) / 50;
                g.DrawLine(myPen,(float)(x1 + x0), (float)(-y1 + y0),(float)( x2 + x0),(float)(-y2 + y0));
                x1 = x2;
                y1 = y2;
            }
            for (int i = -900; i < 901; i++)
            {
                x2 = i; y2 = Math.Pow(x2, 3) /300;
                g.DrawLine(myPen, (float)(x1 + x0), (float)(-y1 + y0), (float)(x2 + x0), (float)(-y2 + y0));
                x1 = x2;
                y1 = y2;
            }
            for (int i = -900; i < 901; i++)
            {
                x2 = i*100; y2 = Math.Sin(x2) * 250;
                g.DrawLine(myPen, (float)(x1 + x0), (float)(-y1 + y0), (float)(x2 + x0), (float)(-y2 + y0));
                x1 = x2;
                y1 = y2;
            }


            g.Dispose();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();
                {
                    g.DrawLine(Pens.DarkCyan,startPoint, e.Location);
                    startPoint = e.Location;
                }
            }
            
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            Random rnd = new Random();
            g.Clear(Color.DarkGray);
            for (int i = 0; i < 10; i++)
            {
                
                int x = rnd.Next(0,this.Width);
                int y = rnd.Next(0, this.Height);
                int weidth = rnd.Next(10, 11);
                int heigth = rnd.Next(10, 50);
                g.FillRectangle(Brushes.LightCyan, x, y, weidth, heigth);
                Thread.Sleep(100);
                g.DrawRectangle(Pens.Blue, x, y, weidth, heigth);

            }
        }
        private void krug(int x, int y, int radius,int count)   
        { 
            if (count != 0)
            {  Graphics g = this.CreateGraphics();

                g.DrawEllipse(Pens.Blue, x - radius, y - radius, radius * 2, radius * 2);
                krug( x, y, radius / 2, count - 1);
            }
               
            }

        private void toolStripMenuItem7_Click(object sender,EventArgs e)
        {
         
            krug( this.Width / 2, this.Height / 2, 100, 10);
        }

        private void kvadrat(int x, int y, int radius, int count)
        {
            if (count != 0)
            {
                Graphics g = this.CreateGraphics();

                g.DrawRectangle(Pens.Blue, x - radius, y - radius, radius * 2, radius * 2);
                kvadrat(x, y, radius / 2, count - 1);
            }

        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            kvadrat(this.Width / 2, this.Height / 2, 100, 10);
        }
        private void okrug(Graphics g,int N, int x, int y,int x0,int y0)
        {
            if (N < 0)
                return;
            else
            {
                g.DrawEllipse(Pens.Black, x0, y0, x, y);
                x += 50;
                y += 50;
                x0 += 50;
                y0 += 50;
                N--;
                Thread.Sleep(200);
                okrug(g, N, x, y, x0, y0);



            }
            g.Dispose();

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            okrug(g, 10, 50, 50, 0, 25);
        }


        private void snowflake(Graphics g,int x,int y,int size)
        {
            if (size > 0)
            {
                g.DrawEllipse(Pens.Blue, x, y, size, size);
                snowflake(g, x - size/2, y+ size*1,4 , size/2);
                snowflake(g, x + size , y +size , size / 2);
            //    snowflake(g,x,y+size/2, size/2);
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            snowflake(g, this.Width / 2, this.Height /2 , 100);
        }

        private void snowlake_(Graphics g,int x1,int y1,int x2,int y2,int x3,int y3,int radius1,int radius2,int radius3)
        {
            g.DrawLine(Pens.Blue, x1 - radius1, y1 - radius1, 2 * radius1, 2 * radius1);
            g.DrawLine(Pens.Blue, x2 - radius2, y2 - radius2, 2 * radius2, 2 * radius2);
            g.DrawLine(Pens.Blue, x3 - radius3, y3 - radius3, 2 * radius3, 2 * radius3);
            if (radius1 >5)
            {
              snowlake_(g, x1, y1, x2, y2, x3, y3, radius1 - 5, radius2 - 5, radius3 - 5);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int x = (int)(x1 + (x2 - x1) * i / 3.0);
                    int y = (int)(y1 + (y2 - y1) * i / 3.0);
                    g.DrawEllipse(Pens.Blue, x - 5, y - 5, 10, 10);
                }
            }

        }
        private void снежинкаЕщеОднаИзКруговToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int radius1 = 100;
            int radius2 = 200;
            int radius3 = 300;
            int x1 = 100;
            int y1 = 100;
            int x2 = 200;
            int y2 = 200;
            int x3 = 300;
            int y3 = 300;
            snowlake_(g, x1, y1, x2, y2, x3, y3, radius1, radius2, radius3);
        }
    }
}











 
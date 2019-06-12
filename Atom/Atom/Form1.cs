using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atom
{
    public partial class Form1 : Form
    {
        int[] pmxi = new int[400];
        int[] pmyi = new int[400];
 
        public struct Charge
        {
            public double x;
            public double y;
            public double z;

            public double AccX;
            public double AccY;
            public double AccZ;

            public double strength;
        }

        public struct MP
        {
            public double x;
            public double y;
            public double z;

            public double AccX;
            public double AccY;
            public double AccZ;

            public double strength;
        }

        public Charge[] c = new Charge[400];
        public MP[] m = new MP[400];

        public int[] opxi = new int[400];
        public int[] opyi = new int[400];

        //Number of electrons to calcute
        private int cc = 1;
        private int mm = 1;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                button1.Text = "Stop";
            else
                button1.Text = "Start";
        }

        private void Plot()
        {
            Pen ClearPen = new Pen(Color.White);
            Pen myPen = new Pen(Color.Blue, 1);
            Graphics g = Pb.CreateGraphics();

            for (int x = 0; x < cc; x++)
            {
                double px = c[x].x + Pb.Width / 2;
                double py = c[x].y + Pb.Height / 2;
                int pxi = Convert.ToInt32(px + 0.5);
                int pyi = Convert.ToInt32(py + 0.5);
                g.DrawEllipse(ClearPen, opxi[x], opyi[x], Convert.ToInt16(c[x].strength)*3, Convert.ToInt16(c[x].strength)*3);
                g.DrawEllipse(myPen, pxi, pyi, Convert.ToInt16(c[x].strength)*3, Convert.ToInt16(c[x].strength)*3);
                opxi[x] = pxi;
                opyi[x] = pyi;
            }
            g.Dispose();
            myPen.Dispose();
            ClearPen.Dispose();
        }

        private void PlotMP()
        {
            for (int y = 0; y < mm; y++)
            {
                double mx = m[y].x + Pb.Width / 2;
                double my = m[y].y + Pb.Height / 2;
                int mxi = Convert.ToInt32(mx + 0.5);
                int myi = Convert.ToInt32(my + 0.5);


                SolidBrush myBrush = new SolidBrush(Color.Red);
                SolidBrush CBrush = new SolidBrush(Color.White);

                Graphics g = Pb.CreateGraphics();

                Rectangle rect = new Rectangle(pmxi[y]-Convert.ToInt16(m[y].strength)/2, pmyi[y]-Convert.ToInt16(m[y].strength)/2, Convert.ToInt16(m[y].strength*4), Convert.ToInt16(m[y].strength*4));

                //g.DrawEllipse(CPen, pmxi, pmyi, 4, 4);
                //g.DrawEllipse(CPen, pmxi1, pmyi1, 4, 4);
                g.FillEllipse(CBrush, rect);

                rect = new Rectangle(mxi-Convert.ToInt16(m[y].strength)/2, myi-Convert.ToInt16(m[y].strength)/2, Convert.ToInt16(m[y].strength*4), Convert.ToInt16(m[y].strength*4));
                //g.DrawEllipse(myPen, mxi, myi, 4, 4);
                //g.DrawEllipse(myPen, mxi1, myi1, 4, 4);

                g.FillEllipse(myBrush, rect);

                pmxi[y] = mxi;
                pmyi[y] = myi;
                g.Dispose();
                myBrush.Dispose();
                CBrush.Dispose();
            }
        }

        private void CalculateAttraction()
        {
            //Attraction toward Matter Particle
            for (int y = 0; y < mm; y++)
            {
                for (int x = 0; x < cc; x++)
                {
                    //AccXY.Text = dist.ToString();
                    double Dist =  Math.Sqrt(Math.Pow(m[y].x - c[x].x, 2) + Math.Pow(m[y].y - c[x].y, 2));
                    double XDist = m[y].x - c[x].x;
                    double YDist = m[y].y - c[x].y;

                    double AccXAdd = (1 / Dist) * XDist * ((m[y].strength*1000 + c[x].strength) / Dist);
                    double AccYAdd = (1 / Dist) * YDist * ((m[y].strength*1000 + c[x].strength) / Dist);

                    if (AccXAdd > 1)
                        AccXAdd = 1;
                    if (AccYAdd > 1)
                        AccYAdd = 1;
                    if (AccXAdd < -1)
                        AccXAdd = -1;
                    if (AccYAdd < -1)
                        AccYAdd = -1;

                    c[x].AccX = c[x].AccX - AccXAdd;
                    c[x].AccY = c[x].AccY - AccYAdd;
                }
            }
            //AccXY.Text = c[1].AccX.ToString();
            
            //Replusion from Energy (particle)
            
            for (int x = 0; x < cc; x++)
            {
                for (int x1 = 0; x1 < cc; x1++)
                {
                    if (x1 != x)
                    {
                        double Dist = Math.Sqrt(Math.Pow(c[x1].x - c[x].x, 2) + Math.Pow(c[x1].y - c[x].y, 2));
                        double XDist = c[x1].x - c[x].x;
                        double YDist = c[x1].y - c[x].y;

                        double AccXAdd = (1 / Dist) * XDist * ((c[x1].strength/5 + c[x].strength/5) / Dist);
                        double AccYAdd = (1 / Dist) * YDist * ((c[x1].strength/5 + c[x].strength/5) / Dist);


                        if (AccXAdd > 1)
                            AccXAdd = 1;
                        if (AccYAdd > 1)
                            AccYAdd = 1;
                        if (AccXAdd < -1)
                            AccXAdd = 1;
                        if (AccYAdd < -1)
                            AccYAdd = 1;


                        c[x].AccX = c[x].AccX + AccXAdd;
                        c[x].AccY = c[x].AccY + AccYAdd;
                    }
                }
            }

            //DiffXY.Text = c[1].AccX.ToString();

            for (int x = 0; x < cc; x++)
            {
                c[x].x = c[x].x - c[x].AccX;
                c[x].y = c[x].y - c[x].AccY;
            }



            for (int x = 0; x < cc; x++)
                for (int y = 0; y < mm; y++)
                {
                    {
                        //AccXY.Text = dist.ToString();
                        double Dist = Math.Sqrt(Math.Pow(m[y].x - c[x].x, 2) + Math.Pow(m[y].y - c[x].y, 2));
                        double XDist = m[y].x - c[x].x;
                        double YDist = m[y].y - c[x].y;

                        //double AccXAdd = ((1 / Dist) * XDist * ((m[y].strength + c[x].strength) / Dist));
                        double AccXAdd = ((1 / Dist) * XDist * (1 / Dist));
                        double AccYAdd = ((1 / Dist) * YDist * (1 / Dist));

                        if (AccXAdd > 1)
                            AccXAdd = 1;
                        if (AccYAdd > 1)
                            AccYAdd = 1;
                        if (AccXAdd < -1)
                            AccXAdd = -1;
                        if (AccYAdd < -1)
                            AccYAdd = -1;


                        m[y].AccX = m[y].AccX - AccXAdd/1000;
                        m[y].AccY = m[y].AccY - AccYAdd/1000;
                    }
                }

            for (int y = 0; y < mm; y++)
            {
                m[y].x = m[y].x + m[y].AccX;
                m[y].y = m[y].y + m[y].AccY;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            CalculateAttraction();
            Plot();
            PlotMP();
            timer1.Enabled = true;
        }

        private void LoadData()
        {
            /*c[0].x = 90;
            c[0].y = 54;
            c[0].z = 0;
            c[0].AccX = 0.5;
            c[0].AccY = 0;
            c[0].AccZ = 0;
            c[0].strength = 0.01;*/

            Random r = new Random();

            for (int i = 0; i <= 390; i++)
            {
                c[i].x = r.Next(1000)-500;
                c[i].y = r.Next(500)-250;
                c[i].z = 0;
                c[i].AccX = 0;
                c[i].AccY = 0;
                c[i].AccZ = 0;
                c[i].strength = r.Next(10, 5000) / 1000;
            }









            /*m[0].x = 100;
            m[0].y = 0;
            m[0].AccX = 0;
            m[0].AccY = 0;
            m[0].AccZ = 0;
            m[0].strength = 2;

            m[1].x = -300;
            m[1].y = 0;
            m[1].AccX = 0;
            m[1].AccY = 0;
            m[1].AccZ = 0;
            m[1].strength = 5;
            */

            int CXN = 0;

            for (int x = 0; x <= 399; x++)
            {
                m[x].x = r.Next(-500,500);
                m[x].y = r.Next(-500, 500);
                m[x].AccX = 0;
                m[x].AccY = 0;
                m[x].AccZ = 0;
                m[x].strength = r.Next(10, 120) / 10;
                if (Atuo.Checked)
                {

                    c[CXN].x = m[x].x - 5;
                    c[CXN].y = m[x].y - 5;
                    c[CXN].z = 0;
                    c[CXN].AccX = 0;
                    c[CXN].AccY = 0;
                    c[CXN].AccZ = 0;
                    c[CXN].strength = m[x].strength/5;
                    CXN++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pb.Refresh();
            cc = Convert.ToInt16(ENX.Text);
            mm = Convert.ToInt16(MPX.Text);
            LoadData();
        }
    }
}

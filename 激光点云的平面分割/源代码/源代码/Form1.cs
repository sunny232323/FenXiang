using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 源代码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<pointt> points = new List<pointt>();
        double point;
        List<Shange> SG = new List<Shange>();
        List<M> m = new List<M>();
        private void 数据文件输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "文本文件|*.txt";
            file.Title = "请打开数据文件";
            int j = 0;
            if (file.ShowDialog() == DialogResult.OK)
            {
                j++;
                StreamReader reade = new StreamReader(file.FileName);
                while (!reade.EndOfStream)
                {
                    string k = reade.ReadLine();
                    string [] p=k.Split(',');
                    if (p.Length == 1)
                    {
                        point = Convert.ToDouble (p[0]);
                        
                    }
                    if(p.Length==4)
                    {
                        pointt point = new pointt(p[0], Convert.ToDouble(p[1]), Convert.ToDouble(p[2]), Convert.ToDouble(p[3]));
                        points.Add(point);
                    }
                    DataTable table = new DataTable();
                    table.Columns.Add("点名");
                    table.Columns.Add("X");
                    table.Columns.Add("Y");
                    table.Columns.Add("Z");
                     
                    for(int i = 0; i < points.Count(); i++)
                    {
                        DataRow row = table.NewRow();
                        row["点名"] = points[i].name;
                        row["X"] = points[i].X;
                        row["Y"] = points[i].Y;
                        row["Z"] = points[i].Z;
                        table.Rows.Add(row);
                    }
                    dataGridView1.DataSource = table;
                }
            }
        }
        public void wrtie (string s)
        {
            richTextBox1.Text += (s + "\n");
        }
        public void  JiSuan_MaxMin(List<pointt> points)
        {
            double Xmax, Ymax, Zmax, Xmin, Ymin, Zmin;
            Xmax = points[0].X;
            for(int i = 0; i < points.Count(); i++)
            {
                if (points[i].X > Xmax)
                {
                    Xmax = points[i].X;
                }
            }
            wrtie("x的Max为：" + Xmax.ToString("0.000"));
            Ymax = points[0].Y;
            for (int i = 0; i < points.Count(); i++)
            {
                if (points[i].Y > Ymax)
                {
                    Ymax = points[i].Y;
                }
            }
            wrtie("Y的Max为：" + Ymax.ToString("0.000"));
            Zmax = points[0].Z;
            for (int i = 0; i < points.Count(); i++)
            {
                if (points[i].Z > Zmax)
                {
                    Zmax = points[i].Z;
                }
            }
            wrtie("Z的Max为：" + Zmax.ToString("0.000"));
            Xmin = points[0].X;
            for (int i = 0; i < points.Count(); i++)
            {
                if (points[i].X < Xmin)
                {
                    Xmin = points[i].X;
                }
            }
            wrtie("x的Min为：" + Xmin.ToString("0.000"));
            Ymin = points[0].Y;
            for (int i = 0; i < points.Count(); i++)
            {
                if (points[i].Y < Ymin)
                {
                    Ymin = points[i].Y;
                }
            }
            wrtie("Y的Min为：" + Ymin.ToString("0.000"));
            Zmin = points[0].Z;
            for (int i = 0; i < points.Count(); i++)
            {
                if (points[i].Z < Zmin)
                {
                    Zmin = points[i].Z;
                }
            }
            wrtie("Z的Min为：" + Zmin.ToString("0.000"));
        }

        private void 计算MAX和MinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JiSuan_MaxMin(points);
        }
        public void JiSuan_hl(List<pointt> points)
        {
            for(int i = 0; i < point; i++)
            {
                points[i].i = (int)((points[i].Y) / 10);
                points[i].j = (int)((points[i].X) / 10);
            }
        }

        private void 分栅格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JiSuan_hl(points);
            wrtie("P5的i和j为：" + points[4].i.ToString() + ',' + points[4].j.ToString());
            
            
                for(int a = 0; a < 10; a++)
                {
                    for(int b = 0; b < 10; b++)
                    {
                        Shange sg = new Shange();
                        sg.i = a; sg.j = b;
                    for (int i = 0; i < point; i++)
                    {
                        if (points[i].i==a&& points[i].j == b)
                        {
                            
                            sg.pointss.Add(points[i]);
                            sg.P++;
                        }
                        SG.Add(sg);
                    }
                }
            }
            int m = 0;
            for(int i = 0; i < SG.Count(); i++)
            {
                if (SG[i].i == 3&& SG[i].j == 2)
                {
                    m = SG[i].P;
                }
            }
            wrtie("C中的点有："+ m.ToString());
        }
        public void JiSuan_h(List<Shange> SG)
        {
            for(int i = 0; i < SG.Count(); i++)
            {
                double h = 0;
                for(int j = 0; j < SG[i].pointss.Count(); j++)
                {
                    h += SG[i].pointss[j].Z;
                }
                SG[i].h = h / SG[i].P;
            }
            for (int i = 0; i < SG.Count(); i++)
            {
                double hmax = SG[i].pointss[0].Z;
                double hmin = SG[i].pointss[0].Z;
                for (int j = 0; j < SG[i].pointss.Count(); j++)
                {
                    if(hmax< SG[i].pointss[j].Z)
                    {
                        hmax = SG[i].pointss[j].Z;
                    }
                }

                for (int j = 0; j < SG[i].pointss.Count(); j++)
                {
                    if (hmin > SG[i].pointss[j].Z)
                    {
                        hmin = SG[i].pointss[j].Z;
                    }
                }
                SG[i].h_max = hmax;
                SG[i].h_min = hmin;
                SG[i].h_c = hmax - hmin;
            }
            for (int i = 0; i < SG.Count(); i++)
            {
                double sum = 0;
                for (int j = 0; j < SG[i].pointss.Count(); j++)
                {
                    sum += Math.Pow((SG[i].pointss[j].Z - SG[i].h), 2);
                }
                SG[i].h_f = sum / SG[i].P;
            }
        }

        private void 计算栅格高度信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JiSuan_h(SG);
            for (int i = 0; i < SG.Count(); i++)
            {
                if (SG[i].i == 3 && SG[i].j == 2)
                {
                    double m = SG[i].h;
                    wrtie("C中的平均高度：" + m.ToString("0.000"));
                    m = SG[i].h_max;
                    wrtie("C中的最大高度：" + m.ToString("0.000"));
                    m = SG[i].h_c;
                    wrtie("C中的高度差：" + m.ToString("0.000"));
                    m = SG[i].h_f;
                    wrtie("C中的高度方差：" + m.ToString("0.000"));
                }
            }
        }
        public double JiSuan_L(double x1, double x2,double y1,double y2)
        {
            double retu = Math.Pow(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2), 0.5);
            return retu;
        }
        
        public double []  P_NiHe(pointt x,pointt y,pointt z)
        {
            double a = JiSuan_L(x.X, y.X, x.Y, y.Y);
            double b = JiSuan_L(z.X, y.X, z.Y, y.Y);
            double c = JiSuan_L(x.X, z.X, x.Y, z.Y);
            double p = (a + b + c) / 2;
            double[] vs = new double[5];
            vs[0] = Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
            if (vs[0] > 0.1)
            {
                vs[1] = (y.Y - x.Y) * (z.Z - x.Z) - (z.Y - x.Y) * (y.Z - x.Z);
                vs[2]  = (y.Z - x.Z) * (z.X - x.X) - (z.Z - x.Z) * (y.X - x.X);
                vs[3]  = (y.X - x.X) * (z.Y - x.Y) - (z.X - x.X) * (y.Y - x.Y);
                vs[4]  = -x.X * vs[1] - x.Y * vs[2] - x.Z * vs[3];
            }
            return vs;
        }

        private void 拟合平面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZJ_NiHeM(points);
            wrtie("S1的S：" + m[0].S.ToString("0.000000"));
            wrtie("S1的A：" + m[0].A.ToString("0.000000"));
            wrtie("S1的B：" + m[0].B.ToString("0.000000"));
            wrtie("S1的C：" + m[0].C.ToString("0.000000"));
            wrtie("S1的D：" + m[0].D.ToString("0.000000"));
            wrtie("S1的内部点数量：" + m[0].N_points.ToString("0.000000"));
            wrtie("S1的外部点数量：" + m[0].W_points.ToString("0.000000"));
            wrtie("P5到S1：" + P5.ToString("0.000000"));
            wrtie("P1000到S1：" + P1000.ToString("0.000000"));
        }
        double P5, P1000;
        public void ZJ_NiHeM(List<pointt> points)
        {
            for(int i = 0, j = 0; j < 300; i += 3, j++)
            {
                double[] M = P_NiHe(points[i], points[i+1], points[i+2]);
                M mian = new M();
                mian.name = ("S" + (j + 1).ToString());
                mian.S = M[0];
                mian.A = M[1];
                mian.B = M[2];
                mian.C = M[3];
                mian.D = M[4];
                for(int a = 0; a < point; a++)
                {
                    if (a == i || a == i + 1 || a == i + 2)
                    {

                    }
                    else
                    {
                        double d = mian.A * points[a].X + mian.B * points[a].Y + mian.C * points[a].Z + mian.D;
                        if (d < 0)
                        {
                            d = -1 * d;
                        }
                        d = d / Math.Pow((Math.Pow(mian.A, 2) + Math.Pow(mian.B, 2) + Math.Pow(mian.C, 2)), 0.5);
                        if (d < 0.1)
                        {
                            mian.N_points++;
                            mian.npoints.Add(points[a]);
                            points[a].mian = "J1";
                        }
                        else
                        {
                            mian.W_points++;
                            mian.wpoints.Add(points[a]);
                        }
                        if (j == 0)
                        {
                            if (a == 4)
                            {
                                P5 = d;
                            }
                            if (a == 999)
                            {
                                P1000 = d;
                            }
                        }
                    }
                }
                m.Add(mian);
            }
        }
        M J1 = new M();
        List<M> m2 = new List<M>();
        public void ZJ2_NiHeM(List<pointt> point1)
        {
            for (int i = 0, j = 0; j < 80; i += 3, j++)
            {
                double[] M = P_NiHe(point1[i], point1[i + 1], point1[i + 2]);
                M mian = new M();
                mian.name = ("S" + (j + 1).ToString());
                mian.S = M[0];
                mian.A = M[1];
                mian.B = M[2];
                mian.C = M[3];
                mian.D = M[4];
                for (int a = 0; a < point1.Count(); a++)
                {
                    if (a == i || a == i + 1 || a == i + 2)
                    {

                    }
                    else
                    {
                        double d = mian.A * point1[a].X + mian.B * point1[a].Y + mian.C * point1[a].Z + mian.D;
                        if (d < 0)
                        {
                            d = -1 * d;
                        }
                        d = d / Math.Pow((Math.Pow(mian.A, 2) + Math.Pow(mian.B, 2) + Math.Pow(mian.C, 2)), 0.5);
                        if (d < 0.1)
                        {
                            mian.N_points++;
                            mian.npoints.Add(point1[a]);
                            points[a].mian = "J2";
                        }
                        else
                        {
                            mian.W_points++;
                            mian.wpoints.Add(point1[a]);
                            
                        }
                        
                    }
                }
                m2.Add(mian);
            }
        }
        M J2 = new M();

        private void 计算ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZJ_J();
            wrtie("J1," + J1.S.ToString("0.000000") + ',' + J1.A.ToString("0.000000") + ',' + J1.B.ToString("0.000000") + ',' + J1.C.ToString("0.000000") + ',' + J1.D.ToString("0.000000") + ',' + J1.N_points.ToString("0.000000") + ',' + J1.W_points.ToString("0.000000") + ',');
            wrtie("J1," + J2.S.ToString("0.000000") + ',' + J2.A.ToString("0.000000") + ',' + J2.B.ToString("0.000000") + ',' + J2.C.ToString("0.000000") + ',' + J2.D.ToString("0.000000") + ',' + J2.N_points.ToString("0.000000") + ',' + J2.W_points.ToString("0.000000") + ',');
        }

        public void ZJ_J()
        {
            J1 = m[0];
            for(int i =0;i<m.Count(); i++)
            {
                if (m[i].N_points > J1.N_points)
                {
                    J1 = m[i];
                }
            }
            
            ZJ2_NiHeM(J1.wpoints);
            J2 = m2[0];
            for (int i = 0; i < m2.Count(); i++)
            {
                if (m2[i].N_points > J2.N_points)
                {
                    J2 = m2[i];
                }
            }
        }
        double x5, y5, z5;

        private void 计算投影坐标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            T(points[4]);
            T(points[799]);
        }

        private void 导出文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "result.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(save.FileName);
                for (int i = 0; i < point; i++)
                {
                    stream.WriteLine(points[i].name +','+ points[i].X.ToString() + ',' + points[i].Y.ToString() + ',' + points[i].Z.ToString() + ',' + points[i].mian);
                }
                stream.Close();
            }
        }

        double x800, y800, z800;
        
        public void T(pointt p)
        {
            x5 = (Math.Pow(J1.B, 2) + Math.Pow(J1.C, 2)-J1.A*(J1.B*p.Y+J1.C*p.Z+J1.D))/(Math.Pow(J1.A,2)+ Math.Pow(J1.B, 2)+ Math.Pow(J1.C, 2));
            y5 = (Math.Pow(J1.A, 2) + Math.Pow(J1.C, 2) - J1.B * (J1.A * p.Y + J1.C * p.Z + J1.D)) / (Math.Pow(J1.A, 2) + Math.Pow(J1.B, 2) + Math.Pow(J1.C, 2));
            z5 = (Math.Pow(J1.A, 2) + Math.Pow(J1.B, 2) - J1.C * (J1.A * p.Y + J1.B * p.Z + J1.D)) / (Math.Pow(J1.A, 2) + Math.Pow(J1.B, 2) + Math.Pow(J1.C, 2));
            wrtie("P5在J1上的投影坐标为" + x5.ToString("0.000")+',' + y5.ToString("0.000")+',' + z5.ToString("0.000")+',');
        }

    }
    
}


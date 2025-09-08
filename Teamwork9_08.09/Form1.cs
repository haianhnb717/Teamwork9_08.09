using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teamwork9_08._09
{
    public partial class Form1 : Form
    {
        double a, b, c, d, x1, x2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnend_Click(object sender, EventArgs e)
        {
            this.Close();//ket thuc form nay dong form
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            a=Convert.ToDouble(txta.Text);
            b=Convert.ToDouble(txtb.Text);
            c=Convert.ToDouble(txtc.Text);
            d=b*b-4*a*c;
            if (d<0)
            {
                lblkq1.Text ="Phuong trinh vo nghiem";
                //MessageBox.Show("Phuong trinh vo nghiem");
            }
            else if (d==0)
            {
                x1 = -b / (2 * a);
                lblkq1.Text="Phuong trinh co nghiem kep x1=x2="+Math.Round(x1, 1);
                //MessageBox.Show("Phuong trinh co nghiem kep x1=x2="+x1);
            }
            else
            {
                x1=(-b+Math.Sqrt(d))/(2*a);
                x2=(-b-Math.Sqrt(d))/(2*a);
                lblkq1.Text="Phuong trinh co 2 nghiem phan biet:\n x1="+ Math.Round(x1, 1) + "\n x2="+ Math.Round(x2, 1);
                //MessageBox.Show("Phuong trinh co 2 nghiem phan biet:\n x1="+x1+"\n x2="+x2);
            }
        }
    }
}

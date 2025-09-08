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
    public partial class frmHanh : Form
    {
        double a, b, c, d;
        public frmHanh()
        {
            InitializeComponent();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
            txt_c.Clear();
            kq_1.Clear();
            kq_2.Clear();
            txt_a.Focus();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txt_a.Text);
                b = Convert.ToDouble(txt_b.Text);
                c = Convert.ToDouble(txt_c.Text);

                d = b * b - 4 * a * c;

                if (d < 0)
                {
                    lbl_kq.Text = "Phương trình vô nghiệm";
                }
                else if (d == 0)
                {
                    double x = -b / (2 * a);
                    lbl_kq.Text = $"Phương trình có nghiệm kép: x1 = x2 = {x}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    //kq_1 = x1;
                    //kq_2 = x2;
                    lbl_kq.text = $"phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!\nChi tiết lỗi: " + ex.Message, "Lỗi nhập liệu");
            }
        }
    }
}

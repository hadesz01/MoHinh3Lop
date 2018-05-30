using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using Public;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SinhVienBUL cls = new SinhVienBUL();
            dgvDSSV.DataSource = cls.DSSV();
            txtMaSV.Text = GetMa();
        }
        private string GetMa()
        {
            SinhVienBUL cls = new SinhVienBUL();
            DataTable a = cls.SinhMa();
            //for (int i = 0; i < a.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < a.Columns.Count - 1; j++)
            //    {
            //        string x = a.Rows[i][j].ToString();
            //    }
            //}
            string x = a.Rows[0][0].ToString();
            string getMaSV = "00" + x;
            getMaSV = getMaSV.Substring(getMaSV.Length - 3, 3);
            return "SV"+getMaSV;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVienBUL cls = new SinhVienBUL();
            HocSinhPublic x = new HocSinhPublic();
            x.MaSV = txtMaSV.Text;
            x.TenSV = txtTenSV.Text;
            x.MaLop = txtMaLop.Text;
            cls.ThemSV(x);
            Form1_Load(sender, e);
        }
        
    }
}

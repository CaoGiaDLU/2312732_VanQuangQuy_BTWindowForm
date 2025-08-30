using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_BT3
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien("2312732", "Văn Quang Qúy", "02/08/2005", 12, 2.7);
            double kq = 0;

            //Hiển thị kết quả sử dụng lblThongBao
            lblThongBao.Text = nv.HienThi();

            kq = nv.TinhLuong();
            //Hiển thị kết quả Lương sử dụng lblLuong
            lblLuong.Text = kq.ToString();
        }
    }
}

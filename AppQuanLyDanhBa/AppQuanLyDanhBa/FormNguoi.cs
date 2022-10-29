using AppQuanLyDanhBa.Model;
using AppQuanLyDanhBa.Services;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyDanhBa
{
    public partial class FormNguoi : Form
    {

        NhomViewModel nh;
        public FormNguoi(NhomViewModel nh)
        {

            InitializeComponent();
            NapNhomLienLac();
            this.nh = nh;
            if (nh != null)
            {
               txtnhom.Text  = nh.TenNhom;
            }
        }
        void NapNhomLienLac()
        {
            var list = Nhomservices.GetList();

        }
        public FormNguoi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormNguoi_Load(object sender, EventArgs e)
        {

        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            var ng = new Nguoi
            {

                TenGoi = txttengoi.Text,
                Email = txtemail.Text,
                PhoneNumber = txtsđt.Text,
                DiaChi = txtdiachi.Text,
                IDNhom = nh.ID,


            };
            if (String.IsNullOrEmpty(txttengoi.Text))
            {
                MessageBox.Show("Hãy đặt tên liên lạc !", "Thông báo");
                txttengoi.Focus();


            }
            else if (String.IsNullOrEmpty(txtsđt.Text))
            {
                MessageBox.Show("Số điện thoại không được trống !", "Thông báo");
                txttengoi.Focus();
            }
            else
            {
                if (NguoiServices.AddLienLac(ng) == KetQua.Loi)
                {
                    MessageBox.Show("Số điện thoại hoặc tên liên lạc đã tồn tại !", "Thông báo");
                    txtsđt.Focus();

                }

                else
                {
                    MessageBox.Show("Đã thêm liên lạc mới!", "Thong bao");

                    DialogResult = DialogResult.OK;
                }
            }


        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsđt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}

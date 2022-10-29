using AppQuanLyDanhBa.Model;
using AppQuanLyDanhBa.Services;
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
    public partial class FormNhom : Form
    {

        public FormNhom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txttenhom.Text))
            {
                MessageBox.Show("Tên nhóm không được để trống", "Thong bao");
               txttenhom.Focus();


            }
            else
            {
                var nh = new Nhom
                {
                    TenNhom = txttenhom.Text,
                };
                if (Nhomservices.AddNhom(nh) == ViewModel.KetQua.ThanhCong)
                {

                    MessageBox.Show("Đã thêm nhóm thành công", "Thông báo");
                    DialogResult = DialogResult.OK;
                }

                else
                {
                    MessageBox.Show($" {txttenhom} đã tồn tại !", "Thông báo");
                    DialogResult = DialogResult.No;
                    txttenhom.Focus();
                }

            }
        }
    }
}
    


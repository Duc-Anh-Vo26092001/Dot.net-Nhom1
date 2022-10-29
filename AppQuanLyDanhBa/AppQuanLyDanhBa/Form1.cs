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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            NapDsNhom();
            NapDsNguoi();
            NapThongTinLienLac();

        }

        public NhomViewModel selectedNhom
        {
            get
            {
                return bdsNhom.Current as NhomViewModel;
            }
        }
        public NguoiViewModel selectedNguoi
        {
            get
            {
                return bdsNguoi.Current as NguoiViewModel;
            }
        }

        void NapDsNhom()
        {
            var ls = Nhomservices.GetList();
            bdsNhom.DataSource = ls;
            dataGridView1.DataSource = bdsNhom;
        }
        void NapDsNguoi()

        {
            if (selectedNhom != null)
            {
                var ls = NguoiServices.GetList(selectedNhom.ID);
                bdsNguoi.DataSource = ls;
                dataGridView2.DataSource = bdsNguoi;
            }
        }
        void NapThongTinLienLac()
        {
            lbtengoi.Text = selectedNguoi.TenGoi;
            lbemail.Text = selectedNguoi.Email;
            lbsđt.Text = selectedNguoi.PhoneNumber;
            lbdiachi.Text = selectedNguoi.DiaChi;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void bdsNguoi_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bdsNhom_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedNhom != null)
            {
                NapDsNguoi();
                NapThongTinLienLac();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedNguoi != null)
            {
                NapThongTinLienLac();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var f = new FormNhom();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsNhom();
            }
        }

        private void btnxoanhom_Click(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var rs = MessageBox.Show($"Bạn có chắc muốn xóa {selectedNhom.TenNhom}?", "Chú ý", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {

                    if (Nhomservices.RemoveNhom(selectedNhom) == KetQua.Loi)
                    {
                        MessageBox.Show("Nhóm này đang có người liên lạc không thể xóa !", "Thông báo");

                    }
                    else
                    {
                        NapDsNhom();
                    }

                }

            }
        }

        private void btnthemll_Click(object sender, EventArgs e)
        {
            var f = new FormNguoi(selectedNhom);
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsNguoi();
            }

        }

        private void btnxoall_Click(object sender, EventArgs e)
        {

            if (selectedNguoi != null)
            {
                var rs = MessageBox.Show($"Bạn có muốn xóa {selectedNguoi.TenGoi} ?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK) 


                NguoiServices.RemoveLienLac(selectedNguoi);
                NapDsNguoi();
            }

        }
    }
}

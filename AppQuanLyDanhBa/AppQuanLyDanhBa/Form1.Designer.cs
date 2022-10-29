namespace AppQuanLyDanhBa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.btnxoanhom = new System.Windows.Forms.ToolStripButton();
            this.btnthemll = new System.Windows.Forms.ToolStripButton();
            this.btnxoall = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.txttengoi = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbsđt = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbtengoi = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tenGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsNguoi = new System.Windows.Forms.BindingSource(this.components);
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsNhom = new System.Windows.Forms.BindingSource(this.components);
            label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(516, 470);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(88, 16);
            label5.TabIndex = 8;
            label5.Text = "Số điện thoại:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem,
            this.btnxoanhom,
            this.toolStripSeparator1,
            this.btnthemll,
            this.btnxoall,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1394, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(115, 24);
            this.btnthem.Text = "Thêm Nhóm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoanhom
            // 
            this.btnxoanhom.Image = ((System.Drawing.Image)(resources.GetObject("btnxoanhom.Image")));
            this.btnxoanhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoanhom.Name = "btnxoanhom";
            this.btnxoanhom.Size = new System.Drawing.Size(104, 24);
            this.btnxoanhom.Text = "Xóa Nhóm";
            this.btnxoanhom.Click += new System.EventHandler(this.btnxoanhom_Click);
            // 
            // btnthemll
            // 
            this.btnthemll.Image = ((System.Drawing.Image)(resources.GetObject("btnthemll.Image")));
            this.btnthemll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthemll.Name = "btnthemll";
            this.btnthemll.Size = new System.Drawing.Size(121, 24);
            this.btnthemll.Text = "Thêm liên lạc";
            this.btnthemll.Click += new System.EventHandler(this.btnthemll_Click);
            // 
            // btnxoall
            // 
            this.btnxoall.Image = ((System.Drawing.Image)(resources.GetObject("btnxoall.Image")));
            this.btnxoall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoall.Name = "btnxoall";
            this.btnxoall.Size = new System.Drawing.Size(110, 24);
            this.btnxoall.Text = "Xóa liên lạc";
            this.btnxoall.Click += new System.EventHandler(this.btnxoall_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(155, 24);
            this.toolStripLabel1.Text = "Nhập từ cần tìm kiếm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdsNhom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(486, 475);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenGoiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bdsNguoi;
            this.dataGridView2.Location = new System.Drawing.Point(498, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(872, 277);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "[Tên gọi]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(518, 431);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // txttengoi
            // 
            this.txttengoi.AutoSize = true;
            this.txttengoi.Location = new System.Drawing.Point(643, 355);
            this.txttengoi.Name = "txttengoi";
            this.txttengoi.Size = new System.Drawing.Size(0, 16);
            this.txttengoi.TabIndex = 9;
            // 
            // txtdiachi
            // 
            this.txtdiachi.AutoSize = true;
            this.txtdiachi.Location = new System.Drawing.Point(643, 394);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(0, 16);
            this.txtdiachi.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbsđt);
            this.panel1.Controls.Add(this.lbemail);
            this.panel1.Controls.Add(this.lbdiachi);
            this.panel1.Controls.Add(this.lbtengoi);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.txttengoi);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 520);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbsđt
            // 
            this.lbsđt.AutoSize = true;
            this.lbsđt.Location = new System.Drawing.Point(671, 470);
            this.lbsđt.Name = "lbsđt";
            this.lbsđt.Size = new System.Drawing.Size(44, 16);
            this.lbsđt.TabIndex = 14;
            this.lbsđt.Text = "label8";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(671, 431);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(44, 16);
            this.lbemail.TabIndex = 13;
            this.lbemail.Text = "label7";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(671, 394);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(44, 16);
            this.lbdiachi.TabIndex = 12;
            this.lbdiachi.Text = "label6";
            // 
            // lbtengoi
            // 
            this.lbtengoi.AutoSize = true;
            this.lbtengoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtengoi.Location = new System.Drawing.Point(669, 346);
            this.lbtengoi.Name = "lbtengoi";
            this.lbtengoi.Size = new System.Drawing.Size(70, 25);
            this.lbtengoi.TabIndex = 11;
            this.lbtengoi.Text = "label4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tenGoiDataGridViewTextBoxColumn
            // 
            this.tenGoiDataGridViewTextBoxColumn.DataPropertyName = "TenGoi";
            this.tenGoiDataGridViewTextBoxColumn.HeaderText = "Tên Gọi";
            this.tenGoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenGoiDataGridViewTextBoxColumn.Name = "tenGoiDataGridViewTextBoxColumn";
            this.tenGoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // bdsNguoi
            // 
            this.bdsNguoi.DataSource = typeof(AppQuanLyDanhBa.Model.Nguoi);
            this.bdsNguoi.CurrentChanged += new System.EventHandler(this.bdsNguoi_CurrentChanged);
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "Tên Nhóm";
            this.tenNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            // 
            // bdsNhom
            // 
            this.bdsNhom.DataSource = typeof(AppQuanLyDanhBa.Model.Nhom);
            this.bdsNhom.CurrentChanged += new System.EventHandler(this.bdsNhom_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 565);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsNguoi;
        private System.Windows.Forms.BindingSource bdsNhom;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStripButton btnxoanhom;
        private System.Windows.Forms.ToolStripButton btnthemll;
        private System.Windows.Forms.ToolStripButton btnxoall;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label txttengoi;
        private System.Windows.Forms.Label txtdiachi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbsđt;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbtengoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}


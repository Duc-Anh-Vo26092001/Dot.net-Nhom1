namespace AppQuanLyDanhBa
{
    partial class FormNguoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttengoi = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.btndongy = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnhom = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsđt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM NGƯỜI LIÊN LẠC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên gọi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ:";
            // 
            // txttengoi
            // 
            this.txttengoi.Location = new System.Drawing.Point(241, 87);
            this.txttengoi.Name = "txttengoi";
            this.txttengoi.Size = new System.Drawing.Size(228, 22);
            this.txttengoi.TabIndex = 6;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(241, 255);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(228, 22);
            this.txtdiachi.TabIndex = 9;
            this.txtdiachi.TextChanged += new System.EventHandler(this.txtdiachi_TextChanged);
            // 
            // btndongy
            // 
            this.btndongy.Location = new System.Drawing.Point(241, 357);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(75, 35);
            this.btndongy.TabIndex = 10;
            this.btndongy.Text = "Đồng ý";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(394, 357);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 35);
            this.btnboqua.TabIndex = 11;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nhóm";
            // 
            // txtnhom
            // 
            this.txtnhom.Location = new System.Drawing.Point(241, 313);
            this.txtnhom.Name = "txtnhom";
            this.txtnhom.Size = new System.Drawing.Size(228, 22);
            this.txtnhom.TabIndex = 13;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(241, 150);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(228, 22);
            this.txtemail.TabIndex = 14;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged_1);
            // 
            // txtsđt
            // 
            this.txtsđt.Location = new System.Drawing.Point(241, 205);
            this.txtsđt.Name = "txtsđt";
            this.txtsđt.Size = new System.Drawing.Size(228, 22);
            this.txtsđt.TabIndex = 15;
            // 
            // FormNguoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsđt);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnhom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttengoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNguoi";
            this.Text = "FormNguoi";
            this.Load += new System.EventHandler(this.FormNguoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttengoi;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnhom;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsđt;
    }
}
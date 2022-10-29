namespace AppQuanLyDanhBa
{
    partial class FormNhom
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
            this.txttenhom = new System.Windows.Forms.TextBox();
            this.btndongy = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM NHÓM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhóm:";
            // 
            // txttenhom
            // 
            this.txttenhom.Location = new System.Drawing.Point(220, 140);
            this.txttenhom.Name = "txttenhom";
            this.txttenhom.Size = new System.Drawing.Size(191, 22);
            this.txttenhom.TabIndex = 2;
            // 
            // btndongy
            // 
            this.btndongy.Location = new System.Drawing.Point(220, 230);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(75, 31);
            this.btndongy.TabIndex = 3;
            this.btndongy.Text = "Đồng ý";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(336, 230);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 31);
            this.btnboqua.TabIndex = 4;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // FormNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.txttenhom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhom";
            this.Text = "FormNhom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenhom;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.Button btnboqua;
    }
}
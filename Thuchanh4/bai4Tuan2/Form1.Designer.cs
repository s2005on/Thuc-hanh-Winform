namespace bai4Tuan2
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
            this.lblSo1 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.grbPhepTinh = new System.Windows.Forms.GroupBox();
            this.radCong = new System.Windows.Forms.RadioButton();
            this.radTru = new System.Windows.Forms.RadioButton();
            this.radNhan = new System.Windows.Forms.RadioButton();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.grbPhepTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSo1
            // 
            this.lblSo1.AutoSize = true;
            this.lblSo1.Location = new System.Drawing.Point(158, 86);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(34, 16);
            this.lblSo1.TabIndex = 0;
            this.lblSo1.Text = "Số 1";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(213, 80);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(324, 22);
            this.txtSo1.TabIndex = 1;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // lblSo2
            // 
            this.lblSo2.AutoSize = true;
            this.lblSo2.Location = new System.Drawing.Point(161, 130);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(34, 16);
            this.lblSo2.TabIndex = 2;
            this.lblSo2.Text = "Số 2";
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(213, 130);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(324, 22);
            this.txtSo2.TabIndex = 3;
            this.txtSo2.TextChanged += new System.EventHandler(this.txtSo2_TextChanged);
            // 
            // grbPhepTinh
            // 
            this.grbPhepTinh.Controls.Add(this.radChia);
            this.grbPhepTinh.Controls.Add(this.radNhan);
            this.grbPhepTinh.Controls.Add(this.radTru);
            this.grbPhepTinh.Controls.Add(this.radCong);
            this.grbPhepTinh.Location = new System.Drawing.Point(106, 212);
            this.grbPhepTinh.Name = "grbPhepTinh";
            this.grbPhepTinh.Size = new System.Drawing.Size(644, 100);
            this.grbPhepTinh.TabIndex = 4;
            this.grbPhepTinh.TabStop = false;
            this.grbPhepTinh.Text = "Phép tính";
            this.grbPhepTinh.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radCong
            // 
            this.radCong.AutoSize = true;
            this.radCong.Location = new System.Drawing.Point(36, 46);
            this.radCong.Name = "radCong";
            this.radCong.Size = new System.Drawing.Size(60, 20);
            this.radCong.TabIndex = 0;
            this.radCong.TabStop = true;
            this.radCong.Text = "Cộng";
            this.radCong.UseVisualStyleBackColor = true;
            this.radCong.CheckedChanged += new System.EventHandler(this.radCong_CheckedChanged);
            // 
            // radTru
            // 
            this.radTru.AutoSize = true;
            this.radTru.Location = new System.Drawing.Point(184, 46);
            this.radTru.Name = "radTru";
            this.radTru.Size = new System.Drawing.Size(48, 20);
            this.radTru.TabIndex = 1;
            this.radTru.TabStop = true;
            this.radTru.Text = "Trừ";
            this.radTru.UseVisualStyleBackColor = true;
            this.radTru.CheckedChanged += new System.EventHandler(this.radTru_CheckedChanged);
            // 
            // radNhan
            // 
            this.radNhan.AutoSize = true;
            this.radNhan.Location = new System.Drawing.Point(344, 46);
            this.radNhan.Name = "radNhan";
            this.radNhan.Size = new System.Drawing.Size(60, 20);
            this.radNhan.TabIndex = 2;
            this.radNhan.TabStop = true;
            this.radNhan.Text = "Nhân";
            this.radNhan.UseVisualStyleBackColor = true;
            this.radNhan.CheckedChanged += new System.EventHandler(this.radNhan_CheckedChanged);
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Location = new System.Drawing.Point(501, 46);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(55, 20);
            this.radChia.TabIndex = 3;
            this.radChia.TabStop = true;
            this.radChia.Text = "Chia";
            this.radChia.UseVisualStyleBackColor = true;
            this.radChia.CheckedChanged += new System.EventHandler(this.radChia_CheckedChanged);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(139, 374);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(54, 16);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "Kết Quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(248, 374);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(406, 22);
            this.txtKQ.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.grbPhepTinh);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.lblSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lblSo1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phép tính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPhepTinh.ResumeLayout(false);
            this.grbPhepTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox grbPhepTinh;
        private System.Windows.Forms.RadioButton radChia;
        private System.Windows.Forms.RadioButton radNhan;
        private System.Windows.Forms.RadioButton radTru;
        private System.Windows.Forms.RadioButton radCong;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtKQ;
    }
}


namespace Thuchanh2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtHoTen = new TextBox();
            txtKQ = new TextBox();
            rad2 = new RadioButton();
            rad1 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 88);
            label1.Name = "label1";
            label1.Size = new Size(86, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            label1.Click += label1_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(301, 85);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(296, 30);
            txtHoTen.TabIndex = 2;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(301, 234);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(296, 30);
            txtKQ.TabIndex = 3;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(6, 70);
            rad2.Name = "rad2";
            rad2.Size = new Size(136, 26);
            rad2.TabIndex = 4;
            rad2.TabStop = true;
            rad2.Text = "Chữ IN HOA";
            rad2.UseVisualStyleBackColor = true;
            rad2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(6, 29);
            rad1.Name = "rad1";
            rad1.Size = new Size(123, 26);
            rad1.TabIndex = 5;
            rad1.TabStop = true;
            rad1.Text = "Chữ thường";
            rad1.UseVisualStyleBackColor = true;
            rad1.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(183, 231);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 6;
            button1.Text = "Kết Quả";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(503, 138);
            button2.Name = "button2";
            button2.Size = new Size(94, 90);
            button2.TabIndex = 7;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad1);
            groupBox1.Controls.Add(rad2);
            groupBox1.Location = new Point(183, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 102);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn kiểu chữ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 430);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtKQ);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Đổi kiểu chữ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private TextBox txtKQ;
        private RadioButton rad2;
        private RadioButton rad1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
    }
}

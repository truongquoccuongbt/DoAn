namespace DoAn
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.txtPhuAmDau = new System.Windows.Forms.TextBox();
            this.txtNguyenAm = new System.Windows.Forms.TextBox();
            this.txtPhuAmCuoi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGhep = new System.Windows.Forms.Button();
            this.txtDau = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(306, 374);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(42, 22);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "Mở file";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // txtPhuAmDau
            // 
            this.txtPhuAmDau.Location = new System.Drawing.Point(16, 54);
            this.txtPhuAmDau.Name = "txtPhuAmDau";
            this.txtPhuAmDau.Size = new System.Drawing.Size(51, 20);
            this.txtPhuAmDau.TabIndex = 1;
            // 
            // txtNguyenAm
            // 
            this.txtNguyenAm.Location = new System.Drawing.Point(87, 54);
            this.txtNguyenAm.Name = "txtNguyenAm";
            this.txtNguyenAm.Size = new System.Drawing.Size(51, 20);
            this.txtNguyenAm.TabIndex = 2;
            // 
            // txtPhuAmCuoi
            // 
            this.txtPhuAmCuoi.Location = new System.Drawing.Point(161, 54);
            this.txtPhuAmCuoi.Name = "txtPhuAmCuoi";
            this.txtPhuAmCuoi.Size = new System.Drawing.Size(51, 20);
            this.txtPhuAmCuoi.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btGhep);
            this.groupBox1.Controls.Add(this.txtDau);
            this.groupBox1.Controls.Add(this.txtPhuAmCuoi);
            this.groupBox1.Controls.Add(this.txtNguyenAm);
            this.groupBox1.Controls.Add(this.txtPhuAmDau);
            this.groupBox1.Location = new System.Drawing.Point(387, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghép từ";
            // 
            // btGhep
            // 
            this.btGhep.Location = new System.Drawing.Point(110, 95);
            this.btGhep.Name = "btGhep";
            this.btGhep.Size = new System.Drawing.Size(75, 23);
            this.btGhep.TabIndex = 5;
            this.btGhep.Text = "Ghép từ";
            this.btGhep.UseVisualStyleBackColor = true;
            this.btGhep.Click += new System.EventHandler(this.btGhep_Click);
            // 
            // txtDau
            // 
            this.txtDau.Location = new System.Drawing.Point(229, 54);
            this.txtDau.Name = "txtDau";
            this.txtDau.Size = new System.Drawing.Size(51, 20);
            this.txtDau.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(391, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 142);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyển phiên âm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phụ âm đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ng.Âm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "P.Âm.Cuôi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dấu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chuyển";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox txtPhuAmDau;
        private System.Windows.Forms.TextBox txtNguyenAm;
        private System.Windows.Forms.TextBox txtPhuAmCuoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGhep;
        private System.Windows.Forms.TextBox txtDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


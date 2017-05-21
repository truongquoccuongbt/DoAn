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
            this.txtDau = new System.Windows.Forms.TextBox();
            this.btGhep = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.txtPhuAmDau.Location = new System.Drawing.Point(6, 34);
            this.txtPhuAmDau.Name = "txtPhuAmDau";
            this.txtPhuAmDau.Size = new System.Drawing.Size(51, 20);
            this.txtPhuAmDau.TabIndex = 1;
            // 
            // txtNguyenAm
            // 
            this.txtNguyenAm.Location = new System.Drawing.Point(77, 34);
            this.txtNguyenAm.Name = "txtNguyenAm";
            this.txtNguyenAm.Size = new System.Drawing.Size(51, 20);
            this.txtNguyenAm.TabIndex = 2;
            // 
            // txtPhuAmCuoi
            // 
            this.txtPhuAmCuoi.Location = new System.Drawing.Point(151, 34);
            this.txtPhuAmCuoi.Name = "txtPhuAmCuoi";
            this.txtPhuAmCuoi.Size = new System.Drawing.Size(51, 20);
            this.txtPhuAmCuoi.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGhep);
            this.groupBox1.Controls.Add(this.txtDau);
            this.groupBox1.Controls.Add(this.txtPhuAmCuoi);
            this.groupBox1.Controls.Add(this.txtNguyenAm);
            this.groupBox1.Controls.Add(this.txtPhuAmDau);
            this.groupBox1.Location = new System.Drawing.Point(387, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtDau
            // 
            this.txtDau.Location = new System.Drawing.Point(219, 34);
            this.txtDau.Name = "txtDau";
            this.txtDau.Size = new System.Drawing.Size(51, 20);
            this.txtDau.TabIndex = 4;
            // 
            // btGhep
            // 
            this.btGhep.Location = new System.Drawing.Point(110, 79);
            this.btGhep.Name = "btGhep";
            this.btGhep.Size = new System.Drawing.Size(75, 23);
            this.btGhep.TabIndex = 5;
            this.btGhep.Text = "Ghép từ";
            this.btGhep.UseVisualStyleBackColor = true;
            this.btGhep.Click += new System.EventHandler(this.btGhep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}


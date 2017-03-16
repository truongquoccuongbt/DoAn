using System;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            TuVung a = new CaiDat(input);
            //String chuoi = "phụ âm đầu: " + a.PhuAmDau + "\r\n" + "Nguyên âm: " + a.NguyenAm + "\r\n" + "Phụ âm cuối: " + a.PhuAmCuoi +
            //                "\r\n" + "Dau: " + a.Dau;
            textBox2.Text = a.XoaPhuAmCuoi();
        }
    }
}

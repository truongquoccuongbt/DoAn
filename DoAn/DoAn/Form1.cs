using System;
using System.Text;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Form1 : Form
    {
        string sr = "";
        public Form1()
        {
            InitializeComponent();
            docFileText();
        }

        private void docFileText()
        {
        
            
            


        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                sr = open.FileName;
            }
            string text = System.IO.File.ReadAllText(sr);
            AmTiet at = new CaiDat(text);
           
            string result = "";
            string input = text + "\n\n";
            string KtTiengViet = "Kiểm tra tiếng Việt: " + at.kiemTraAmTiengViet().ToString() + "\n";
      
            string khongDau = "Từ không dấu: " + at.xoaTatCaDau() + "\n";
            string layPhuAmDau = "Phụ âm đầu: " + at.phuAmDau + "\n";
            string layNguyenAm = "Nguyên âm: " + at.nguyenAm + "\n";
            string layphuAmCuoi = "Phụ âm cuối: " + at.phuAmCuoi + "\n";
            string layDau = "Dấu: " + at.dau + "\n";
            string kiemTraInThuong = "Kiểm tra in thường: " + at.kiemTraInThuong().ToString() + "\n";
            string kiemTraInHoa = "Kiểm tra in hoa: " + at.kiemTraInHoa().ToString() + "\n";
            string inThuong = "In thường: " + at.chuyenChuThuong(at.amTiet) + "\n";
            string inHoa = "In hoa: " + at.chuyenChuHoa(at.amTiet) + "\n";
            string xoaPhuAmDau = "Xóa phụ âm đầu: " + at.xoaPhuAmDau() + "\n";
            string xoaPhuAmCuoi = "Xóa phụ âm cuối: " + at.xoaPhuAmCuoi() + "\n";
            string xoaNguyenAm = "Xóa nguyên âm: " + at.xoaNguyenAm() + "\n";
            string layTungPhuAmDau = "Tách nguyên âm đầu: " + chuyenMangSangChuoi(at.layTungPhuAm(at.phuAmDau)) + "\n";
            string layTungNguyenAm = "Tách từng nguyên âm: " + chuyenMangSangChuoi(at.layTungNguyenAm(at.nguyenAm)) + "\n";
            string layTungPhuAmCuoi = "Tách từng phụ âm cuối: " + chuyenMangSangChuoi(at.layTungPhuAm(at.phuAmCuoi)) + "\n";

            result += input + KtTiengViet + khongDau + layPhuAmDau + layNguyenAm + layphuAmCuoi + layDau +
                    kiemTraInThuong + kiemTraInHoa + inThuong + inHoa + xoaPhuAmDau + xoaPhuAmCuoi +
                    xoaNguyenAm + layTungPhuAmDau + layTungPhuAmCuoi + layTungNguyenAm;
            richTextBox1.Text = result;
        }

        private string chuyenMangSangChuoi(string[] arr)
        {
            string str = "";
            for (int i = 0;i < arr.Length;i++)
            {
                str += arr[i] + ",";
            }
            if (str.Length != 0)
            str.Remove(str.Length - 1, 1);
            return str;
        }
    }
}

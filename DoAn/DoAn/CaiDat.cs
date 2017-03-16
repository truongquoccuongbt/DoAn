using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAn
{
    class CaiDat : TuVung
    {

        public CaiDat() : base() { }

        public CaiDat(String tu) : base(tu) { }


        public override string ChuyenChuHoa()
        {
            string tam = "";
            String[] mangKiTu = new String[]
            {
                "aA","ăĂ","âÂ","bB","cC","dD","đĐ","eE",
                "êÊ", "gG","hH","iI","kK","lL","mM","nN",
                "oO","ôÔ","ơƠ","pP","qQ","rR","sS","tT",
                "uU","ưƯ","vV","xX","yY"
            };

            for (int i = 0;i < this.tu.Length;i++)
            {
                for (int j = 0; j < mangKiTu.Length;j++)
                {
                    if (this.tu[i] == mangKiTu[j][0])
                    {
                        tam += mangKiTu[j][1];
                    }
                }
            }
            return tam;
        }

        public override string ChuyenChuThuong()
        {
            string tam = "";
            String[] mangKiTu = new String[]
            {
                "aA","ăĂ","âÂ","bB","cC","dD","đĐ","eE",
                "êÊ", "gG","hH","iI","kK","lL","mM","nN",
                "oO","ôÔ","ơƠ","pP","qQ","rR","sS","tT",
                "uU","ưƯ","vV","xX","yY"
            };

            for (int i = 0;i < this.tu.Length;i++)
            {
                for (int j = 0; j < mangKiTu.Length;j++)
                {
                    if (this.tu[i] == mangKiTu[j][1])
                    {
                        tam += mangKiTu[j][0];
                    }
                }
            }
            return tam;
        }

        public override void PhanTich()
        {
            TachDauThanh();
            String[] str = new String[3];
            str = TachThanhPhan();
            this.phuAmDau = str[0];
            this.nguyenAm = str[1];
            this.phuAmCuoi = str[2];
        }

        public string PhucHoiDauThanh(String nguyenAm)
        {
            String[] mangKyTu = new String[]
           {
                "012345" ,
                "aáàảãạ" ,
                "AÁÀẢÃẠ" ,
                "ăắằẳẵặ" ,
                "ĂẮẰẲẴẶ" ,
                "âấầẩẫậ" ,
                "ÂÁẦẨẪẬ" ,
                "eéèẻẽẹ" ,
                "EÉÈẺẼẸ" ,
                "êếềểễệ" ,
                "ÊẾỀỂỄỆ" ,
                "iíìỉĩị" ,
                "IÍÌỈĨỊ" ,
                "oóòỏõọ" ,
                "OÓÒỎÕỌ" ,
                "ôốồổỗộ" ,
                "ÔỐỒỔỖỘ" ,
                "ơớờởỡợ" ,
                "ƠỚỜỞỠỢ" ,
                "uúùủũụ" ,
                "UÚÙỦŨỤ" ,
                "ưứừửữự" ,
                "ƯỨỪỬỮỰ" ,
                "yýỳỷỹỵ" ,
                "YÝỲỶỸỴ"
           };
            int kiHieuDau = TimKiHieuDau(this.dau);
            String chuoi = nguyenAm;
            if (nguyenAm.Length == 1)
            {
                for (int i = 1;i < mangKyTu.Length;i++)
                {
                    if (mangKyTu[i][0].Equals(chuoi[0]))
                    {
                        chuoi = chuoi.Replace(chuoi[0], mangKyTu[i][kiHieuDau]);
                    }
                }
            }
            else if (nguyenAm.Length == 2)
            {
                if (nguyenAm[0] == 'o' || nguyenAm[0] == 'O' || nguyenAm[0] == 'u' || nguyenAm[0] == 'U' ||
                    nguyenAm[0] == 'ư' || nguyenAm[0] == 'Ư' || nguyenAm[0] == 'ơ' || nguyenAm[0] == 'Ơ')
                {
                    for (int i = 1;i < mangKyTu.Length;i++)
                    {
                        if (mangKyTu[i][0].Equals(chuoi[1]))
                        {
                            chuoi = chuoi = chuoi.Replace(chuoi[1],mangKyTu[i][kiHieuDau]);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < mangKyTu.Length; i++)
                    {
                        if (mangKyTu[i][0].Equals(nguyenAm[0]))
                        {
                            chuoi = chuoi.Replace(chuoi[0], mangKyTu[i][kiHieuDau]);
                        }
                    }
                }
            }
            else
            {
                if (chuoi[2] != 'ê')
                {
                    for (int i = 1; i < mangKyTu.Length; i++)
                    {
                        if (mangKyTu[i][0].Equals(nguyenAm[1]))
                        {
                            chuoi = chuoi.Replace(chuoi[1], mangKyTu[i][kiHieuDau]);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < mangKyTu.Length; i++)
                    {
                        if (mangKyTu[i][0].Equals(nguyenAm[2]))
                        {
                            chuoi = chuoi.Replace(chuoi[2], mangKyTu[i][kiHieuDau]);
                        }
                    }
                }
            }
            return chuoi;
        }

        public override string TachDauThanh()
        {
            String[] mangKyTu = new String[]
            {
                "012345" ,
                "aáàảãạ" ,
                "AÁÀẢÃẠ" ,
                "ăắằẳẵặ" ,
                "ĂẮẰẲẴẶ" ,
                "âấầẩẫậ" ,
                "ÂÁẦẨẪẬ" ,
                "eéèẻẽẹ" ,
                "EÉÈẺẼẸ" ,
                "êếềểễệ" ,
                "ÊẾỀỂỄỆ" ,
                "iíìỉĩị" ,
                "IÍÌỈĨỊ" ,
                "oóòỏõọ" ,
                "OÓÒỎÕỌ" ,
                "ôốồổỗộ" ,
                "ÔỐỒỔỖỘ" ,
                "ơớờởỡợ" ,
                "ƠỚỜỞỠỢ" ,
                "uúùủũụ" ,
                "UÚÙỦŨỤ" ,
                "ưứừửữự" ,
                "ƯỨỪỬỮỰ" ,
                "yýỳỷỹỵ" ,
                "YÝỲỶỸỴ"
            };

            string tmp;
            string tu = this.tu;
            for (int i = 1; i < mangKyTu.Length; i++)
            {
                for (int j = 0; j < mangKyTu[i].Length; j++)
                {
                    tmp = tu.Replace(mangKyTu[i][j], mangKyTu[i][0]);
                    if (!tu.Equals(tmp))
                    {
                        this.dau = XacDinhDau(j);
                    }
                    tu = tmp;
                }
            }
            if (dau == null) this.dau = String.Empty;
            return tu;
        }

        public override string[] TachThanhPhan()
        {
            string tu = TachDauThanh();
            string[] tam = new string[3];
            String str_phuAmDau = "^(?<a>ch|gh|gi|kh|ngh|ng|nh|ph|qu|th|tr|b|c|d|đ|g|h|k|l|m|n|p|q|r|s|t|v|x|";
            String str_phuAmDauHoa = "Ch|Gh|Gi|Kh|Ng|Ngh|Nh|Ph|Qu|Th|Tr|B|C|D|Đ|G|H|K|L|M|N|P|Q|R|S|T|V|X)?";
            String str_nguyenAmDon = "a|ă|â|e|ê|i|y|o|ô|ơ|u|ư|A|Ă|Â|E|Ê|I|Y|O|Ô|Ơ|U|Ư)?";
            String str_nguyenAmDoi = "ai|ao|au|âu|ay|ây|eo|êu|ia|iê|yê|iu|oa|oă|oe|oi|ôi|ơi|oo|ôô|ua|uă|uâ|ưa|uê|ui|ưi|uo|uô|uơ|ươ|ưu|uy|";
            String str_nguyenAmBaHoa = "Iêu|Yêu|Oai|Oao|Oay|Oeo|Uao|Uây|Uôi|Ươi|Ươu|Uya|Uyê|Uyu|";
            String str_nguyenAmBa = "(?<b>iêu|yêu|oai|oao|oay|oeo|uao|uây|uôi|ươi|ươu|uya|uyê|uyu|";
            String str_phuAmCuoi = "(?<c>ch|gh|ng|nh|ph|m|n)?";
            String str_nguyenAm = str_nguyenAmBa + str_nguyenAmBaHoa + str_nguyenAmDoi + str_nguyenAmDon;
            Regex regex = new Regex(str_phuAmDau + str_phuAmDauHoa + str_nguyenAm + str_phuAmCuoi);
            Match match = regex.Match(tu);
            if (regex.IsMatch(tu))
            {
                tam[0] = match.Groups["a"].Value;
                tam[1] = match.Groups["b"].Value;
                tam[2] = match.Groups["c"].Value;
            }
            return tam;
        }

        public override string XoaNguyenAm()
        {
            this.nguyenAm = String.Empty;
            this.tu = this.phuAmDau + this.phuAmCuoi;
            return this.tu;
        }

        public override string XoaPhuAmCuoi()
        {
            this.phuAmCuoi = String.Empty;
            this.tu = this.phuAmDau + PhucHoiDauThanh(this.nguyenAm);
            return this.tu;
        }

        public override string XoaPhuAmDau()
        {
            this.phuAmDau = String.Empty;
            this.tu = PhucHoiDauThanh(this.nguyenAm) + this.phuAmCuoi;
            return this.tu; 
        }

        public override string XoaTatCaDau()
        {
            String[] mangKyTu = new String[]
           {
                "aáàảãạăắằẳẵặâấầẩẫậ" ,
                "AÁÀẢÃẠĂẮẰẲẴẶÂÁẦẨẪẬ" ,
                "eéèẻẽẹêếềểễệ" ,
                "EÉÈẺẼẸÊẾỀỂỄỆ" ,
                "iíìỉĩị" ,
                "IÍÌỈĨỊ" ,
                "oóòỏõọôốồổỗộơớờởỡợ" ,
                "OÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢ" ,
                "uúùủũụưứừửữự" ,
                "UÚÙỦŨỤƯỨỪỬỮỰ" ,
                "dđ" ,
                "DĐ",
                "yýỳỷỹỵ" ,
                "YÝỲỶỸỴ"
           };

            string tam = "";
            for (int i = 0; i < mangKyTu.Length; i++)
            {
                for (int j = 0; j < mangKyTu[i].Length; j++)
                {
                    tam = this.tu.Replace(mangKyTu[i][j], mangKyTu[i][0]);
                    this.tu = tam;
                }
            }
            return this.tu;
        }

        public override string ChuyenUnicodeToUTF8()
        {
            byte[] utf16 = Encoding.Unicode.GetBytes(this.tu);
            byte[] utf8 = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf16);
            string strutf8 = "";

            for (int i = 0;i < utf8.Length;i++)
            {
                byte[] tam = new byte[2] { utf8[i], 0 };
                strutf8 += BitConverter.ToChar(tam, 0);
            }

            return strutf8;
        }

        public override string ChuyenUTF8ToUniCode()
        {
            byte[] utf8 = Encoding.UTF8.GetBytes(this.tu);
            byte[] utf16 = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8); // lần 1
            byte[] u = new byte[utf16.Length / 2];
            string strUtf16 = "";
            int j = 0;
            for (int i = 0;i < utf16.Length; i++)
            {
                u[j] = utf16[i];
                byte[] tam = new byte[2] { utf16[i], utf16[i + 1] };
                strUtf16 += BitConverter.ToChar(tam,0);
                i++;
                j++;
            }

            byte[] cv = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, u); // lần 2
            return Encoding.Unicode.GetString(cv);
        }

        private string XacDinhDau(int kihieudau)
        {
            string kq;
            switch (kihieudau)
            {
                case 1:
                    kq = "S";
                    break;
                case 2:
                    kq = "F";
                    break;
                case 3:
                    kq = "R";
                    break;
                case 4:
                    kq = "X";
                    break;
                case 5:
                    kq = "J";
                    break;
                default:
                    kq = String.Empty;
                    break;
            }
            return kq;
        }

        private int TimKiHieuDau(string dau)
        {
            if (dau.Equals("S"))
            {
                return 1;
            }
            else if (dau.Equals("F"))
            {
                return 2;
            }
            else if (dau.Equals("R"))
            {
                return 3;
            }
            else if (dau.Equals("X"))
            {
                return 4;
            }
            else if (dau.Equals("J"))
            {
                return 5;
            }
             return 0; 
        }
    }
}

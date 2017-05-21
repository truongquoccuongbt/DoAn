using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAn
{
    class CaiDat : AmTiet
    {

        public CaiDat() : base() { }

        public CaiDat(String am) : base(am) { }

        public override string chuyenChuHoa(string am_tiet)
        {
            string tam = "";
            String[] mangKiTu = new String[]
            {
                "aA","áÁ","àÀ","ảẢ","ãÃ","ạẠ",
                "ăĂ","ắẮ","ằẰ","ẳẲ","ẵẴ","ặẶ",
                "âÂ","ấẤ","ầẦ","ẩẨ","ẫẪ","ậẬ",
                "bB","cC","dD","đĐ",
                "eE","éÉ","èÈ","ẻẺ","ẽẼ","ẹẸ",
                "êÊ","ếẾ","ềỀ","ểỂ","ễỄ","ệỆ",
                "gG","hH","iI","kK","lL","mM","nN",
                "oO","óÓ","òÒ","ỏỎ","õÕ","ọỌ",
                "ôÔ","ốỐ","ồỒ","ổỔ","ỗỖ","ộỘ",
                "ơƠ","ớỚ","ờỜ","ởỞ","ỡỠ","ợỢ",
                "pP","qQ","rR","sS","tT",
                "uU","úÚ","ùÙ","ủỦ","ũŨ","ụỤ",
                "ưƯ","ứỨ","ừỪ","ửỬ","ữỮ","ựỰ",
                "vV","xX","yY"
            };

            for (int i = 0;i < am_tiet.Length;i++)
            {
                for (int j = 0; j < mangKiTu.Length;j++)
                {
                    if (am_tiet[i] == mangKiTu[j][0])
                    {
                        tam += mangKiTu[j][1];
                    }
                    if (am_tiet[i] == mangKiTu[j][1])
                    {
                        tam += am_tiet[i];
                    }
                }
            }
            return (!tam.Equals("")) ? tam : am_tiet;
        }

        public override string chuyenChuThuong(string am_tiet)
        {
            string tam = "";
            String[] mangKiTu = new String[]
             {
                "aA","áÁ","àÀ","ảẢ","ãÃ","ạẠ",
                "ăĂ","ắẮ","ằẰ","ẳẲ","ẵẴ","ặẶ",
                "âÂ","ấẤ","ầẦ","ẩẨ","ẫẪ","ậẬ",
                "bB","cC","dD","đĐ",
                "eE","éÉ","èÈ","ẻẺ","ẽẼ","ẹẸ",
                "êÊ","ếẾ","ềỀ","ểỂ","ễỄ","ệỆ",
                "gG","hH","iI","kK","lL","mM","nN",
                "oO","óÓ","òÒ","ỏỎ","õÕ","ọỌ",
                "ôÔ","ốỐ","ồỒ","ổỔ","ỗỖ","ộỘ",
                "ơƠ","ớỚ","ờỜ","ởỞ","ỡỠ","ợỢ",
                "pP","qQ","rR","sS","tT",
                "uU","úÚ","ùÙ","ủỦ","ũŨ","ụỤ",
                "ưƯ","ứỨ","ừỪ","ửỬ","ữỮ","ựỰ",
                "vV","xX","yY"
             };

            for (int i = 0;i < am_tiet.Length;i++)
            {
                for (int j = 0; j < mangKiTu.Length;j++)
                {
                    if (am_tiet[i] == mangKiTu[j][1])
                    {
                        tam += mangKiTu[j][0];
                    }
                    if (am_tiet[i] == mangKiTu[j][0])
                    {
                        tam += am_tiet[i];
                    }
                }
            }
            return (!tam.Equals("")) ? tam : am_tiet;
        }

        public override void phanTich()
        {
            tachDauThanh();
            String[] str = new String[3];
            str = tachThanhPhan();
            this.phuAmDau = str[0];
            this.nguyenAm = str[1];
            this.phuAmCuoi = str[2];
        }

        private string phucHoiDauThanh(String nguyenAm, string dau)
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
            int kiHieuDau = timKiHieuDau(dau);
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

        public override string tachDauThanh()
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
            string tu = this.am_tiet;
            for (int i = 1; i < mangKyTu.Length; i++)
            {
                for (int j = 0; j < mangKyTu[i].Length; j++)
                {
                    tmp = tu.Replace(mangKyTu[i][j], mangKyTu[i][0]);
                    if (!tu.Equals(tmp))
                    {
                        this.dau = xacDinhDau(j);
                    }
                    tu = tmp;
                }
            }
            if (dau == null) this.dau = "N";
            return tu;
        }

        public override string[] tachThanhPhan()
        {  
            string tu = tachDauThanh();
            bool flag = false;
            if (kiemTraInHoa())
            {
                flag = true;
                tu = chuyenChuThuong(tu);

            }
            string[] tam = new string[3];
            String str_phuAmDau = "|ch|gh|gi|kh|ngh|ng|nh|ph|th|tr|b|c|d|đ|g|h|k|l|m|n|p|q|r|s|t|v|x|)?";
            String str_phuAmDauHoa = "^(?<a>Ch|Gh|G|Kh|Ngh|Ng|Nh|Ph|Qu|Th|Tr|B|C|D|Đ|G|H|K|L|M|N|P|Q|R|S|T|V|X";
            String str_nguyenAmDon = "|a|ă|â|e|ê|i|y|o|ô|ơ|u|ư|A|Ă|Â|E|Ê|I|Y|O|Ô|Ơ|U|Ư)?";
            String str_nguyenAmDoi = "ai|ao|au|âu|ay|ây|eo|êu|ia|iê|yê|iu|oa|oă|oe|oi|ôi|ơi|oo|ôô|ua|uă|uâ|ưa|uê|ui|ưi|uo|uô|uơ|ươ|ưu|uy|iô";
            String str_nguyenAmBaHoa = "Iêu|Yêu|Oai|Oao|Oay|Oeo|Uao|Uây|Uôi|Ươi|Ươu|Uya|Uyê|Uyu|";
            String str_nguyenAmBa = "(?<b>iêu|yêu|oai|oao|oay|oeo|uao|uây|uôi|ươi|ươu|uya|uyê|uyu|";
            String str_phuAmCuoi = "(?<c>ch|ng|nh|m|n|t|c|p|)?";
            String str_nguyenAm = str_nguyenAmBa + str_nguyenAmBaHoa + str_nguyenAmDoi + str_nguyenAmDon;
            Regex regex = new Regex(str_phuAmDauHoa + str_phuAmDau + str_nguyenAm + str_phuAmCuoi);
            Match match = regex.Match(tu);
            if (regex.IsMatch(tu))
            {   
                tam[0] = match.Groups["a"].Value;
                tam[1] = match.Groups["b"].Value;
                tam[2] = match.Groups["c"].Value;
            }
            if (flag)
            {
                for (int i = 2;i >= 0;i--)
                {
                    tam[i] = chuyenChuHoa(tam[i]);
                }
            }
            return tam;
        }

        public override string xoaNguyenAm()
        {
            string ketqua = "";
            ketqua = this.phuAmDau + this.phuAmCuoi;
            return ketqua;
        }

        public override string xoaPhuAmCuoi()
        {
            string ketqua = "";
            ketqua = this.phuAmDau + phucHoiDauThanh(this.nguyenAm, this.dau);
            return ketqua;
        }

        public override string xoaPhuAmDau()
        {
            string ketqua = "";
            ketqua = phucHoiDauThanh(this.nguyenAm, this.dau) + this.phuAmCuoi;
            return ketqua; 
        }

        public override string xoaTatCaDau()
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
            string tu = this.am_tiet;
            for (int i = 0; i < mangKyTu.Length; i++)
            {
                for (int j = 0; j < mangKyTu[i].Length; j++)
                {
                    tu = tu.Replace(mangKyTu[i][j], mangKyTu[i][0]);
                }
                tam = tu;
            }
            return tam;
        }

        public override string chuyenUnicodeToUTF8()
        {
            byte[] utf16 = Encoding.Unicode.GetBytes(this.am_tiet);
            byte[] utf8 = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf16);
            string strutf8 = "";

            for (int i = 0;i < utf8.Length;i++)
            {
                byte[] tam = new byte[2] { utf8[i], 0 };
                strutf8 += BitConverter.ToChar(tam, 0);
            }

            return strutf8;
        }  // nghi vấn

        public override string chuyenUTF8ToUniCode()
        {
            byte[] utf8 = Encoding.UTF8.GetBytes(this.am_tiet);
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
        } // nghi vấn

        private string xacDinhDau(int kihieudau)
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
                    kq = "N";
                    break;
            }
            return kq;
        }

        private int timKiHieuDau(string dau)
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

        public override string[] layTungNguyenAm(string nguyenAm)
        {
            string[] mangkitu = new string[nguyenAm.Length];
            for (int i = 0; i < nguyenAm.Length; i++)
            {
                mangkitu[i] = nguyenAm[i].ToString();
            }
            return mangkitu;
        }

        public override bool kiemTraAmTiengViet()
        {
            
            if (this.phu_am_dau == String.Empty && this.nguyen_am == String.Empty && this.phu_am_dau == String.Empty)
            {
                return false;
            }

            if (this.am_tiet.Length != (this.phu_am_dau.Length + this.nguyenAm.Length + this.phu_am_cuoi.Length))
            {
                return false;
            }
       
            if (!kiemTraPhuAmDau(this.phu_am_dau) || !kiemTraNguyenAm(this.nguyen_am) || !kiemTraPhuAmCuoi(this.phu_am_cuoi))
            {
                return false;
            }
            if (!kiemTraAmViCoNghia(this.am_tiet))
            {
                return false;
            }
            return true;
        }

        private bool kiemTraPhuAmDau(string phuAm)
        {
           
            phuAm = chuyenChuThuong(phuAm);

            if (phuAm == "") return true;
            string phuAmDon = "bcdđghklmnpqrstvxBCDĐGHKLMNPQRSTVX";
            string[] phuAmDoi = new string[]
            {
                "ch","gh","gi","kh","ng","nh","ph","qu","th","tr",
                "Ch","Gh","Gi","Kh","Ng","Nh","Ph","Qu","Th","Tr"
            };

            if (phuAm.Length == 1)
            {
                for (int i = 0; i < phuAmDon.Length; i++)
                {
                    if (phuAm.Equals(phuAmDon[i].ToString())) 
                    {
                        return true;
                    }
                }
                return false;
            }
            else if (phuAm.Length == 2)
            {
                for (int i = 0; i < phuAmDoi.Length; i++)
                {
                    if (phuAm == phuAmDoi[i])
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                if (!phuAm.Equals("ngh"))
                {
                    return false;
                }
            }
            return true;
        }

        private bool kiemTraPhuAmCuoi(string phuAm)
        {
            if (kiemTraInHoa())
            {
                phuAm = chuyenChuThuong(phuAm);
            }

            if (phuAm == "") return true;
            string[] phuAmCuoi = new string[]
            {
                "m","n","nh","ch","ng","t","c","p"
            };
            for (int i = 0;i < phuAmCuoi.Length;i++)
            {
                if (phuAm.Equals(phuAmCuoi[i])) 
                {
                    return true; 
                }
            }
            return false;
        }

        private bool kiemTraNguyenAm(string nguyenAm)
        {
            if (kiemTraInHoa())
            {
                nguyenAm = chuyenChuThuong(nguyenAm);
            }

            string[] nguyenAmDon = new string[]
            {
                "a","ă","â","e","ê","i","y","o","ô","ơ","u","ư"
            };
            string[] nguyenAmDoi = new string[]
            {
                "ai","ao","au","âu","ây","eo","êu","ia","iê","yê","ay","ây",
                "iu","oa","oă","oe","oi","ôi","ơi","oo","ôô","ua","uă",
                "uâ","ưa","uê","ui","ưi","uo","uô","uơ","ươ","ưu","uy"
            };
            string[] nguyenAmBa = new string[]
            {
                "iêu","yêu","oai","oao","oay","oeo","uao","uây","uôi","ươi",
                "ươu","uya","uyê","uyu"
            };

            if (nguyenAm.Length == 1)
            {
                for (int i = 0;i < nguyenAmDon.Length;i++)
                {
                    if (nguyenAm.Equals(nguyenAmDon[i]))
                    {
                        return true;
                    }
                }
            }
            else if (nguyenAm.Length == 2)
            {
                for (int i = 0;i < nguyenAmDoi.Length;i++)
                {
                    if (nguyenAm.Equals(nguyenAmDoi[i]))
                    {
                        return true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < nguyenAmBa.Length; i++)
                {
                    if (nguyenAm.Equals(nguyenAmBa[i]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override bool kiemTraInHoa()
        {
            string inHoa = chuyenChuHoa(this.am_tiet);

            int soHoa = 0;
            int soAmTiet = 0;
            for (int i = 0;i < inHoa.Length;i++)
            {
                soHoa += inHoa[i] + '0';
                soAmTiet += this.am_tiet[i] + '0';
            }

            if (soAmTiet == soHoa) return true;

            return false;
        }

        public override bool kiemTraInThuong()
        {
            string inThuong = chuyenChuThuong(this.am_tiet);

            int soThuong = 0;
            int soAmTiet = 0;
            for (int i = 0; i < inThuong.Length; i++)
            {
                soThuong += inThuong[i] + '0';
                soAmTiet += this.am_tiet[i] + '0';
            }

            if (soThuong == soAmTiet) return true;
            return false;
        }

        public override string[] layTungPhuAm(string phu_am)
        {
            string[] str = new string[phu_am.Length];
            for (int i = 0;i < phu_am.Length;i++)
            {
                str[i] = phu_am[i].ToString();
            }
            return str;
        }

        private bool kiemTraAmViCoNghia (string am_tiet)
        {
            am_tiet = chuyenChuThuong(am_tiet);
            var key = tu_dien.FirstOrDefault(x => x.Key == am_tiet).Key;
        
            if (key == null)
            {
                return false;
            }
            return true;
        }

        public override AmTiet ghepTu(string phu_am_dau, string nguyen_am, string phu_am_cuoi, string dau)
        {
            string nguyen_am_dau = phucHoiDauThanh(nguyen_am, dau);
            string tu_moi = phu_am_dau + nguyen_am_dau + phu_am_cuoi;
            this.am_tiet = tu_moi;
            this.phu_am_dau = phu_am_dau;
            this.nguyen_am = nguyen_am;
            this.phu_am_cuoi = phu_am_cuoi;
            this.dau_thanh = dau;
            if (this.kiemTraAmTiengViet())
            {
                return this;
            }
            else
            {
                this.am_tiet = String.Empty;
                this.phu_am_dau = String.Empty;
                this.nguyen_am = String.Empty;
                this.phu_am_cuoi = String.Empty;
                this.dau_thanh = String.Empty;
                throw new Exception("Đây không phải tiếng Việt");
            }
        }
    }
}

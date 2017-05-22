using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAn
{
    class AmVi
    {
        private AmTiet am_tiet;
        private String phien_am;
        private Dictionary<String, String[]> phien_am_phu_am_dau = new Dictionary<String, String[]>();
        private Dictionary<String, String[]> phien_am_phu_am_cuoi = new Dictionary<String, String[]>();
        private Dictionary<String, String[]> phien_am_nguyen_am = new Dictionary<String, String[]>();

        public AmTiet Am_tiet
        {
            get
            {
                return am_tiet;
            }

            set
            {
                am_tiet = value;
            }
        }

        public string Phien_am
        {
            get
            {
                return phien_am;
            }

            set
            {
                phien_am = value;
            }
        }

        public AmVi()
        {
            am_tiet = new CaiDat();
            phien_am = String.Empty;
            khoiTaoDanhSachPhienAm();
        }

        public AmVi(String tu)
        {
            this.am_tiet = new CaiDat(tu);
            this.phien_am = String.Empty;
            khoiTaoDanhSachPhienAm();
        }

        private void khoiTaoDanhSachPhienAm()
        {
            // Phien am cua phu am
            phien_am_phu_am_dau.Add("b", new String[] { "b" });
            phien_am_phu_am_dau.Add("c", new String[] { "c" });
            phien_am_phu_am_dau.Add("ch", new String[] { "ch" });
            phien_am_phu_am_dau.Add("d", new String[] { "d" });
            phien_am_phu_am_dau.Add("đ", new String[] { "dd" });
            phien_am_phu_am_dau.Add("g", new String[] { "g" });
            phien_am_phu_am_dau.Add("gh", new String[] { "g" });
            phien_am_phu_am_dau.Add("gi", new String[] { "d" });
            phien_am_phu_am_dau.Add("h", new String[] { "h" });
            phien_am_phu_am_dau.Add("k", new String[] { "k" });
            phien_am_phu_am_dau.Add("kh", new String[] { "kh" });
            phien_am_phu_am_dau.Add("l", new String[] { "l" });
            phien_am_phu_am_dau.Add("m", new String[] { "m" });
            phien_am_phu_am_dau.Add("n", new String[] { "n" });
            phien_am_phu_am_dau.Add("ng", new String[] { "ng" });
            phien_am_phu_am_dau.Add("ngh", new String[] { "ngh" });
            phien_am_phu_am_dau.Add("nh", new String[] { "nh" });
            phien_am_phu_am_dau.Add("p", new String[] { "p" });
            phien_am_phu_am_dau.Add("ph", new String[] { "ph" });
            phien_am_phu_am_dau.Add("qu", new String[] { "kw" });
            phien_am_phu_am_dau.Add("r", new String[] { "r" });
            phien_am_phu_am_dau.Add("s", new String[] { "s" });
            phien_am_phu_am_dau.Add("t", new String[] { "t" });
            phien_am_phu_am_dau.Add("th", new String[] { "th" });
            phien_am_phu_am_dau.Add("tr", new String[] { "tr" });
            phien_am_phu_am_dau.Add("v", new String[] { "v" });
            phien_am_phu_am_dau.Add("x", new String[] { "x" });

            // Phien am cua nguyen am
            phien_am_nguyen_am.Add("a", new String[] { "a", "ea" });
            phien_am_nguyen_am.Add("ă", new String[] { "aw" });
            phien_am_nguyen_am.Add("â", new String[] { "aa" });
            phien_am_nguyen_am.Add("e", new String[] { "e" });
            phien_am_nguyen_am.Add("ê", new String[] { "ee" });
            phien_am_nguyen_am.Add("i", new String[] { "i" });
            phien_am_nguyen_am.Add("y", new String[] { "i" });
            phien_am_nguyen_am.Add("o", new String[] { "o", "oa" });
            phien_am_nguyen_am.Add("ô", new String[] { "oo" });
            phien_am_nguyen_am.Add("ơ", new String[] { "ow" });
            phien_am_nguyen_am.Add("u", new String[] { "u" });
            phien_am_nguyen_am.Add("ư", new String[] { "uw" });
            phien_am_nguyen_am.Add("ai", new String[] { "aiz" });
            phien_am_nguyen_am.Add("ao", new String[] { "auz" });
            phien_am_nguyen_am.Add("au", new String[] { "auz" });
            phien_am_nguyen_am.Add("âu", new String[] { "aauz" });
            phien_am_nguyen_am.Add("ay", new String[] { "awiz" });
            phien_am_nguyen_am.Add("ây", new String[] { "aaiz" });
            phien_am_nguyen_am.Add("eo", new String[] { "euz" });
            phien_am_nguyen_am.Add("êu", new String[] { "eeuz" });
            phien_am_nguyen_am.Add("ia", new String[] { "ie" });
            phien_am_nguyen_am.Add("iê", new String[] { "ie" });
            phien_am_nguyen_am.Add("yê", new String[] { "ie" });
            phien_am_nguyen_am.Add("iu", new String[] { "iuz" });
            phien_am_nguyen_am.Add("oa", new String[] { "wa" });
            phien_am_nguyen_am.Add("oă", new String[] { "waw" });
            phien_am_nguyen_am.Add("oe", new String[] { "we" });
            phien_am_nguyen_am.Add("oi", new String[] { "oiz" });
            phien_am_nguyen_am.Add("ôi", new String[] { "ooiz" });
            phien_am_nguyen_am.Add("ơi", new String[] { "owiz" });
            phien_am_nguyen_am.Add("ua", new String[] { "uo" });
            phien_am_nguyen_am.Add("uâ", new String[] { "waa" });
            phien_am_nguyen_am.Add("ưa", new String[] { "wa" });
            phien_am_nguyen_am.Add("uê", new String[] { "wee" });
            phien_am_nguyen_am.Add("ui", new String[] { "uiz" });
            phien_am_nguyen_am.Add("ưi", new String[] { "uwiz" });
            phien_am_nguyen_am.Add("uô", new String[] { "uo" });
            phien_am_nguyen_am.Add("uơ", new String[] { "wow" });
            phien_am_nguyen_am.Add("ươ", new String[] { "wa" });
            phien_am_nguyen_am.Add("ưu", new String[] { "uwuz" });
            phien_am_nguyen_am.Add("uy", new String[] { "wi" });
            phien_am_nguyen_am.Add("iêu", new String[] { "ieuz" });
            phien_am_nguyen_am.Add("yêu", new String[] { "ieuz" });
            phien_am_nguyen_am.Add("oai", new String[] { "waiz" });
            phien_am_nguyen_am.Add("oay", new String[] { "wawiz" });
            phien_am_nguyen_am.Add("oeo", new String[] { "weuz" });
            phien_am_nguyen_am.Add("uây", new String[] { "waaiz" });
            phien_am_nguyen_am.Add("uôi", new String[] { "uoiz" });
            phien_am_nguyen_am.Add("ươi", new String[] { "waiz" });
            phien_am_nguyen_am.Add("ươu", new String[] { "wauz" });
            phien_am_nguyen_am.Add("uya", new String[] { "wie" });
            phien_am_nguyen_am.Add("uyê", new String[] { "wie" });
            phien_am_nguyen_am.Add("uyu", new String[] { "wiuz" });

            // Phien am phu am cuoi
            phien_am_phu_am_cuoi.Add("ch", new String[] { "kc" });
            phien_am_phu_am_cuoi.Add("ng", new String[] { "ngz" });
            phien_am_phu_am_cuoi.Add("nh", new String[] { "ngz" });
            phien_am_phu_am_cuoi.Add("m", new String[] { "mz" });
            phien_am_phu_am_cuoi.Add("n", new String[] { "nz" });
            phien_am_phu_am_cuoi.Add("t", new String[] { "tc" });
            phien_am_phu_am_cuoi.Add("c", new String[] { "kc" });
            phien_am_phu_am_cuoi.Add("p", new String[] { "pc" });
        }

        public String[] timPhienAm(Dictionary<String,String[]> ds, String key)
        {
            var giaTri = ds.FirstOrDefault(x => x.Key == key).Value;
            if (giaTri == null)
            {
                return null;
            }
            return giaTri;
        }

        public String ChuyenSangPhienAm()
        {
            string phuAmDau = timPhienAm(phien_am_phu_am_dau , am_tiet.chuyenChuThuong(am_tiet.phuAmDau))[0] + " ";
            string nguyenAm = timPhienAm(phien_am_nguyen_am, am_tiet.chuyenChuThuong(am_tiet.nguyenAm))[0] + " ";
            string phuAmCuoi = timPhienAm(phien_am_phu_am_cuoi, am_tiet.chuyenChuThuong(am_tiet.phuAmCuoi))[0] + " ";
            return phuAmDau + nguyenAm + phuAmCuoi;
        }

        private String[] TachPhienAm(String phienAm)
        {
            string[] tam = new string[3];
            String str_phuAmDau = "^(?<a>ngh|ch|dd|kw|kh|ng|ph|th|l|m|n|nh|p|k|r|s|t|tr|v|d|x|c|g|h)?";
            String str_nguyenAmBa = "(?<b>ieuz|waiz|wawiz|weuz|waaiz|uoiz|wauz|wie|wiuz|";
            String str_nguyenAmDoi = "aiz|auz|aauz|awiz|aaiz|euz|eeuz|ie|iuz|wa|waw|we|oiz|ooiz|owiz|uo|waa|wa|wee|uiz|uwiz|wow|uwuz|wi|";
            String str_nguyenAmDon = "ea|aw|aa|ee|e|i|oa|oo|ow|o|uw|u|a)";
            String str_phuAmCuoi = "(?<c>kc|ngz|mz|nz|tc|kc|pc)?";

            Regex regex = new Regex(str_phuAmDau + str_nguyenAmBa + str_nguyenAmDoi + str_nguyenAmDon + str_phuAmCuoi);
            Match match = regex.Match(phienAm);
            if (regex.IsMatch(phienAm))
            {
                tam[0] = match.Groups["a"].Value;
                tam[1] = match.Groups["b"].Value;
                tam[2] = match.Groups["c"].Value;
            }
            return tam;
        }

        private String[] TimChu(Dictionary<String, String[]> ds, String phienAm)
        {
            String[] tam = new String[4];
            int j = 0;
            foreach (KeyValuePair<String, String[]> value in ds)
            {
                for (int i = 0; i < value.Value.Length; i++)
                {
                    if (value.Value[i] == phienAm)
                    {
                        tam[j] = value.Key;
                        j++;
                    }
                }
            }
            return tam;
        }

        public AmTiet ChuyenPhienAmSangAmTiet(string phienAm)
        {
            string[] tu = TachPhienAm(phienAm);
            string[] phuAmDau = TimChu( phien_am_phu_am_dau, tu[0]);
            string[] nguyenAm = TimChu(phien_am_nguyen_am, tu[1]);
            string[] phuAmCuoi = TimChu(phien_am_phu_am_cuoi, tu[2]);
          
            for (int i = 0;i < phuAmDau.Length; i++)
            {
                string tam = phuAmDau[i];
                for (int j = 0; j < nguyenAm.Length; j++)
                {
                    tam += nguyenAm[j];
                    for (int z = 0; z < phuAmCuoi.Length; z++)
                    {
                        tam += phuAmCuoi;
                        try
                        {
                            AmTiet at = new CaiDat(tam);
                            return at;
                        }
                        catch (Exception e)
                        {
                            continue;
                        }
                    }
                }
            }
            return null;
        }

    }
}

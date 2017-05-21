using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class AmVi
    {
        private AmTiet am_tiet;
        private String phien_am;
        private Dictionary<String, String[]> ds_phien_am = new Dictionary<String, String[]>();

        public AmVi()
        {
            am_tiet = new CaiDat();
            phien_am = String.Empty;
        }

        public AmVi(AmTiet am_tiet, String phien_am)
        {
            this.am_tiet = am_tiet;
            this.phien_am = phien_am;
        }

        private void khoiTaoDanhSachPhienAm()
        {
            // Phien am cua phu am
            ds_phien_am.Add("b", new String[] { "b" });
            ds_phien_am.Add("c", new String[] { "c" });
            ds_phien_am.Add("ch", new String[] { "ch" });
            ds_phien_am.Add("d", new String[] { "d" });
            ds_phien_am.Add("đ", new String[] { "dd" });
            ds_phien_am.Add("g", new String[] { "g" });
            ds_phien_am.Add("gh", new String[] { "g" });
            ds_phien_am.Add("d", new String[] { "gi" });
            ds_phien_am.Add("h", new String[] { "h" });
            ds_phien_am.Add("k", new String[] { "k" });
            ds_phien_am.Add("kh", new String[] { "kh" });
            ds_phien_am.Add("l", new String[] { "l" });
            ds_phien_am.Add("m", new String[] { "m" });
            ds_phien_am.Add("n", new String[] { "n" });
            ds_phien_am.Add("ng", new String[] { "ng" });
            ds_phien_am.Add("ngh", new String[] { "ngh" });
            ds_phien_am.Add("nh", new String[] { "nh" });
            ds_phien_am.Add("p", new String[] { "p" });
            ds_phien_am.Add("ph", new String[] { "ph" });
            ds_phien_am.Add("qu", new String[] { "kw" });
            ds_phien_am.Add("r", new String[] { "r" });
            ds_phien_am.Add("s", new String[] { "s" });
            ds_phien_am.Add("t", new String[] { "t" });
            ds_phien_am.Add("th", new String[] { "th" });
            ds_phien_am.Add("tr", new String[] { "tr" });
            ds_phien_am.Add("v", new String[] { "v" });
            ds_phien_am.Add("x", new String[] { "x" });

            // Phien am cua nguyen am
            ds_phien_am.Add("a", new String[] { "a", "ea" });
            ds_phien_am.Add("ă", new String[] { "aw" });
            ds_phien_am.Add("â", new String[] { "aa" });
            ds_phien_am.Add("e", new String[] { "e" });
            ds_phien_am.Add("ê", new String[] { "ee" });
            ds_phien_am.Add("i", new String[] { "i" });
            ds_phien_am.Add("y", new String[] { "i" });
            ds_phien_am.Add("o", new String[] { "o", "oa" });
            ds_phien_am.Add("ô", new String[] { "ô" });
            ds_phien_am.Add("ơ", new String[] { "ow" });
            ds_phien_am.Add("u", new String[] { "u" });
            ds_phien_am.Add("ư", new String[] { "uw" });
            ds_phien_am.Add("ai", new String[] { "aiz" });
            ds_phien_am.Add("ao", new String[] { "auz" });
            ds_phien_am.Add("au", new String[] { "auz" });
            ds_phien_am.Add("âu", new String[] { "aauz" });
            ds_phien_am.Add("ay", new String[] { "awiz" });
            ds_phien_am.Add("ây", new String[] { "aaiz" });
            ds_phien_am.Add("eo", new String[] { "euz" });
            ds_phien_am.Add("êu", new String[] { "eeuz" });
            ds_phien_am.Add("ia", new String[] { "ie" });
            ds_phien_am.Add("iê", new String[] { "ie" });
            ds_phien_am.Add("yê", new String[] { "ie" });
            ds_phien_am.Add("iu", new String[] { "iuz" });
            ds_phien_am.Add("oa", new String[] { "wa" });
            ds_phien_am.Add("oă", new String[] { "waw" });
            ds_phien_am.Add("oe", new String[] { "we" });
            ds_phien_am.Add("oi", new String[] { "oiz" });
            ds_phien_am.Add("ôi", new String[] { "ooiz" });
            ds_phien_am.Add("ơi", new String[] { "owiz" });
            ds_phien_am.Add("ua", new String[] { "uo" });
            ds_phien_am.Add("oi", new String[] { "oiz" });
            ds_phien_am.Add("uâ", new String[] { "waa" });
            ds_phien_am.Add("ưa", new String[] { "wa" });
            ds_phien_am.Add("uê", new String[] { "wee" });
            ds_phien_am.Add("ui", new String[] { "uiz" });
            ds_phien_am.Add("ưi", new String[] { "uwiz" });
            ds_phien_am.Add("uô", new String[] { "uo" });
            ds_phien_am.Add("uơ", new String[] { "wow" });
            ds_phien_am.Add("ươ", new String[] { "wa" });
            ds_phien_am.Add("ưu", new String[] { "uwuz" });
            ds_phien_am.Add("uy", new String[] { "wi" });
            ds_phien_am.Add("iêu", new String[] { "ieuz" });
            ds_phien_am.Add("yêu", new String[] { "ieuz" });
            ds_phien_am.Add("oai", new String[] { "waiz" });
            ds_phien_am.Add("oay", new String[] { "wawiz" });
            ds_phien_am.Add("oeo", new String[] { "weuz" });
            ds_phien_am.Add("uây", new String[] { "waaiz" });
            ds_phien_am.Add("uôi", new String[] { "uoiz" });
            ds_phien_am.Add("ươi", new String[] { "waiz" });
            ds_phien_am.Add("oi", new String[] { "oiz" });
            ds_phien_am.Add("ươu", new String[] { "wauz" });
            ds_phien_am.Add("uya", new String[] { "wie" });
            ds_phien_am.Add("uyê", new String[] { "wie" });
            ds_phien_am.Add("uyu", new String[] { "wiuz" });
        }

    }
}

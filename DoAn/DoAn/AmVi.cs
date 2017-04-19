using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class AmVi
    {
        private string phien_am;
        private static Dictionary<string,string> dsPhuAm_MB = new Dictionary<string, string>();
        private static Dictionary<string, string> dsPhuAm_MN = new Dictionary<string, string>();
        private static Dictionary<string, string> dsNguyenAm = new Dictionary<string, string>();
        private int vung_mien;
        public AmVi(string phien_am, int vung_mien)
        {
            this.phien_am = phien_am;
            this.vung_mien = vung_mien;
            khoiTaoDsAm();
        }

        private void khoiTaoDsAm()
        {
            // Miền Bắc
            dsPhuAm_MB.Add("/ɓ/", "b");
            dsPhuAm_MB.Add("/k/", "c");
            dsPhuAm_MB.Add("/t͡ɕ/", "ch");
            dsPhuAm_MB.Add("/z/", "d");
            dsPhuAm_MB.Add("/ɗ/", "đ");
            dsPhuAm_MB.Add("/ɣ/", "g");
            dsPhuAm_MB.Add("/z/", "g");
            dsPhuAm_MB.Add("/ɣ/", "gh");
            dsPhuAm_MB.Add("/z/", "gi");
            dsPhuAm_MB.Add("/h/", "h");
            dsPhuAm_MB.Add("/k/", "k");
            dsPhuAm_MB.Add("/x/", "kh");
            dsPhuAm_MB.Add("/l/", "l");
            dsPhuAm_MB.Add("/m/", "m");
            dsPhuAm_MB.Add("/n/", "n");
            dsPhuAm_MB.Add("/ŋ/", "ng");
            dsPhuAm_MB.Add("/ŋ/", "ngh");
            dsPhuAm_MB.Add("/ɲ/", "nh");
            dsPhuAm_MB.Add("/p/", "p");
            dsPhuAm_MB.Add("/ɓ/", "p");
            dsPhuAm_MB.Add("/f/", "ph");
            dsPhuAm_MB.Add("/k/", "q");
            dsPhuAm_MB.Add("/kw/", "qu");
            dsPhuAm_MB.Add("/z/", "r");
            dsPhuAm_MB.Add("/r/", "r");
            dsPhuAm_MB.Add("/s/", "s");
            dsPhuAm_MB.Add("/t/", "t");
            dsPhuAm_MB.Add("/tʰ/", "th");
            dsPhuAm_MB.Add("/t͡ɕ/", "tr");
            dsPhuAm_MB.Add("/v/", "v");
            dsPhuAm_MB.Add("/s/", "x");

            // Miền Nam
            dsPhuAm_MN.Add("/ɓ/", "b");
            dsPhuAm_MN.Add("/k/", "c");
            dsPhuAm_MN.Add("∅", "c");
            dsPhuAm_MN.Add("/c/", "ch");
            dsPhuAm_MN.Add("/j/", "d");
            dsPhuAm_MN.Add("/ɗ/", "đ");
            dsPhuAm_MN.Add("/ɣ/", "g");
            dsPhuAm_MN.Add("/j/", "g");
            dsPhuAm_MN.Add("/ɣ/", "gh");
            dsPhuAm_MN.Add("/j/", "gi");
            dsPhuAm_MN.Add("/h/", "h");
            dsPhuAm_MN.Add("∅", "h");
            dsPhuAm_MN.Add("/k/", "k");
            dsPhuAm_MN.Add("/x/", "kh");
            dsPhuAm_MN.Add("/l/", "l");
            dsPhuAm_MN.Add("/m/", "m");
            dsPhuAm_MN.Add("/n/", "n");
            dsPhuAm_MN.Add("/ŋ/", "ng");
            dsPhuAm_MN.Add("∅", "ng");
            dsPhuAm_MN.Add("/ŋ/", "ngh");
            dsPhuAm_MN.Add("/ɲ/", "nh");
            dsPhuAm_MN.Add("/p/", "p");
            dsPhuAm_MN.Add("/ɓ/", "p");
            dsPhuAm_MN.Add("/f/", "ph");
            dsPhuAm_MN.Add("∅", "q");
            dsPhuAm_MN.Add("/w/", "qu");
            dsPhuAm_MN.Add("/ɹ/", "r");
            dsPhuAm_MN.Add("/r/", "r");
            dsPhuAm_MN.Add("/ʐ/", "r");
            dsPhuAm_MN.Add("/s/", "s");
            dsPhuAm_MN.Add("/ʂ/", "s");
            dsPhuAm_MN.Add("/t/", "t");
            dsPhuAm_MN.Add("/tʰ/", "th");
            dsPhuAm_MN.Add("/c/", "tr");
            dsPhuAm_MN.Add("/ʈ͡ʂ/", "tr");
            dsPhuAm_MN.Add("/j/", "v");
            dsPhuAm_MN.Add("/s/", "x");
        }
    }
}

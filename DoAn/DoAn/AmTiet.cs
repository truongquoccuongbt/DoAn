using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public abstract class AmTiet
    {
        protected String am_tiet;
        protected String phu_am_dau;
        protected String nguyen_am;
        protected String phu_am_cuoi;
        protected String dau_thanh;
        protected Dictionary<string, string> tu_dien;

        public string amTiet
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

        public string phuAmDau
        {
            get
            {
                return phu_am_dau;
            }

            set
            {
                phu_am_dau = value;
            }
        }

        public string nguyenAm
        {
            get
            {
                return nguyen_am;
            }

            set
            {
                nguyen_am = value;
            }
        }

        public string phuAmCuoi
        {
            get
            {
                return phu_am_cuoi;
            }

            set
            {
                phu_am_cuoi = value;
            }
        }

        public string dau
        {
            get
            {
                return dau_thanh;
            }

            set
            {
                dau_thanh = value;
            }
        }

        public AmTiet()
        {
            am_tiet = String.Empty;
            phu_am_dau = String.Empty;
            nguyen_am = String.Empty;
            phu_am_cuoi = String.Empty;
            dau_thanh = String.Empty;
            tu_dien = new Dictionary<string, string>();
            KhoiTaoTuDien();
        }

        public void KhoiTaoTuDien()
        {
            string duongDan = Path.Combine(Directory.GetCurrentDirectory(), "../../syllables.txt");

            FileStream file = new FileStream(duongDan, FileMode.Open);
            StreamReader reader = new StreamReader(file, Encoding.Unicode);
            string dong;

            while ((dong = reader.ReadLine()) != null)
            {
                tu_dien.Add(dong, "");
            }
            reader.Close();
        }

        public AmTiet(String am)
        {
            this.am_tiet = am;
            tu_dien = new Dictionary<string, string>();
            phanTich();
            KhoiTaoTuDien();
            if (!kiemTraAmTiengViet())
            {
                phu_am_dau = String.Empty;
                nguyen_am = String.Empty;
                phu_am_cuoi = String.Empty;
                dau_thanh = String.Empty;
                throw new Exception(this.am_tiet + "Đây không phải tiếng Việt");
            }
        }
        
       

        /// <summary>
        /// Phân tích ra các thành phần của âm: nguyên âm đầu, phụ âm và nguyên âm cuối.
        /// </summary>
        /// <returns></returns>
        public abstract String[] tachThanhPhan();

   

        /// <summary>
        ///     Phân tích từ ra thành các thành phần nhỏ: dấu, nguyên âm, phụ âm đầu, phụ âm cuối.
        ///     Gán các thành phần nhỏ vào các thuộc tính của class.
        /// </summary>

        public abstract void phanTich();

 

        /// <summary>
        ///     Chuyển thành âm không dấu.
        /// </summary>
        /// <returns>Một từ không dấu</returns>
        public abstract String xoaTatCaDau();

        /// <summary>
        ///     Xóa phụ âm đầu
        /// </summary>
        /// <returns>Âm tiết không có phụ âm đầu</returns>
        public abstract String xoaPhuAmDau();

        /// <summary>
        ///     Xóa nguyên âm của âm tiết.
        /// </summary>
        /// <returns>Âm tiết không có nguyên âm</returns>
        public abstract String xoaNguyenAm();

        /// <summary>
        ///     Xóa phụ âm cuối của âm tiết
        /// </summary>
        /// <returns>Âm tiết không có phụ âm cuối</returns>
        public abstract String xoaPhuAmCuoi();

        /// <summary>
        ///     Viết in hoa
        /// </summary>
        /// <returns>Âm tiết in hoa</returns>
        public abstract String chuyenChuHoa(string am_tiet);


        /// <summary>
        ///     Chuyển sang chữ thường
        /// </summary>
        /// <returns>Âm tiết viết thường</returns>
        public abstract String chuyenChuThuong(string am_tiet);


        /// <summary>
        ///     Lấy dấu ra khỏi âm tiết
        /// </summary>
        /// <returns>Dấu thanh của chuỗi. Nếu không có trả về rỗng</returns>
        public abstract String tachDauThanh();

        /// <summary>
        ///     Chuyển Unicode sang UTF-8
        /// </summary>
        /// <returns>Chuỗi kiểu UTF-8</returns>
        public abstract String chuyenUnicodeToUTF8();


        /// <summary>
        /// Chuyển 
        /// </summary>
        /// <returns></returns>
        public abstract String chuyenUTF8ToUniCode();

        public abstract String[] layTungNguyenAm(string nguyenAm);


        /// <summary>
        ///     Kiểm tra xem hàm có phải là tiếng việt hay không.
        /// </summary>
        /// <returns>
        ///     Đúng trả về true.
        ///     Sai trả về false.
        /// </returns>
        public abstract bool kiemTraAmTiengViet();

        /// <summary>
        ///     Kiểm tra in hoa.
        /// </summary>
        /// <returns>
        ///     Có trả về true.
        ///     Không trả về false.
        /// </returns>
        public abstract bool kiemTraInHoa();


        /// <summary>
        ///     Kiểm tra in thường.
        /// </summary>
        /// <returns>
        ///     Có trả về true.
        ///     Không trả về false.
        /// </returns>
        public abstract bool kiemTraInThuong();

        /// <summary>
        ///         Tách thành cách phụ âm đơn
        /// </summary>
        /// <param name="phu_am"></param>
        /// <returns></returns>
        public abstract String[] layTungPhuAm(string phu_am);

        public abstract AmTiet ghepTu(string phu_am_dau, string nguyen_am, string nguyen_am_cuoi, string dau);
    }
}

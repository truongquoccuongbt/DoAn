using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public abstract class TuVung
    {
        protected String tu;
        protected String phuAmDau;
        protected String nguyenAm;
        protected String phuAmCuoi;
        protected String dau;

        public string Tu
        {
            get
            {
                return tu;
            }

            set
            {
                tu = value;
            }
        }

        public string PhuAmDau
        {
            get
            {
                return phuAmDau;
            }

            set
            {
                phuAmDau = value;
            }
        }

        public string NguyenAm
        {
            get
            {
                return nguyenAm;
            }

            set
            {
                nguyenAm = value;
            }
        }

        public string PhuAmCuoi
        {
            get
            {
                return phuAmCuoi;
            }

            set
            {
                phuAmCuoi = value;
            }
        }

        public string Dau
        {
            get
            {
                return dau;
            }

            set
            {
                dau = value;
            }
        }

        public TuVung()
        {
            Tu = String.Empty;
            PhuAmDau = String.Empty;
            NguyenAm = String.Empty;
            PhuAmCuoi = String.Empty;
            Dau = String.Empty;
        }

        public TuVung(String tu)
        {
            this.tu = tu;
            PhanTich();
        }
        
        //
        // Đặc tả:
        //      phân tích các ra các thành phần của từ
        //
        // Trả về:
        //      một cái mảng gồm có nguyên âm đầu, phụ âm và nguyên âm cuối 
        public abstract String[] TachThanhPhan();

        //
        // Đặc tả:
        //      Phân tích từ ra thành các thành phần nhỏ: dấu, nguyên âm,phụ âm đầu, phụ âm cuối.
        //      Gán các thành phần nhỏ vào các thuộc tính của class.
        // 
        public abstract void PhanTich();

        //
        // Đặc tả:
        //      Xóa tất cả dấu của từ
        // Trả về:
        //      Một từ không dấu
        //
        public abstract String XoaTatCaDau();

        //
        // Đặc tả:
        //      Xóa phụ âm đầu của từ.
        // Trả về:
        //      Từ không có phụ âm đầu.
        public abstract String XoaPhuAmDau();

        //
        // Đặc tả:
        //      Xóa nguyên âm của từ.
        // Trả về:
        //      Từ không có nguyên âm.
        public abstract String XoaNguyenAm();

        //
        // Đặc tả:
        //      Xóa phụ âm cuối của từ.
        // Trả về:
        //      Từ không có phụ âm cuối.
        public abstract String XoaPhuAmCuoi();

        //
        // Đặc tả:
        //      Chuyển chữ viết thường sang chữ hoa.
        // Trả về:
        //      Chữ có kiểu in hoa.
        public abstract String ChuyenChuHoa();

        //
        // Đặc tả:
        //      Chuyển từ in hoa sang chữ thường.
        // Trả về:
        //      Từ in thường.
        public abstract String ChuyenChuThuong();

        //
        //Đặc tả:
        //      Lấy dấu của từ.
        //Trả về:
        //      Dấu thanh của chuỗi.
        //      Nếu không có trả về rỗng.
        public abstract String TachDauThanh();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Public;
using System.Data;

namespace BUL
{
    public class SinhVienBUL
    {
        SinhVienDAL cls = new SinhVienDAL();
        public DataTable DSSV()
        {
            return cls.DanhSachSV();
        }
        public int ThemSV(HocSinhPublic x)
        {
            return cls.ThemSV(x);
        }
        public DataTable SinhMa()
        {
            return cls.SinhMa();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Public;
using System.Data;

namespace DAL
{
    public class SinhVienDAL
    {
        clsKetNoi cn = new clsKetNoi();
        public DataTable DanhSachSV()
        {
            return cn.LoadData("select * from SinhVien");
        }
        public int ThemSV(HocSinhPublic x)
        {
            int n = 3;
            string[] name = new string[n];
            object[] value = new object[n];
            name[0] = "@MaSV"; 
            name[1] = "@TenSV";
            name[2] = "@MaLop";
            value[0] = x.MaSV;
            value[1] = x.TenSV;
            value[2] = x.MaLop;
            return cn.Update("insert into SinhVien values(@MaSV,@TenSV,@MaLop)",name,value,n);
        }
        public DataTable SinhMa()
        {
            return cn.LoadData("SELECT TOP(1) CAST(RIGHT(MaSV, 3) + 1 AS integer) AS SV FROM SinhVien ORDER BY MaSV DESC");
        }
    }
}

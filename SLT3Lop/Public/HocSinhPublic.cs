using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    public class HocSinhPublic
    {
        private string _MaSV;

        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }
        private string _TenSV;

        public string TenSV
        {
            get { return _TenSV; }
            set { _TenSV = value; }
        }
        private string _MaLop;

        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
    }
}

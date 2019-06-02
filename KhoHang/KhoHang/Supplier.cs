using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoHang
{
    class Supplier
    {
        public Supplier(DataRow x)
        {
            this.idNCC = (int)x["idNCC"];
            this.tenNCC = x["tenNCC"].ToString();
            this.diaChiNCC = x["diaChiNCC"].ToString();
            this.sdtNCC = x["sdtNCC"].ToString();
            this.emailNCC = x["emailNCC"].ToString();
        }
        public int idNCC { get; set; }
        public string tenNCC { get; set; }
        public string diaChiNCC { get; set; }
        public string sdtNCC { get; set; }
        public string emailNCC { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoHang
{
    class Items
    {
        public Items(DataRow x)
        {
            this.idNCC = (int)x["idNCC"];
            this.tenMH = x["tenMH"].ToString();
            this.donVi = x["donVi"].ToString();
            this.idMH = (int)x["idMH"];
        }
        public int idNCC { get; set; }
        public string tenMH { get; set; }
        public string donVi { get; set; }
        public int idMH { get; set; }
    }
}

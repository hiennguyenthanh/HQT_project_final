using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiemChung
{
    public class Bhyt
    {
        private string _soBHYT;
        private string _ngayHH;

        public Bhyt(string bhyt, string ngayHH)
        {
            this._soBHYT = bhyt;
            this._ngayHH = ngayHH;
        }
        public Bhyt(DataRow row)
        {
            this._soBHYT = row["soBHYT"].ToString();
            this._ngayHH = row["NgayHetHan"].ToString();
        }
        public string SoBHYT { get => _soBHYT; set => _soBHYT = value; }
        public string NgayHH { get => _ngayHH; set => _ngayHH = value; }
    }
}

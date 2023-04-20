using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLNhaThuoc.Models
{
    public class Thuoc
    {

        [Key]
        public int MaThuoc { set; get; }
        [StringLength(255)]
        public string TenThuoc { set; get; }
        [StringLength(200)]
        public string Hinh { set; get; }
        public decimal GiaBan { set; get; }
        public string DonViTinh { set; get; }
        public IEnumerable<KhuVucLuuTru> KhuVucLuuTrus { get; set; }
        public virtual KhuVucLuuTru KhuVucLuuTru { set; get; }
        public int MaKhuVuc { set; get; }
       
        public string CongDung { set; get; }
        
        //public List<KhuVucLuuTru> ListKhuVucLuuTru = new List<KhuVucLuuTru>();
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLNhaThuoc.Models
{
    public class KhuVucLuuTru
    {
        [Key]
        public int MaKhuVuc { set; get; }
        [StringLength(255)]
        public string TenKhuVuc { set; get; }
    }
}
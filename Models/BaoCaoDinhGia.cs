using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class BaoCaoDinhGia
    {
        [Key]
        public int MaBC { get; set; } // Khóa chính

        public double Giatridinhgia { get; set; }
        public string? Mota { get; set; }
        public DateTime Ngaylapbaocao { get; set; }

        // Khóa ngoại
        public int MaTS { get; set; }
    }
}

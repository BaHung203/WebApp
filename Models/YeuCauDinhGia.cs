using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;
[Table("YeuCauDinhGia")]
public class YeuCauDinhGia
{
    [Key]
    public int MaYC { get; set; }
    public DateTime ThoiGianYC { get; set; }
    public string? Trangthai { get; set; }
    public int MaKH { get; set; }
    
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class TaiSan
{
    [Key]
    public int MaTS { get; set; }
    public string Vitri { get; set; } = null!;
    public double DienTich { get; set; }
    public string TinhTrang { get; set; } = null!;
    public string Chusohu { get; set; } = null!;
}

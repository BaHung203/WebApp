using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApp.Models;
namespace WebApp.Models;

public class KhachHang
{
    [Key]
    public int MaKH { get; set; }
    public string hoten { get; set; } = null!;
    public DateTime Ngaysinh { get; set; }
    public string Gioitinh { get; set; } = null!;
    public string email { get; set; } = null!;
    public string sdt { get; set; } = null!;
    public string diachi { get; set; } = null!;
}

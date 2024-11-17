using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class NhanVienChamSocKhachHang
{
    [Key]
    public int MaNV { get; set; }
    public string Hoten { get; set; } = null!;
    public DateTime Ngaysinh { get; set; }
    public string Gioitinh { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Sdt { get; set; } = null!;
}

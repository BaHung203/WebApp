using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

public class QuanTriVien
{
   [Key]
    public int MaQT { get; set; }
    public string Hoten { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Matkhau { get; set; } = null!;
}

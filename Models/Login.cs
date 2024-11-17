using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Models;

public class Login
{
    [Key]
    public string Eml { get; set; } = null!;
    public string Pwd { get; set; } = null!;
    public bool Rem { get; set; }
}

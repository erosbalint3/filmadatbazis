using System;
using System.ComponentModel.DataAnnotations;

namespace filmadatbazis.Models;

public class MovieModel
{
    [Key]
    public int ID { get; set; }

    [Required]
    public String Title { get; set; }

    [Required]
    public String Director { get; set; }

    [Required]
    [Range(1900, 2023, ErrorMessage = "Az évszám 1900 és 2023 között kell legyen!")]
    public int ReleaseYear { get; set; }
}
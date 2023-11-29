using System;
using System.ComponentModel.DataAnnotations;

namespace filmadatbazis.Models;

public class DetailsModel
{
    [Key]
    public int ID { get; set; }

    [Required]
    public String Title { get; set; }

    [Required]
    public String Synopsis { get; set; }
}
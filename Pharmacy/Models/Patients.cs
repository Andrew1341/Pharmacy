using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Model;

public class Patients
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(255)]
    public string Last_Name { get; set; }

    [Required]
    [MaxLength(255)]
    public string First_Name { get; set; }

    [Required]
    public DateTime Date_of_Birth { get; set; }

    [Required]
    [MaxLength(255)]
    public string Address { get; set; }

    [Required]
    [MaxLength(20)]
    public string Phone { get; set; }

    [Required]
    [MaxLength(255)]
    public string Email { get; set; }
}

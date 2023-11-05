using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Employees
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
    [MaxLength(255)]
    public string Middle_Name { get; set; }

    [Required]
    public DateTime Date_of_Birth { get; set; }

    [ForeignKey("Pharmacy")]
    public int Pharmacy_ID { get; set; }
    public virtual Pharmacies Pharmacy { get; set; }

    [Required]
    [MaxLength(255)]
    public string Position { get; set; }

    [Required]
    [MaxLength(50)]
    public string Login { get; set; }

    [Required]
    [MaxLength(50)]
    public string Password { get; set; }
}

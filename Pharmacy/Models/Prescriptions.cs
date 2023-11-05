using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Prescriptions
{
    [Key]
    public int ID { get; set; }

    [ForeignKey("Patient")]
    public int Patient_ID { get; set; }
    public virtual Patients Patient { get; set; }

    [Required]
    [MaxLength(255)]
    public string Doctor_Name { get; set; }

    [Required]
    public DateTime Issue_Date { get; set; }

    [Required]
    public DateTime Expiry_Date { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Medicine
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(255)]
    public string Medicine_Name { get; set; }

    [Required]
    [MaxLength(50)]
    public string Medicine_Code { get; set; }

    [Required]
    [MaxLength(255)]
    public string Pharmacological_Group { get; set; }

    [ForeignKey("Category")]
    public int Category_ID { get; set; }
    public virtual Medication_Categories Category { get; set; }

    [ForeignKey("Type")]
    public int Type_ID { get; set; }
    public virtual Medication_Types Type { get; set; }

    [Required]
    [MaxLength(50)]
    public string Prescription_Status { get; set; }
}

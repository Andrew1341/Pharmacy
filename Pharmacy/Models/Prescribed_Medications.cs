using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Prescribed_Medications
{
    [Key]
    public int ID { get; set; }

    [ForeignKey("Prescription")]
    public int Prescription_ID { get; set; }
    public virtual Prescriptions Prescription { get; set; }

    [ForeignKey("Medicine")]
    public int Medicine_ID { get; set; }
    public virtual Medicine Medicine { get; set; }

    [Required]
    public int Quantity { get; set; }
}

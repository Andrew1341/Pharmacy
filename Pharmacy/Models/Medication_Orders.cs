using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Medication_Orders
{
    [Key]
    public int ID { get; set; }

    [Required]
    public DateTime Order_Date { get; set; }

    [ForeignKey("Employee")]
    public int Employee_ID { get; set; }
    public virtual Employees Employee { get; set; }

    [ForeignKey("Pharmacy")]
    public int Pharmacy_ID { get; set; }
    public virtual Pharmacies Pharmacy { get; set; }
}

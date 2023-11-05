using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Operations
{
    [Key]
    public int ID { get; set; }

    [Required]
    public DateTime Operation_Date { get; set; }

    [ForeignKey("OperationType")]
    public int Operation_Type_ID { get; set; }
    public virtual Operation_Types OperationType { get; set; }

    [ForeignKey("Pharmacy")]
    public int Pharmacy_ID { get; set; }
    public virtual Pharmacies Pharmacy { get; set; }

    [ForeignKey("Employee")]
    public int Employee_ID { get; set; }
    public virtual Employees Employee { get; set; }

    public string Note { get; set; }
}

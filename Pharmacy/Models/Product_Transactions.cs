using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Product_Transactions
{
    [Key]
    public int ID { get; set; }

    [Required]
    public DateTime Transaction_Date { get; set; }

    [ForeignKey("Operation")]
    public int Operation_ID { get; set; }
    public virtual Operations Operation { get; set; }

    [ForeignKey("Medicine")]
    public int Medicine_ID { get; set; }
    public virtual Medicine Medicine { get; set; }

    [ForeignKey("Pharmacy")]
    public int Pharmacy_ID { get; set; }
    public virtual Pharmacies Pharmacy { get; set; }

    [ForeignKey("Employee")]
    public int Employee_ID { get; set; }
    public virtual Employees Employee { get; set; }

    public string Note { get; set; }
}

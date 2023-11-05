using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Supplied_Medications
{
    [Key]
    public int ID { get; set; }

    [ForeignKey("Supplier")]
    public int Supplier_ID { get; set; }
    public virtual Suppliers Supplier { get; set; }

    [ForeignKey("Medicine")]
    public int Medicine_ID { get; set; }
    public virtual Medicine Medicine { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public DateTime Supply_Date { get; set; }

    [Required]
    public DateTime Expiry_Date { get; set; }

    [Required]
    [MaxLength(50)]
    public string Batch_Number { get; set; }
}

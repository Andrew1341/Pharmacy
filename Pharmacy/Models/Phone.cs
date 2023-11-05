using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Phone
{
    [Key]
    public long Phone_ID { get; set; }

    [ForeignKey("Pharmacy")]
    public int Pharmacy_ID { get; set; }
    public virtual Pharmacies Pharmacy { get; set; }

    [Required]
    [MaxLength(100)]
    public string PhoneNumber { get; set; }
}

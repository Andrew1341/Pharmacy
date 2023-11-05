using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Suppliers
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(255)]
    public string Supplier_Name { get; set; }

    [Required]
    [MaxLength(255)]
    public string Address { get; set; }

    [Required]
    [MaxLength(20)]
    public string Phone { get; set; }

    [Required]
    [MaxLength(255)]
    public string Contact_Person { get; set; }
}

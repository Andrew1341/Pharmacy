using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Model;

public class Operation_Types
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(255)]
    public string Type_Name { get; set; }
}

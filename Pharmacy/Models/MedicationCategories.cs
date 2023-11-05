using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Model;

public class Medication_Categories
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(255)]
    public string Category_Name { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Model;

public class Regions
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(255)]
    public string Region_Name { get; set; }

    public virtual ICollection<Cities> Cities { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Cities
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(255)]
    public string City_Name { get; set; }

    [ForeignKey("Region")]
    public int Region_ID { get; set; }
    public virtual Regions Region { get; set; }

    public virtual ICollection<Streets> Streets { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Streets
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(255)]
    public string Street_Name { get; set; }

    [ForeignKey("City")]
    public int City_ID { get; set; }
    public virtual Cities City { get; set; }
}

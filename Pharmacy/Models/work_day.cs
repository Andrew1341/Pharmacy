using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class work_day
{
    [Key]
    public long Work_Day_ID { get; set; }

    [Required]
    [MaxLength(100)]
    public string Work_Day { get; set; }
}

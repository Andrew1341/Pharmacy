using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class Pharmacies
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(255)]
    public string Pharmacy_Name { get; set; }

    [Required]
    [MaxLength(255)]
    public string Address { get; set; }

    [ForeignKey("City")]
    public int City_ID { get; set; }
    public virtual Cities City { get; set; }

    [Required]
    [MaxLength(20)]
    public string Phone { get; set; }

    [Required]
    [MaxLength(255)]
    public string Working_Hours { get; set; }

    [ForeignKey("WorkTime")]
    public long Work_Time_ID { get; set; }
    public virtual work_time WorkTime { get; set; }
}

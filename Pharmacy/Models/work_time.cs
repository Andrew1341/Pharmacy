using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Model;

public class work_time
{
    [Key]
    public long Work_Time_ID { get; set; }

    [ForeignKey("WorkDay")]
    public long Work_Day_ID { get; set; }
    public virtual work_day WorkDay { get; set; }

    [Required]
    public TimeSpan Start_Day { get; set; }

    [Required]
    public TimeSpan Start_Lunch { get; set; }

    [Required]
    public TimeSpan End_Lunch { get; set; }

    [Required]
    public TimeSpan End_Day { get; set; }
}

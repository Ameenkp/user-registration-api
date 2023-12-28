using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace userReg.Models;

[Table("APP_REG")]
public class Applicant
{
    [Key]
    [Column("APP_ID")]
    public int AppId { get; set; }

    [Required]
    [Column("APP_NO")]
    public string AppNo { get; set; }

    [Column("APP_DATE")]
    public DateTime AppDate { get; set; }

    [Required]
    [Column("APP_NAME")]
    public string AppName { get; set; }

    [Required]
    [Column("APP_POSITION")]
    public string AppPosition { get; set; }

    [Column("APP_DOB")]
    public DateTime AppDob { get; set; }

    [Required]
    [Column("APP_AGE")]
    public int AppAge { get; set; }

    [Required]
    [Column("APP_GENDER")]
    public string AppGender { get; set; }

    [Required]
    [Column("APP_MOBILE")]
    public string AppMobile { get; set; }

    [Required]
    [Column("APP_EMAIL")]
    public string AppEmail { get; set; }

    [Required]
    [Column("APP_REASON")]
    public string AppReason { get; set; }

    [Column("APP_NOYEARS")]
    public decimal? AppNoYears { get; set; }

    [Column("APP_CURRENTEMPLOYER")]
    public string AppCurrentEmployer { get; set; }

    [Column("APP_NP")]
    public int? AppNp { get; set; }
}

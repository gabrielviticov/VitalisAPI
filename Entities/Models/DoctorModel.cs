using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VitalisAPI.Entities.Enums;

namespace VitalisAPI.Entities.Models;

[Table("TB_DOCTOR")]
public class DoctorModel
{
    [Required]
    [Key]
    [Column("CL_PK_IDENTIFY")]
    public Guid Identify { get; set; }
    [Required]
    public PersonModel? Person { get; set; }
    [Required]
    [StringLength(8)]
    [Column(name: "CL_CRM")]
    public string Crm { get; set; }
    [Required]
    [EnumDataType(typeof(SpecialtyEnum))]
    [Column(name: "CL_SPECIALTY")]
    public string Specialty { get; set; } = string.Empty;
    [Required]
    public AddressModel? Address { get; set; }
}
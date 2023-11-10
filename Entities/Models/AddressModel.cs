using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalisAPI.Entities.Models;

public class AddressModel
{
    [Required]
    [Column(name: "CL_ADDRESS")]
    public string Address { get; set; } = string.Empty;
    [Column(name: "CL_NUMBER")]
    public string Number { get; set; } = string.Empty;
    [Column(name: "CL_ADDITIONAL_ADDRESS")]
    public string AdditionalAddress { get; set; } = string.Empty;
    [Required]
    [Column(name: "CL_STATE")]
    public string State { get; set; } = string.Empty;
    [Required]
    [Column(name: "CL_CITY")]
    public string City { get; set; } = string.Empty;
    [Required]
    [Column(name: "CL_DISTRICT")]
    public string District { get; set; } = string.Empty;
    [Required]
    [Column(name: "CL_UNIT_FEDERATIVE")]
    public string UnitFederative { get; set; } = string.Empty;
    [Required]
    [StringLength(9)]
    [Column("CL_ZIP_CODE")]
    public string ZipCode { get; set; } = string.Empty;
}
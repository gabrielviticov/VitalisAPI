using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalisAPI.Entities.Models;


public class PersonModel
{
    [Required]
    [Column(name: "CL_FIRST_NAME")]
    [StringLength(255)]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    [Column(name: "CL_LAST_NAME")]
    [StringLength(180)]
    public string LastName { get; set; } = string.Empty;
    [Required]
    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    [Column(name: "CL_EMAIL_ADDRESS")]
    public string EmailAddress { get; set; } = string.Empty;
    [Required]
    [Phone]
    [DataType(DataType.PhoneNumber)]
    [Column(name: "CL_PHONE_NUMBER")]
    public string PhoneNumber { get; set; } = string.Empty;
}
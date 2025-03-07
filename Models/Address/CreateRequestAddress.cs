namespace AD2_WEB_APP.Models.Address;

using System.ComponentModel.DataAnnotations;
using AD2_WEB_APP.Entities;

public class CreateRequestAddress
{
   
    [Required]
    public string Street_Address { get; set; } = null!;

    [Required]
    public string City { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string State { get; set; } = null!;

    [Required]
    public string Zip_Code { get; set; } = null!;

     [Required]
    public string Country { get; set; } = null!;
 
}
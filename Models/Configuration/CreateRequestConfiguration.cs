namespace AD2_WEB_APP.Models.Configuration;

using System.ComponentModel.DataAnnotations;
using AD2_WEB_APP.Entities;

public class CreateRequestConfiguration
{

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    public string Category { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Description { get; set; } = null!;

    [Required]
    public double Price { get; set; } = 0.0!;

}
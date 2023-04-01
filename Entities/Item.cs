namespace AD2_WEB_APP.Entities;

using System.Text.Json.Serialization;

public class Item{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public int ConfigurationID { get; set; }
}
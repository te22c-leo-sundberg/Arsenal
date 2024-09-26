using System.Text.Json.Serialization;

public class Hat
{
    [JsonInclude]
    public string Name;

    [JsonInclude]
    public int Swag;

    [JsonInclude]
    public int Armor;

    [JsonInclude]
    public string Color;

    [JsonInclude]
    public int Funiness;
}
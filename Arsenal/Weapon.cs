using System.Text.Json.Serialization;

public class Weapon
{
    [JsonInclude]
    public string Name;

    [JsonInclude]
    public float AttackSpeed;

    [JsonInclude]
    public int MinDamage;

    [JsonInclude]
    public int MaxDamage;

    public int Attack()
    {
        return Random.Shared.Next(MinDamage, MaxDamage);
    }
}
global using System.Text.Json;

string contents = File.ReadAllText("weapons.json");

// File.WriteAllText("test.json",
//     JsonSerializer.Serialize(
//         new Weapon()
//         { Name = "svamp", AttackSpeed = 5.5f, MinDamage = 3, MaxDamage = 4 }
//     )
// );

List<Weapon> w = JsonSerializer.Deserialize<List<Weapon>>(contents);

int numberOfAttacks = 0;
string numberOfAttacksString = "";

while (!int.TryParse(numberOfAttacksString, out numberOfAttacks))
{
    numberOfAttacksString = Console.ReadLine();
}

int damageSum = 0;

for (int i = 0; i < numberOfAttacks * w[0].AttackSpeed; i++)
{
    int damage = w[0].Attack();
    Console.WriteLine($"+{damage}");
    damageSum += damage;
}

Console.WriteLine($"You did {damageSum} amount of damage!");

Console.ReadLine();
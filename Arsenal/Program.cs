global using System.Text.Json;

string weaponContents = File.ReadAllText("weapons.json");
string enemyContents = File.ReadAllText("enemies.json");

// File.WriteAllText("test.json",
//     JsonSerializer.Serialize(
//         new Weapon()
//         { Name = "svamp", AttackSpeed = 5.5f, MinDamage = 3, MaxDamage = 4 }
//     )
// );

List<Weapon> w = JsonSerializer.Deserialize<List<Weapon>>(weaponContents);
List<Enemy> e = JsonSerializer.Deserialize<List<Enemy>>(enemyContents);

int weaponChoice = 0;
string weaponChoiceString = "";

int enemyChoice = 0;
string enemyChoiceString = "";

int numberOfAttacks = 0;
string numberOfAttacksString = "";

while (!int.TryParse(weaponChoiceString, out weaponChoice))
{
    Console.WriteLine("What weapon between 0 and 3 do you want to use?");
    weaponChoiceString = Console.ReadLine();
}
Console.WriteLine(w[weaponChoice].Name);

while (!int.TryParse(enemyChoiceString, out enemyChoice))
{
    Console.WriteLine("What enemy between 0 and 3 do you want to fight?");
    enemyChoiceString = Console.ReadLine();
}
Console.WriteLine(e[enemyChoice].Name);

while (!int.TryParse(numberOfAttacksString, out numberOfAttacks))
{
    Console.WriteLine("How many attacks are you both going to make?");
    numberOfAttacksString = Console.ReadLine();
}
Console.WriteLine(numberOfAttacks);

int enemyDamageSum = 0;
int damageSum = 0;

for (int i = 0; i < numberOfAttacks * w[weaponChoice].AttackSpeed; i++)
{
    int damage = w[weaponChoice].Attack();
    Console.WriteLine($"{e[enemyChoice].Name} took {damage} damage!");
    damageSum += damage;
}
for (int i = 0; i < numberOfAttacks * e[enemyChoice].AttackSpeed; i++)
{
    int enemyDamage = e[enemyChoice].Attack();
    Console.WriteLine($"{w[weaponChoice].Name} took {enemyDamage} damage!");
    enemyDamageSum += enemyDamage;
}

Console.WriteLine($"You did {damageSum} amount of damage!");
Console.WriteLine($"{e[enemyChoice].Name} did {enemyDamageSum} amount of damage!");

Console.ReadLine();
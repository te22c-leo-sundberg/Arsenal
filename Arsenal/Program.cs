global using System.Text.Json;


string textHat = File.ReadAllText("hats.json");
List<Hat> hats = JsonSerializer.Deserialize<List<Hat>>(textHat);

Console.WriteLine(hats[0].Name);

Console.ReadLine();
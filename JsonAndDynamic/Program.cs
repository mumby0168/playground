
using System.Text.Json;
using System.Text.Json.Nodes;

var john = new Person("123", "John");

var settings = new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    WriteIndented = true,
    PropertyNameCaseInsensitive = true
};

var json = JsonSerializer.Serialize(john, settings);

Console.WriteLine(json);

var dynamicPerson = JsonSerializer.Deserialize<dynamic>(json, settings);

var newPerson = JsonSerializer.Deserialize<Person>(dynamicPerson, settings);

Console.WriteLine(newPerson);
record Person(string Id, string Name);
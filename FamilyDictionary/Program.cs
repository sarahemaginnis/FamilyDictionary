using System.Linq;

Dictionary<string, Dictionary<string, string>> myFamily = new();
myFamily.Add("sister", new() { { "name", "Krista" }, { "age", "42" } });
myFamily.Add("mother", new() { { "name", "Carol" }, { "age", "70" } });
myFamily.Add("husband", new() { { "name", "Sean" }, { "age", "36" } });
myFamily.Add("son", new() { { "name", "Eoghan" }, { "age", "1" } });

foreach (var (familyRelationship, familyAttributes) in myFamily) //touple
{
    string familyName = familyAttributes["name"];
    string familyAge = familyAttributes["age"];
    Console.WriteLine($"{familyName} is my {familyRelationship} and is {familyAge} years old.");
}

//Krista is my sister and is 42 years old.
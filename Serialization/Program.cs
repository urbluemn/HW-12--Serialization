using Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;


string jsonFile = @"E:\Super hero squad.json";
//string jsonString = File.ReadAllText(jsonFile);
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    IncludeFields= true,
};

using FileStream openStream = File.OpenRead(jsonFile);


SuperSquad? superSquad = JsonSerializer.Deserialize<SuperSquad>(openStream, options);




Console.ReadLine();

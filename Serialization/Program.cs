using Serialization;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Text.Json;

string jsonFile = @"E:\Super hero squad.json";

StreamReader reader = new StreamReader(jsonFile);
var readedFile = reader.ReadToEnd();


SuperSquad? superSquad = JsonConvert.DeserializeObject<SuperSquad?>(readedFile);




//string jsonString = File.ReadAllText(jsonFile);
//var options = new JsonSerializerOptions
//{
//    PropertyNameCaseInsensitive = true,
//    IncludeFields = true,
//    WriteIndented = true
//};


//var ser = new DataContractJsonSerializer(typeof(SuperSquad));
//using (FileStream openStream = new FileStream(jsonFile, FileMode.OpenOrCreate))
//{
//    var newSquad = ser.ReadObject(openStream) as SuperSquad;
//}

//using FileStream openStream = File.OpenRead(jsonFile);

//SuperSquad? superSquad = System.Text.Json.JsonSerializer.Deserialize<SuperSquad>(jsonFile, options);





Console.ReadLine();

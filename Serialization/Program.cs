using Serialization;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Formats.Asn1;

string jsonDefaultFile = @"E:\Super hero squad.json";

//StreamReader reader = new StreamReader(jsonDefaultFile);
//var readedFile = reader.ReadToEnd();
SuperSquad? superSquad = JsonConvert.DeserializeObject<SuperSquad?>(File.ReadAllText(jsonDefaultFile));

ViewProcessOf("JSON", superSquad);

var XmlSer = new XmlSerializer(typeof(SuperSquad));
using(TextWriter XmlWriter = new StreamWriter(@"E:\SuperSquad.xml"))
{
    XmlSer.Serialize(XmlWriter, superSquad);
}


superSquad= null;


var XmlDeser = new XmlSerializer(typeof(SuperSquad));
TextReader XmlReader = new StreamReader(@"E:\SuperSquad.xml");
object obj = XmlDeser.Deserialize(XmlReader);
superSquad = (SuperSquad)obj;
XmlReader.Close();

ViewProcessOf("XML", superSquad);

//string path = @"E:\SuperSquad.json";
//string SerializedString = JsonSerializer.Serialize(superSquad);
//File.WriteAllText(path, SerializedString);

string jsonNewString = @"E:\SuperSquad.json";
string jsonConvertedString = JsonConvert.SerializeObject(superSquad);
File.WriteAllText(jsonNewString, jsonConvertedString);









//var options = new JsonSerializerOptions
//{
//    PropertyNameCaseInsensitive = true,
//    IncludeFields = true,
//    WriteIndented = true
//};

//using (FileStream openStream = new FileStream(jsonDefaultFile, FileMode.Open, FileAccess.Read))
//{

//    SuperSquad? superSquad = System.Text.Json.JsonSerializer.Deserialize<SuperSquad>(openStream, options);
//}




static void ViewProcessOf(string process, SuperSquad superSquad)
{
    Console.WriteLine("\n\t" + new string('=', 33));
    Console.WriteLine($"\t\t{process} Deserialized");
    Console.WriteLine("\t" + new string('=', 33) + "\n");
    Console.WriteLine(superSquad.ToString());
}

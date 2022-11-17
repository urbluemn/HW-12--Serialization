using Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System;

namespace Serialization
{
    [Serializable]
    public class Members /*: ISerializable*/
    {

        public string? name { get; set; }
        public int? age { get; set; }
        public string? secretIdentity { get; set; }
        List<string>? powers { get; set; }

        public Members() { }
        //public override string ToString() => string.Join(Environment.NewLine, new string[]
        //{
        //    $"{name}: Age: {age}, Secret Identity: {secretIdentity}, Super Powers: ({string.Join(", ", powers)}"
        //});



        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

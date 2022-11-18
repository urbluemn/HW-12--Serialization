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
        public List<string>? powers { get; set; }


        public override string ToString() => string.Join(Environment.NewLine, new string[]
        {
            $"\n\t{name}: \nAge: {age}, \nSecret Identity: {secretIdentity}, \nSuper Powers: \n{string.Join(", \n", powers)}"
        });



        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

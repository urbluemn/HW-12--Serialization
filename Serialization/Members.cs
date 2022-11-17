using System.Runtime.Serialization;

namespace Serialization
{
    [Serializable]
    internal class Members /*: ISerializable*/
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? SecretIdentity { get; set; }
        List<string>? Powers { get; set; }

        

        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

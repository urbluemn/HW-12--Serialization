using Serialization;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Serialization
{
    
    [Serializable]
    public class SuperSquad /*: ISerializable*/
    {
        
        public string? squadName { get; set; }
        public string? homeTown { get; set; }
        public int? formed { get; set; }
        public string? secretBase { get; set; }
        public bool? active { get; set; }
        public List<Members>? members { get; set; }




        public override string? ToString() =>
             string.Join(Environment.NewLine, new string[]
             {
                $"Squad \"{squadName}\":",
                $"Home town : {homeTown}, Formed : {formed}, Secret base : {secretBase}, {((bool)active ? "Active" : "Not active")}",
                "Members:",
                string.Join(Environment.NewLine, members)
             });






        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    info.AddValue("squadName", squadName);
        //    info.AddValue("homeTown", homeTown);
        //    info.AddValue("formed", formed);
        //    info.AddValue("secretBase", secretBase);
        //    info.AddValue("active", active);
        //    info.AddValue("members", members);
        //}
        //public SuperSquad(SerializationInfo info, StreamingContext context) 
        //{
        //    squadName = (string?)info.GetValue("squadName", typeof(string));
        //    homeTown = (string?)info.GetValue("homeTown", typeof(string));
        //    formed = (int)info.GetValue("formed", typeof(int));
        //    secretBase = (string?)info.GetValue("secretBase", typeof(string));
        //    active = (bool)info.GetValue("active", typeof(bool));
        //    members = new List<Members>();
        //}

        //public void ViewBaseInfo()
        //{
        //   Console.WriteLine($"Squad name: {squadName}, home town: {homeTown}, its formed in: {formed}, secret name: {secretBase}, is it active:{active}");

        //    if (members != null)
        //    {
        //        foreach(object member in members)
        //        {
        //            Console.WriteLine(member.ToString());
        //        }
        //    }
        //}
    }
}

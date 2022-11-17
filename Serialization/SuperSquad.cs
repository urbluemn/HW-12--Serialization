using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    internal class SuperSquad /*: ISerializable*/
    {
        public string? squadName;
        public string? homeTown;
        public int formed;
        public string? secretBase;
        public bool active;
        List<Members>? members { get; set; }

        
        

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

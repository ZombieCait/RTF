
using System.IO;
using System.Xml.Serialization;

namespace PPLR45
{
    public class ClientData
    {
        public string path { get; set; }
        public bool useSsl { get; set; }
        public int port { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string host { get; set; }

   }
}

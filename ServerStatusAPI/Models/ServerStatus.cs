using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerStatusAPI.Models
{
    public class ServerStatus
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public bool Status { get; set; }
        public string Time { get; set; }
    }
}
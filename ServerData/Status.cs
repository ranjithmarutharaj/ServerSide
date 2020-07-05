using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerData
{
    public class Status
    {
        public static List<Server> GetAllServer()
        {
            var result = new List<Server>();

            using (var db = new ServerStatusEntities())
            {
                if (null == db.Servers)
                {
                    return null;
                }
                result = db.Servers.ToList();
            }
            return result;
        }

        public static Server GetServer(string serverName)
        {
            Server result = new Server();

            using (var db = new ServerStatusEntities())
            {
                result = db.Servers.Where(x => string.Equals(x.Name, serverName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            }
            return result;
        }
    }
}

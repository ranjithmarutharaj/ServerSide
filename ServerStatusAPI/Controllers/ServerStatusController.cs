using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServerStatusAPI.Models;
using ServerData;
using System.Web.Http.Cors;

namespace ServerStatusAPI.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    [RoutePrefix("api")]
    public class ServerStatusController : ApiController
    {
        [Route("ServerStatus")]
        [HttpGet]
        public IHttpActionResult GetServerList()
        {
            var res = Status.GetAllServer();

            if (null == res || res.Count == 0)
            {
                return NotFound();
            }
            return Ok(res);
        }

        //[Route("server/{serverName}")]
        //public IHttpActionResult Get(string serverName)
        //{
        //    var res = Status.GetServer(serverName);

        //    if (null == res)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(res);
        //}
    }
}

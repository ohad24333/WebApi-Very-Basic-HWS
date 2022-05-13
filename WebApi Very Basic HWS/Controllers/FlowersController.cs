using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Very_Basic_HWS.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        public string Rose()
        {
            return "Rose";
        }
        public string Lily()
        {
            return "Lily";
        }
        public string Tulip()
        {
            return "Tulip";
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public List<Tblsample3> Get()
        {
            SampleDB3Context db = new SampleDB3Context();
            return db.Tblsample3s.ToList();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<Table1> Get()
        {
            CapgiContext db = new CapgiContext();
            return db.Table1s.ToList();
        }
        [HttpPost]
        public string Post([FromBody]string sample)
        {
            CapgiContext db = new CapgiContext();
            Table1 s = new Table1();
            s.Ename = sample;
            db.Table1s.Add(s);
            db.SaveChanges();
            return "Success";
        }
         
    }
}

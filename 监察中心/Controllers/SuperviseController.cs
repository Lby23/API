using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Model;
using Microsoft.AspNetCore.Cors;

namespace 监察中心.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperviseController : ControllerBase
    {
        private dal dl;
        public SuperviseController(dal s1)
        {
            dl = s1;
        }

        [Route("api/Index")]
        [HttpGet]
        [EnableCors("any")]
        public List<Stu> GetAll()
        {
            return dl.GetList();
        }
    }
}

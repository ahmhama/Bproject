using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Testings;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TestingController :BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Testing>>> GetTesting()
        {
            return await Mediator.Send(new List.Query());   
        }
        [HttpPost]
        public async Task<ActionResult<Testing>> CreateTestings(Testing testing)
        {
            return Ok(await Mediator.Send(new Create.Command{Test = testing}));
        }
        
    }
}
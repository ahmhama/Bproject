using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Disease;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class DiseasesController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Diseases>>> GetDiseases() //This EndPoint Retrieve List Of Diseases
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Diseases>> GetDisease(Guid id) //This Endpoint Retrieve disease by id 
        {
            return await Mediator.Send(new Details.Query{Id=id});
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Vaccines;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class VaccineController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Vaccine>>> GetVaccines()
        {
            return await Mediator.Send(new List.Query());
        }

    }
}
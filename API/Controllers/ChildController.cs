using Application.Children;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ChildController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Child>>> GetCildren() //This Endpoint retrieve list of child
        {
            return await Mediator.Send(new List.Query());
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Child>> GetChild(int id) //This Endpoint retrieve Single Children by id
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }
        [HttpPost]
        public async Task<IActionResult> CreateChild(Child child) // This EndPoint Creates New List of Children
        {
            return Ok(await Mediator.Send(new Create.Commnad { Child = child }));
        }
        [HttpPut]
        public async Task<ActionResult<Child>> EditChild(int id,Child child) //This EndPoint Edits Child by Id 
        {
            child.ChildId = id;
            return Ok (await Mediator.Send(new Edit.Commnad{Child=child}));
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Child>> DeleteChild(int id) //This Endpoint Delete the Child By Id 
        {
            return Ok(await Mediator.Send(new Delete.Commnad{Id=id}));
        }

    }
}
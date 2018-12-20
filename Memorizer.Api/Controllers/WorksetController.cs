using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Memorizer.Data;
using Memorizer.Api.Query;
using GraphQL;
using GraphQL.Types;

namespace Memorizer.Api.Controllers
{
    [Route("graphql")]
    //[Authorize]
    [ApiController]
    public class WorksetController : ControllerBase
    {
        private readonly MemorizerContext _db;

        public WorksetController(MemorizerContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var inputs = query.Variables.ToInputs();

            var schema = new Schema()
            {
                Query = new WorksetQuery(_db)
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
                {
                    _.Schema = schema;
                    _.Query = query.Query;
                    _.OperationName = query.OperationName;
                    _.Inputs = inputs;
                }).ConfigureAwait(false);

            if(result.Errors?.Count>0)
            {
                return BadRequest();
            }

            return Ok(result);
        }


        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

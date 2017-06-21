using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Web.TORCHx.Core.Web.API
{
	public class SampleController : BaseController
    {
        // GET api/v1/sample
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

		// GET api/v1/sample/5
		[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

		// POST api/v1/sample
		[HttpPost]
        public void Post([FromBody]string value)
        {
        }

		// PUT api/v1/sample/5
		[HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

		// DELETE api/v1/sample/5
		[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

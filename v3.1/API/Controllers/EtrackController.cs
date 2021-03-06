using Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
	[Route("api/[controller]")]
	//[Authorize]
	[ApiController]
	public class EtracksController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Etrack> lEtracks = await db.Etrack.GetAllCompanyEtracks(id);
				 //return JsonConvert.SerializeObject(lEtracks.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Etrack etrack)
			{
				 //Create
				 db.Etrack.Add(etrack);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrack);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Etrack etrack)
			{
				 //Update
				 db.Etrack.Update(etrack);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Etrack etrack)
			{
				 db.Etrack.Remove(etrack);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

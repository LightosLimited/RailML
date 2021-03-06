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
	public class EtrainGroupssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrainGroups> lEtrainGroupss = await db.EtrainGroups.GetAllCompanyEtrainGroupss(id);
				 //return JsonConvert.SerializeObject(lEtrainGroupss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrainGroups etraingroups)
			{
				 //Create
				 db.EtrainGroups.Add(etraingroups);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etraingroups);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrainGroups etraingroups)
			{
				 //Update
				 db.EtrainGroups.Update(etraingroups);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrainGroups etraingroups)
			{
				 db.EtrainGroups.Remove(etraingroups);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

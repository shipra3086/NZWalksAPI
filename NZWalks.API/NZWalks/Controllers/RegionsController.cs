using Microsoft.AspNetCore.Mvc;
using NZWalks.Model.Domain;
using NZWalks.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NZWalks.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository _regionRepository;

        public RegionsController( IRegionRepository regionRepository)
        {
            this._regionRepository = regionRepository;
        }
        [HttpGet]
       public  async Task<IActionResult> GetAllRegions()
        {
          var regions = await  _regionRepository.GetAllAsync();
           
            return Ok(regions);
        }
    }
}

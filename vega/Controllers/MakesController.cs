using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Persistance;
using vega.Resources;

namespace vega.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MakesController : ControllerBase
    {
        private readonly VegaDBContext context;
        private readonly IMapper mapper;

        //dependency injection
        public MakesController(VegaDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();


            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnetcoreangular.Controllers.Resources;
using dotnetcoreangular.Data.Entities;
using dotnetcoreangular.Data.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnetcoreangular.Controllers {
	public class ManufacturerController : Controller {
		private readonly AppDbContext _context;
		private readonly IMapper mapper;

		public ManufacturerController(AppDbContext context, IMapper mapper) {
			this._context = context;
			this.mapper = mapper;
		}

		[HttpGet("api/manufacturers")]
		public async Task<IEnumerable<ManufacturerResource>> GetManufacturers() {
			var manufacturers = await _context.Manufacturers.Include(m => m.Models).ToListAsync();

			return mapper.Map<List<Manufacturer>, List<ManufacturerResource>>(manufacturers);
		}
	}
}
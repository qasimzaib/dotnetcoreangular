using AutoMapper;
using dotnetcoreangular.Controllers.Resources;
using dotnetcoreangular.Data.Entities;

namespace dotnetcoreangular.Data.Mapping {
	public class MappingProfile : Profile {
		public MappingProfile () {
			CreateMap<Manufacturer, ManufacturerResource>();
			CreateMap<Model, ModelResource>();
		}
	}
}
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace dotnetcoreangular.Controllers.Resources {
	public class ManufacturerResource {
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<ModelResource> Models { get; set; }

		public ManufacturerResource() {
			Models = new Collection<ModelResource>();
		}
	}
}
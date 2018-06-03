using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcoreangular.Data.Entities {
	[Table("Manufacturer")]	
	public class Manufacturer {
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Model> Models { get; set; }

		public Manufacturer() {
			Models = new Collection<Model> ();
		}
	}
}
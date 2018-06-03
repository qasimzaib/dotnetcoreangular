using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcoreangular.Data.Entities {
	[Table("Model")]
	public class Model {
		public int Id { get; set; }
		public string Name { get; set; }
		public int ManufacturerId { get; set; }
		public virtual Manufacturer Manufacturer { get; set; }
	}
}
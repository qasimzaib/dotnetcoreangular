namespace dotnetcoreangular.Data.Entities {
	public class Model {
		public int Id { get; set; }
		public string Name { get; set; }
		public int ManufacturerId { get; set; }
		public virtual Manufacturer Manufacturer { get; set; }
	}
}
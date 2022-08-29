using System.ComponentModel.DataAnnotations;

namespace actividad_1{
	public enum PolygonType{
		[Display(Name = "Círculo")]
		CYRCLE,
		[Display(Name = "Triángulo rectángulo")]
		TRIANGLERECTANGLE,
		[Display(Name = "Rectángulo")]
		RECTANGLE,
		[Display(Name = "Esfera")]
		SPHERE,
		[Display(Name = "Cilindro")]
		CYLINDER
	}
}
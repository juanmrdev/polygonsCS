namespace actividad_1{
	public class PolygonArea : PolygonOperation{

		void PolygonOperation.circleAreaSetup(PolygonType polygonType){
			string? polygonName = null;
			if(PolygonType.CYRCLE == polygonType)polygonName = "Círculo"; else polygonName = null;

			Console.WriteLine(
				"\nCálculo área de un {0}\n"+
				"Por favor digite el valor del radio del {0}:", polygonName
			); double radius = Convert.ToDouble(Console.ReadLine()); 

			double area = Math.PI * radius * radius;

			Console.WriteLine("El área del {1} es {0:0.00}", area, polygonName);
		}

		void PolygonOperation.triangleRectangleAreaSetup(PolygonType polygonType){
			string? polygonName = null;
			if(PolygonType.TRIANGLERECTANGLE == polygonType)polygonName = "Círculo"; else polygonName = null;

			Console.WriteLine(
				"\nCálculo área de un {0}\n"+
				"Por favor digite el valor de las base y altura del triángulo {0} respectivamente:", polygonName
			); double baseTriangle = Convert.ToDouble(Console.ReadLine()); double height = Convert.ToDouble(Console.ReadLine());

			double area = (baseTriangle * height) / 2;

			Console.WriteLine("El área del {1} es {0:0.00}", area, polygonName);
		}

		void PolygonOperation.rectangleAreaSetup(PolygonType polygonType){
			string? polygonName = null;
			if(PolygonType.RECTANGLE == polygonType)polygonName = "Círculo"; else polygonName = null;

			Console.WriteLine(
				"\nCálculo área de un {0}\n"+
				"Por favor digite el valor de los lados del {0}:", polygonName
			); double side1 = Convert.ToDouble(Console.ReadLine()); double side2 = Convert.ToDouble(Console.ReadLine());

			double area = side1 * side2;

			Console.WriteLine("El área del {1} es {0:0.00}", area, polygonName);
		}

		void PolygonOperation.sphereVolumeAreaSetup(PolygonType polygonType){
			string? polygonName = null;
			if(PolygonType.SPHERE == polygonType)polygonName = "Círculo"; else polygonName = null;

			Console.WriteLine(
				"\nCálculo volumen de una {0}\n"+
				"Por favor digite el valor del radio de la {0}:", polygonName
			); double radius = Convert.ToDouble(Console.ReadLine());

			double area = (4/3) * Math.PI * Math.Pow(radius, 3);

			Console.WriteLine("El volumen de la {1} es {0:0.00}", area, polygonName);
		}

		void PolygonOperation.cilynderVolumeAreaSetup(PolygonType polygonType){
			string? polygonName = null;
			if(PolygonType.CYLINDER == polygonType)polygonName = "Círculo"; else polygonName = null;

			Console.WriteLine(
				"\nCálculo volumen de una {0}\n"+
				"Por favor digite el valor del radio y la altura del {0} respectivamente:", polygonName
			); double radius = Convert.ToDouble(Console.ReadLine()); double height = Convert.ToDouble(Console.ReadLine());

			double area = Math.PI * Math.Pow(radius, 2) * height;

			Console.WriteLine("El volumen de la {1} es {0:0.00}", area, polygonName);
		}
	}
}
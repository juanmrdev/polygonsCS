namespace actividad_1{
	internal class Program
	{	
		public static int select;
		private static void Main(string[] args)
		{
			Console.WriteLine("BIENVENIDO/A\n");
			PolygonOperation polygon = new PolygonArea();
			setupViewConsole(polygon);
		}

		public static void setupViewConsole(PolygonOperation polygonOp){
			Console.WriteLine(
				"\nPrograma Para Cálculo De Áreas Y Volúmenes De Figuras Geométricas\n"+
				"\n1)  Cálculo área de un círculo\n"+
				"2)  Cálculo área de un triángulo rectángulo\n"+
				"3)  Cálculo área de un rectángulo\n"+
				"4)  Cálculo volumen de una esfera\n"+
				"5)  Cálculo volumen de una cilindro\n"+
				"\nSeleccione la opción correspondiente:"
			); select = Convert.ToInt16(Console.ReadLine());

			while(select != 0){
				switch(select)
				{
					case 1:
						polygonOp.circleAreaSetup(PolygonType.CYRCLE);
						continueOrNot(PolygonType.CYRCLE); break;
					case 2:
						polygonOp.triangleRectangleAreaSetup(PolygonType.TRIANGLERECTANGLE);
						continueOrNot(PolygonType.TRIANGLERECTANGLE); break;
					case 3:
						polygonOp.rectangleAreaSetup(PolygonType.RECTANGLE); 
						continueOrNot(PolygonType.RECTANGLE); break;
					case 4:
						polygonOp.sphereVolumeAreaSetup(PolygonType.SPHERE); 
						continueOrNot(PolygonType.SPHERE); break;
					case 5:
						polygonOp.cilynderVolumeAreaSetup(PolygonType.CYLINDER); 
						continueOrNot(PolygonType.CYLINDER); break;
					default: 
						Console.WriteLine("Digite una opción válida o digite 0 para finalizar.");
						select = Convert.ToInt16(Console.ReadLine());
					break;		
				}
			}		
		}

		public static void continueOrNot(PolygonType polygon){
			int positionPolygon = (int) polygon;

			select = 0;
			Console.WriteLine("\nDesea continuar? S/N"); ConsoleKeyInfo eventKey = Console.ReadKey();
			
			if (eventKey.Key == ConsoleKey.N){
				System.Environment.Exit(-1);
			} else if (eventKey.Key == ConsoleKey.S){
				Console.WriteLine();
				switch(positionPolygon){
					case 0: select = 1; break;
					case 1: select = 2; break;
					case 2: select = 3; break;
					case 3: select = 4; break;
					case 4: select = 5; break;
				}
			} else{
				continueOrNot(polygon);
				Console.WriteLine("\nDigite S/N.\n");
			}
		}
	}
}



namespace FigureArea
{
	public class FigureAreaCalculator
	{
		// Сделал через перегрузку методов из за пункта - "Вычисление площади фигуры без знания типа фигуры в compile-time"
		/// <summary>
		/// Calculates the area of a circle
		/// </summary>
		/// <param name="radius">Circle radius</param>
		/// <returns>Area of a circle</returns>
		public double CalculateArea(double radius)
		{
			double circleArea = Math.PI * (Math.Pow(radius, 2));
			return circleArea;
		}
		/// <summary>
		/// Calculates the area of a triangle given three sides
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns>Area of a triangle</returns>
		public double CalculateArea(double a, double b, double c, out bool isRightTriangle)
		{
			double p = (a + b + c) / 2;
			double triangleArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

			isRightTriangle = CheckRightTriangle(a, b, c);
			
			return triangleArea;
		}

		// Проверка на то, является ли треугольник прямоугольным
		private bool CheckRightTriangle(double a, double b, double c)
		{
			return ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b));
		}
	}
}
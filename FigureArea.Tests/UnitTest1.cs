namespace FigureArea.Tests
{
	public class FigureAreaTests
	{
		[Fact]
		public void TestCalculateCircleArea()
		{
			FigureAreaCalculator fiugreArea = new FigureAreaCalculator();

			double result = fiugreArea.CalculateArea(12.5);

			Assert.Equal(490.8738521234052, result);
		}

		[Fact]
		public void TestCalculateTriangleArea()
		{
			FigureAreaCalculator fiugreArea = new FigureAreaCalculator();

			double result = fiugreArea.CalculateArea(3, 4, 5, out bool isRightTriangle);

			Assert.Equal(6, result);
			Assert.True(isRightTriangle);
		}
	}
}
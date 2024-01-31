using FluentAssertions;
using MathUtility.Interfaces;
using MathUtility.Operators;

namespace MathUtility.Tests.OperatorsTests
{
	/*
	 * Unit tests requriements the following NuGet packages:
	 * FluentAssertions
	 * Xunit (should come pre-installed with Visual Studio)
	 */
	public class OperatorTests
	{
		[Theory]
		[InlineData(3, 3, 6)] // 3 + 3 = 6
		public void AdditionOperation_Calculate_ReturnsCorrectValue(double left, double right, double expectedResult)
		{
			// Arrange
			IOperator additionOperator = new AdditionOperation();

			// Act
			double result = additionOperator.Calculate(left, right);

			// Assert
			result.Should().Be(expectedResult);
		}

		[Theory]
		[InlineData(3, 3, 0)] // 3 - 3 = 0
		public void SubtractOperation_Calculate_ReturnsCorrectValue(double left, double right, double expectedResult)
		{
			// Arrange
			IOperator subtractOperator = new SubtractOperation();

			// Act
			double result = subtractOperator.Calculate(left, right);

			// Assert
			result.Should().Be(expectedResult);
		}

		[Theory]
		[InlineData(3, 3, 9)] // 3 * 3 = 9
		public void MultiplyOperation_Calculate_ReturnsCorrectValue(double left, double right, double expectedResult)
		{
			// Arrange
			IOperator multiplyOperator = new MultiplyOperation();

			// Act
			double result = multiplyOperator.Calculate(left, right);

			// Assert
			result.Should().Be(expectedResult);
		}

		[Theory]
		[InlineData(3, 2, 1.5)] // 3 / 2 = 1.5
		public void DivideOperation_Calculate_ReturnsCorrectValue(double left, double right, double expectedResult)
		{
			// Arrange
			IOperator divideOperator = new DivideOperation();

			// Act
			double result = divideOperator.Calculate(left, right);

			// Assert
			// using BeApproximately() to account for possible floating point errors
			result.Should().BeApproximately(expectedResult, 0.01);
		}
	}
}
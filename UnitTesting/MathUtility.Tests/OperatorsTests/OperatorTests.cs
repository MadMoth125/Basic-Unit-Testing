using MathUtility.Interfaces;
using MathUtility.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtility.Tests.OperatorsTests
{
	public class OperatorTests
	{
		[Fact]
		public void AdditionOperation_Calculate_ReturnsCorrectValue()
		{
			// Arrange
			double left = 3;
			double right = 2;
			IOperator additionOperator = new AdditionOperation();

			// Act
			double result = additionOperator.Calculate(left, right);

			// Assert
		}
	}
}

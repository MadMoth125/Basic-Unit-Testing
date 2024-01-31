using MathUtility.Interfaces;

namespace MathUtility.Operators
{
	public class MultiplyOperation : IOperator
	{
		public double Calculate(double left, double right)
		{
			return left * right;
		}
	}
}

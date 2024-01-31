using MathUtility.Interfaces;

namespace MathUtility.Operators
{
	public class DivideOperation : IOperator
	{
		public double Calculate(double left, double right)
		{
			return left / right;
		}
	}
}

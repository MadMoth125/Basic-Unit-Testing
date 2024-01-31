using MathUtility.Interfaces;

namespace MathUtility.Operators
{
	internal class SubtractOperation : IOperator
	{
		public double Calculate(double left, double right)
		{
			return left - right;
		}
	}
}
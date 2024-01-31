﻿using MathUtility.Interfaces;

namespace MathUtility.Operators
{
	public class SubtractOperation : IOperator
	{
		public double Calculate(double left, double right)
		{
			return left - right;
		}
	}
}
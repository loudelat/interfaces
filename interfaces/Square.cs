using System;
namespace interfaces
{
	public class Square : Shape
    {
		double length;

        // overloaded constructor
		public Square(double length)
        {
			this.length = length;
        }

        // interface method
        public double area()
		{
			// area = length * length
			return length * length;
		}
    }
}

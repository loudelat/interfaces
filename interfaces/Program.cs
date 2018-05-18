using System;
using System.Collections;
using System.Collections.Generic;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareLength = 19.50;
			Square sq = new Square(squareLength);

			double area = sq.area();
			Console.WriteLine(area);

			Teacher teacher = new Teacher("Tim Boyd", 35, "Math");

			teacher.sayHello();

			var animals = new ArrayList();
			animals.Add("horse");
			animals.Add("bird");
			animals.Add("dog");
			animals.Add("lion");

            foreach (var animal in animals)
			{
				Console.WriteLine(animal + " ");
			}

        }
    }
}

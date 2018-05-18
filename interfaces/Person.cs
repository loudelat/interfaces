using System;
namespace interfaces
{
    public abstract class Person
    {
		private string name;
		private int age;

		public Person(string name, int age)
        {
			this.name = name;
			this.age = age;
        }

        public void sayHello()
		{
			Console.WriteLine("Hello, my name is " + this.name);
		}

        public int getAge()
		{
			return this.age;
		}
    }
}

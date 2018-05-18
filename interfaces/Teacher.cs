using System;
namespace interfaces
{
	public class Teacher : Person
    {
		string subject;

		public Teacher(string name, int age, string subject)
			:base(name, age)
		{
			setSubject(subject);
        }

        public void setSubject(string subject)
		{
			this.subject = subject;
		}
    }
}

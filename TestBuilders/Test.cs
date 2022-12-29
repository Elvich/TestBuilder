using System;
namespace TestBuilders
{
	public class Test
	{
		private string _name;

		public List<Question> Questions = new List<Question>();
		public string Name { get { return _name; } }

		public Test(string name, List<Question> questions)
		{
			_name = name;
			Questions = questions;
		}
	}
}


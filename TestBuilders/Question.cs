using System;
namespace TestBuilders
{
	public struct Question
	{
		public string Text;
		public List<string> Answers = new List<string>();
		public string TrueAnswer;

		public Question(string qText, string trueAnswer, List<string> answers)
		{
			Text = qText;
			TrueAnswer = trueAnswer;
			Answers = answers;
		}
	}
}


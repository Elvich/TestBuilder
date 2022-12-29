using System.Collections.ObjectModel;

namespace TestBuilders;

public partial class CreateTests : ContentPage
{
	private string _name;

	private int _numberQustion = 0;

	private string _textQuestion = "";
	private string _correctAnswer = "";
	private List<string> _answer = new List<string>();
    ObservableCollection<string> _answerUi = new ObservableCollection<string>();
    private List<Question> _questions = new List<Question>();

    private void GetName(object sender, EventArgs e) => _textQuestion = ((Editor)sender).Text;
    private void GetCorrectAnswer(object sender, EventArgs e) => _correctAnswer = ((Entry)sender).Text;
	private void AddAnswer(object sender, EventArgs e)
	{
		_answer.Add(answer.Text);
		_answerUi.Add(answer.Text);
		answer.Text = "";
    }

	private void BackQuestion(object sender, EventArgs e)
	{
		if (_numberQustion > 0)
		{
			if (SaveQuestion())
			{
				_numberQustion--;
				Question question = _questions[_numberQustion];
				_textQuestion = question.Text;
				_correctAnswer = question.TrueAnswer;
				_answer = question.Answers;

				TextQuetion.Text = _textQuestion;
				CorrectAnswer.Text = _correctAnswer;
				for (int i = 0; i < _answer.Count; i++)
				{
					_answerUi.Add(_answer[i]);
					Console.Write(_answer[i]);
				}
			}
		}
	}

	private void NextQuestion(object sender, EventArgs e)
	{
		bool save = SaveQuestion();
		if(save)
			_numberQustion++;
	}

	private bool SaveQuestion()
	{
		if (_textQuestion != "" && _correctAnswer != "")
		{
			Question question = new Question(_textQuestion, _correctAnswer, _answer);
			if (_questions.Count <= _numberQustion)
				_questions.Add(question);
			else
				_questions[_numberQustion] = question;

			_answer.Clear();
			_answerUi.Clear();
			TextQuetion.Text = "";
			CorrectAnswer.Text = "";
			return true;
		}
		else
		{
			return false;
		}
    }

    public CreateTests()
	{
		InitializeComponent();
		ListAnswer.ItemsSource = _answerUi;
	}
}

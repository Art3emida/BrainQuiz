using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Brain_Quiz
{
    public partial class Game : Form
    {
        private MainMenu mainWnd;
        private string questionsFile = "Brain Quiz.quiz"; // файл с базой вопросов
        private const int secondsLimit = 30; // лимит времени на один вопрос
        private int score;
        private int percentage;
        private int totalQuestions;
        private int correctAnswer;
        private int currentQuestion = 0;
        private DateTime currentQuestionTime;
        private List<Question> QuestionsList;

        public Game(MainMenu wnd, string theme)
        {
            InitializeComponent();
            mainWnd = wnd;
            if (!File.Exists(questionsFile))
            {
                MessageBox.Show($"Файл с базой вопросов {questionsFile} - НЕ НАЙДЕН!");
                this.Close();
                wnd.Show();
                wnd.HideThemes();
                return;
            }
            LoadQuestionsFromFile(theme); // сразу загружаем вопросы из нашего файла
            NextQuestion(); // и выбираем первый вопрос
        }

        // Загрузка вопросов из файла (БД)
        void LoadQuestionsFromFile(string theme)
        {
            string fileText = File.ReadAllText(questionsFile);

            string[] questions = fileText.Split(new[] { "------------------------" }, StringSplitOptions.RemoveEmptyEntries);
            QuestionsList = new List<Question>();
            
            foreach (var item in questions)
            {
                string[] question = item.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                string questionTheme = question[0];
                if (questionTheme == theme)
                {
                    var questionItem = new Question(question[1], question[3], question[4], question[5], question[6], int.Parse(question[2]));
                    QuestionsList.Add(questionItem);
                }
            }

            totalQuestions = QuestionsList.Count;
        }

        // Выбор следующего вопроса
        void NextQuestion()
        {
            currentQuestion++;
            if (currentQuestion > totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Викторина окончена!" + Environment.NewLine +
                    "Вы дали " + score + " правильных ответов из " + totalQuestions + Environment.NewLine +
                    "Процент правильных ответов составляет " + percentage + "% " + Environment.NewLine +
                    "Нажмите ОК, чтобы вернуться в главное меню "
                    );
                this.Close();
                mainWnd.Show();
                mainWnd.HideThemes();
                return;
            }

            groupBox1.Text = "Вопрос #" + currentQuestion + "/" + totalQuestions;

            Random rnd = new Random();
            int randIndex = rnd.Next(0, QuestionsList.Count);

            Question questionData = QuestionsList[randIndex];

            QuestionField.Text = questionData.Text;
            Answer1.Text = questionData.Answer1;
            Answer2.Text = questionData.Answer2;
            Answer3.Text = questionData.Answer3;
            Answer4.Text = questionData.Answer4;
            correctAnswer = questionData.Correct;

            QuestionsList.RemoveAt(randIndex);

            currentQuestionTime = DateTime.Now;
            TimeLeft.Text = secondsLimit.ToString();
            QuestionTimer.Enabled = true;
        }

        // Клик по варианту ответа
        private void ChosenQuestion(object sender, EventArgs e)
        {
            var ButtonObj = (Button)sender;
            int ButtonTag = Convert.ToInt32(ButtonObj.Tag);

            if (ButtonTag == correctAnswer)
            {
                score++;
            }

            NextQuestion();
        }

        // При закрытии окна возвращаемся в главное меню
        private void OnWindowClose(object sender, FormClosingEventArgs e)
        {
            mainWnd.Show();
            mainWnd.HideThemes();
        }

        // Коллбэк на ежесекундный тик таймера
        private void QuestionTimerTick(object sender, EventArgs e)
        {
            TimeSpan ExecuteTime = DateTime.Now - currentQuestionTime;
            int elapsedSeconds = int.Parse(ExecuteTime.ToString("ss"));
            int diff = secondsLimit - elapsedSeconds;
            if (diff < 0)
            {
                TimeLeft.Text = "0";
                QuestionTimer.Enabled = false;
                NextQuestion();
                return;
            }
            TimeLeft.Text = diff.ToString();
        }
    }

    public class Question
    {
        public string Text;
        public string Answer1;
        public string Answer2;
        public string Answer3;
        public string Answer4;
        public int Correct;

        public Question(string text, string answer1, string answer2, string answer3, string answer4, int correct)
        {
            Text = text;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
            Correct = correct;
        }       
    }
}

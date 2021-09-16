using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brain_Quiz
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // Открытие окна помощи
        private void OpenHelpWindow(object sender, EventArgs e)
        {
            HelpScreen helpScreen = new HelpScreen(this);
            helpScreen.Show();
            this.Hide();
        }

        // Показ рубрик викторины
        private void ShowThemes(object sender, EventArgs e)
        {
            ButtonStart.Visible = false;
            ButtonLoadTheme2.Visible = true;
            ButtonLoadTheme1.Visible = true;
        }

        // Скрытие рубрик викторины
        public void HideThemes()
        {
            ButtonStart.Visible = true;
            ButtonLoadTheme2.Visible = false;
            ButtonLoadTheme1.Visible = false;
        }

        // Запуск игры и передача выбранной рубрики
        private void StartGame(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string gameTheme = (string)button.Tag;
            Game game = new Game(this, gameTheme);
            if (!game.IsDisposed)
            {
                game.Show();
                this.Hide();
            }
        }

        // Выход из программы
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

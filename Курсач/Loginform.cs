using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace Курсач
{
    public partial class LoginForm : Form
    {

        public int UserId { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            this.PassField.Size = new Size(this.PassField.Size.Width, 37);
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseWindow_MouseEnter(object sender, EventArgs e)
        {
            CloseWindow.ForeColor = Color.Green;
        }

        private void CloseWindow_MouseLeave(object sender, EventArgs e)
        {
            CloseWindow.ForeColor = Color.White;
        }

        Point LastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void Button_registr_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterForm registerForm = new RegisterForm();

                // Подписываемся на событие FormClosed
                registerForm.FormClosed += (s, args) =>
                {
                    if (registerForm.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                };

                this.Hide();

                registerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void ButtonAuth_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "" || PassField.Text == "")
            {
                MessageBox.Show("Ошибка: пустые поля");
            }
            else
            {
                DBHelper dbHelperLogin = new DBHelper();
                int userId = dbHelperLogin.GetUserId(LoginField.Text, PassField.Text);

                if (userId != -1)
                {
                    // Передаем userId в конструктор MainForm
                    var mainForm = new MainForm(userId);

                    // Устанавливаем DialogResult в OK
                    this.DialogResult = DialogResult.OK;

                    var mainDialogResult = mainForm.ShowDialog();

                    // Убедимся, что результат диалога обрабатывается правильно
                    if (mainDialogResult == DialogResult.OK)
                    {
                        this.Close(); // Закрытие формы авторизации после успешного входа
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel; // Обработка других возможных результатов диалога
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: пользователь не найден");
                }
            }
        }
    }
}

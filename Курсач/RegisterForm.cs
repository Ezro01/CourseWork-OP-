using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Курсач
{
    public partial class RegisterForm : Form
    {
        public SQLiteConnection bd;

        public RegisterForm()
        {
            InitializeComponent();
            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 37);
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
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void Close_Window_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonHaveACC_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm loginForm = new LoginForm();

                // Подписываемся на событие FormClosed
                loginForm.FormClosed += (s, args) =>
                {
                    if (loginForm.DialogResult == DialogResult.OK)
                    {
                        this.Close(); // Скрываем текущую форму регистрации при успешном входе
                    }
                };

                this.Hide();

                loginForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginField.Text == "" || PassField.Text == "")
                {
                    MessageBox.Show("Ошибка: пустые поля");
                }
                else
                {
                    string password = PassField.Text;

                    // Проверка на минимальное количество символов в пароле
                    if (password.Length < 6)
                    {
                        MessageBox.Show("Ошибка: Пароль должен содержать как минимум 6 символов.");
                        return;
                    }

                    DBHelper dbHelperRegister = new DBHelper();

                    // Вызываем кастомный метод регистрации
                    DialogResult registrationResult = dbHelperRegister.RegisterUser(LoginField.Text, password);

                    if (registrationResult == DialogResult.OK)
                    {
                        MessageBox.Show("Регистрация успешна");

                        // Получаем userId после успешной регистрации
                        int userId = dbHelperRegister.GetUserId(LoginField.Text, password);

                        // После успешной регистрации открываем MainForm, передавая userId
                        MainForm mainform = new MainForm(userId);

                        // Подписываемся на событие FormClosed
                        mainform.FormClosed += (s, args) =>
                        {
                            if (mainform.DialogResult == DialogResult.OK)
                            {
                                this.Close(); // Закрываем текущую форму регистрации при успешном входе
                            }
                        };

                        mainform.Show();

                        // Закрываем текущую форму (регистрации)
                        this.Hide();
                    }
                    else if (registrationResult == DialogResult.No)
                    {
                        MessageBox.Show("Ошибка: пользователь с таким логином уже существует");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка регистрации: {ex.Message}");
            }
        }
    }
}

using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace Курсач
{
    public partial class MainForm : Form
    {
        public SQLiteConnection bd;

        public int UserId { get; private set; }

        public MainForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }


        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        public bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public void Resh_bt_Click(object sender, EventArgs e)
        {
            try
            {
                Atk atk = new Atk();
                int limit = int.Parse(n_txt.Text);
                var primes = atk.FindPrimes(limit.ToString());


                // Получите UserId из MainForm, предполагая, что MainForm - это ваш экземпляр формы
                int userId = this.UserId;

                // Сохраните простые числа в базу данных
                DBHelper dbHelper = new DBHelper();
                dbHelper.SavePrimesForUser(limit, userId);
                MessageBox.Show("Простые числа успешно сохранены в базе данных для пользователя с ID = " + userId);

                // Очистите DataGridView
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                int gridSize = (int)Math.Ceiling(Math.Sqrt(limit));

                // Создайте необходимое количество столбцов
                for (int i = 0; i < gridSize; i++)
                {
                    dataGridView1.Columns.Add("", "");
                    dataGridView1.Columns[i].Width = 50; // Установите желаемую ширину столбца
                }

                // Создайте необходимое количество строк
                for (int i = 0; i < gridSize; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Height = 50; // Установите желаемую высоту строки
                }

                // Добавьте числа в DataGridView
                int count = 0;
                for (int i = 0; i < gridSize; i++)
                {
                    for (int j = 0; j < gridSize; j++)
                    {
                        count++;
                        if (count <= limit)
                        {
                            // Запишите число в ячейку
                            dataGridView1.Rows[i].Cells[j].Value = count;

                            // Проверьте, является ли число простым
                            if (IsPrime(count))
                            {
                                // Если число простое, оставьте ячейку незакрашенной
                                dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                            }
                            else
                            {
                                // Если число не простое, закрасьте ячейку
                                dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                            }
                        }
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Некорректный ввод.\nВведите натуральное число >= 2.\n");
            }
            catch
            {
                MessageBox.Show("Программа успешно выполнила работу\n");
            }
        }



        private void Save_bt_Click(object sender, EventArgs e)
        {
            SavePhoto savePhoto = new SavePhoto();
            Bitmap img = savePhoto.ParametorsPhoto(dataGridView1);

            SaveFileDialog sd = savePhoto.SavePicture();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    img.Save(sd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show("Успешно сохранено");
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
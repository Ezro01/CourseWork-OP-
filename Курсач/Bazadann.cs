using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Input;

namespace Курсач
{
    public class DBHelper
    {
        public SQLiteConnection bd;

        public static void CreateDatabase()
        {
            if (!File.Exists("bd.db"))
            {
                SQLiteConnection.CreateFile("bd.db");

                using (var connection = new SQLiteConnection("Data Source=bd.db;Version=3;"))
                {
                    connection.Open();

                    // Создаем таблицу users
                    using (var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, login TEXT, hash TEXT);", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Создаем таблицу numbers
                    using (var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS numbers (id INTEGER PRIMARY KEY, user_id INTEGER, chislo INTEGER);\r\n", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("База данных создана успешно.");
            }
            else
            {
                MessageBox.Show("База данных уже существует.");
            }
        }

        public void SavePrimesForUser(int limit, int userId)
        {
            Atk atk = new Atk();
            string primesString = atk.FindPrimes(limit.ToString());

            SQLiteConnection bd = new SQLiteConnection("DataSource=bd.db; Version=3");
            bd.Open();

            // Добавляем простые числа в таблицу numbers с указанием user_id
            using (SQLiteCommand cmdNumbers = bd.CreateCommand())
            {
                cmdNumbers.CommandText = "INSERT INTO numbers (user_id, chislo) VALUES (@UserId, @Chislo)";
                cmdNumbers.Parameters.Add("@UserId", DbType.Int32).Value = userId;

                foreach (var chislo in primesString.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (int.TryParse(chislo, out int parsedChislo))
                    {
                        cmdNumbers.Parameters.Clear();
                        cmdNumbers.Parameters.Add("@UserId", DbType.Int32).Value = userId;
                        cmdNumbers.Parameters.Add("@Chislo", DbType.Int32).Value = parsedChislo;
                        cmdNumbers.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка парсинга числа: {chislo}");
                    }
                }
            }
        }


        public void RegisterFormBD(string LoginField, string PassField)
        {
            SQLiteConnection bd = new SQLiteConnection("DataSource=bd.db; Version=3");
            bd.Open();
            Hashing hashing = new Hashing();

            SQLiteCommand comand = bd.CreateCommand();
            comand.CommandText = "INSERT INTO users (login, hash) VALUES (@Login, @Password)";
            comand.Parameters.Add("@Login", DbType.String).Value = LoginField;
            comand.Parameters.Add("@Password", DbType.String).Value = hashing.Hash(PassField);
            comand.ExecuteScalar();
        }

        public DialogResult RegisterUser(string login, string password)
        {
            // Проверяем, есть ли уже пользователь с таким логином
            DataTable existingUser = CheckExistingUser(login);

            if (existingUser.Rows.Count > 0)
            {
                return DialogResult.No; // Пользователь с таким логином уже существует
            }
            else
            {
                // Добавляем нового пользователя в базу данных
                RegisterFormBD(login, password);
                return DialogResult.OK; // Регистрация успешна
            }
        }

        public DataTable CheckExistingUser(string login)
        {
            using (SQLiteConnection bd = new SQLiteConnection("DataSource=bd.db; Version=3"))
            {
                bd.Open();
                SQLiteCommand command = bd.CreateCommand();
                command.CommandText = "SELECT * FROM users WHERE login = @Login";
                command.Parameters.Add("@Login", DbType.String).Value = login;

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);

                return resultTable;
            }
        }

        public DataTable LoginFormBD(string LoginField, string PassField)
        {
            SQLiteConnection bd = new SQLiteConnection("DataSource=bd.db; Version=3; New = False");
            bd.Open();
            Hashing hashing = new Hashing();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            DataTable Table = new DataTable();

            SQLiteCommand comand = bd.CreateCommand();
            comand.CommandText = "SELECT * FROM users WHERE login = @LOG AND hash = @PASS";
            comand.Parameters.Add("@LOG", DbType.String).Value = LoginField;
            comand.Parameters.Add("@PASS", DbType.String).Value = hashing.Hash(PassField);
            adapt.SelectCommand = comand;
            adapt.Fill(Table);
            return Table;
        }

        public int GetUserId(string login, string password)
        {
            SQLiteConnection bd = new SQLiteConnection("DataSource=bd.db; Version=3; New = False");
            bd.Open();
            Hashing hashing = new Hashing();

            SQLiteCommand command = bd.CreateCommand();
            command.CommandText = "SELECT id FROM users WHERE login = @LOG AND hash = @PASS";
            command.Parameters.Add("@LOG", DbType.String).Value = login;
            command.Parameters.Add("@PASS", DbType.String).Value = hashing.Hash(password);

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int userId))
            {
                return userId;
            }

            return -1; // Возвращаем -1, если пользователь не найден
        }
    }
}

using System;
using System.Windows.Forms;
using HrApp.Utils;

namespace HrApp.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            roleComboBox.Items.AddRange(new string[] { "Admin", "User" });
            roleComboBox.SelectedIndex = 0;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Получение данных из полей
            var username = this.loginTextBox.Text;
            if (!username.CheckString("Введите логин"))
            {
                return;
            }

            var password = this.passwordTextBox.Text;
            if (!password.CheckString("Введите пароль"))
            {
                return;
            }

            var fullName = this.fullNameTextBox.Text;
            if (!fullName.CheckString("Введите полное имя"))
            {
                return;
            }

            var role = this.roleComboBox.SelectedItem?.ToString() ?? "None";

            // Проверка уникальности логина
            if (SQLService.getShared().users.Exists(x => x.Username == username))
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }

            // Генерация соли и хеша пароля
            var salt = PasswordHasher.GenerateSalt();
            var passwordHash = PasswordHasher.HashPassword(password, salt);

            // Добавление нового пользователя в базу данных
            SQLService.getShared().InsertIntoTable("Users", new Dictionary<string, object>
            {
                { "Username", username },
                { "Password", passwordHash },
                { "Salt", salt },
                { "FullName", fullName },
                { "Role", role }
            });

            // Обновление списка пользователей
            SQLService.getShared().fetchUsers();

            MessageBox.Show("Регистрация прошла успешно!");
            this.Close();
        }
    }
}

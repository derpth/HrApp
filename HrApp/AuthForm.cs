using HrApp.Forms;
using HrApp.Forms.Vacancies;
using HrApp.Utils;
using System.Windows.Forms;

namespace HrApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            var username = loginTextBox.Text;
            var password = passwordTextBox.Text;

            if (username.CheckString("Введите логин") && password.CheckString("Введите пароль"))
            {
                var user = SQLService.getShared().users.Find(x => x.Username == username);

                if (user == null || !PasswordHasher.VerifyPassword(password, user.PasswordHash, user.Salt))
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
                else
                {
                    // Определяем, какую форму открывать
                    Form nextForm;
                    if (user.Role == Role.Admin)
                    {
                        nextForm = new MenuForm(user);
                    }
                    else
                    {
                        nextForm = new VacancyMenuForm(true);
                    }

                    // Подписываемся на событие закрытия следующей формы
                    nextForm.FormClosed += (s, args) =>
                    {
                        // Показываем текущую форму при закрытии
                        this.Show();
                    };

                    this.Hide(); // Скрываем текущую форму
                    nextForm.Show(); // Показываем следующую форму
                }
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}

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

            if (username.CheckString("������� �����") && password.CheckString("������� ������"))
            {
                var user = SQLService.getShared().users.Find(x => x.Username == username);

                if (user == null || !PasswordHasher.VerifyPassword(password, user.PasswordHash, user.Salt))
                {
                    MessageBox.Show("������������ ����� ��� ������");
                }
                else
                {
                    // ����������, ����� ����� ���������
                    Form nextForm;
                    if (user.Role == Role.Admin)
                    {
                        nextForm = new MenuForm(user);
                    }
                    else
                    {
                        nextForm = new VacancyMenuForm(true);
                    }

                    // ������������� �� ������� �������� ��������� �����
                    nextForm.FormClosed += (s, args) =>
                    {
                        // ���������� ������� ����� ��� ��������
                        this.Show();
                    };

                    this.Hide(); // �������� ������� �����
                    nextForm.Show(); // ���������� ��������� �����
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

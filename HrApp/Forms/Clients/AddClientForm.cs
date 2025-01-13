using System;
using System.Windows.Forms;
using HrApp;

namespace HrApp.Forms.Clients
{
    public partial class AddClientForm : Form
    {
        public Client ClientData { get; private set; } // Хранение данных клиента

        public AddClientForm(Client client = null)
        {
            InitializeComponent();

            // Инициализация данных клиента
            if (client != null)
            {
                ClientData = (Client)client.Clone(); // Клонируем объект для редактирования
                PopulateFields(client); // Заполняем поля формы
            }
            else
            {
                ClientData = new Client(); // Создаём нового клиента
                ClientData.ClientID = -1;
            }
        }

        private void PopulateFields(Client client)
        {
            // Заполняем текстовые поля данными клиента
            titleTextBox.Text = client.CompanyName;
            contactPersonTextBox.Text = client.ContactPerson;
            phoneNumberTextBox.Text = client.Phone;
            emailTextBox.Text = client.Email;
            addressTextBox.Text = client.Address;
            notesRichTextBox.Text = client.Notes;
            isActiveCheckBox.Checked = client.IsActive;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка обязательных полей
                if (string.IsNullOrWhiteSpace(titleTextBox.Text))
                {
                    MessageBox.Show("Введите название компании.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(contactPersonTextBox.Text))
                {
                    MessageBox.Show("Введите имя контактного лица.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
                {
                    MessageBox.Show("Введите номер телефона.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Заполняем объект клиента
                ClientData.CompanyName = titleTextBox.Text;
                ClientData.ContactPerson = contactPersonTextBox.Text;
                ClientData.Phone = phoneNumberTextBox.Text;
                ClientData.Email = string.IsNullOrWhiteSpace(emailTextBox.Text) ? null : emailTextBox.Text;
                ClientData.Address = string.IsNullOrWhiteSpace(addressTextBox.Text) ? null : addressTextBox.Text;
                ClientData.Notes = string.IsNullOrWhiteSpace(notesRichTextBox.Text) ? null : notesRichTextBox.Text;
                ClientData.IsActive = isActiveCheckBox.Checked;

                // Подключение к базе данных
                var sqlService = SQLService.getShared();

                if (ClientData.ClientID == -1) // Новый клиент
                {
                 //   SQLService.getShared().insertValuesInTable("Clients", "CompanyName, ContactPerson, Phone, Email, Address, Notes, DateAdded, IsActive", $"{ClientData.CompanyName.PrepareSqlString}, {ClientData.ContactPerson.PrepareSqlString}, {ClientData.Phone.PrepareSqlString}, {ClientData.Email.PrepareSqlString}, {ClientData.Address.PrepareSqlString}, {ClientData.Notes.PrepareSqlString}, {ClientData.DateAdded}, {ClientData.IsActive}");
                    
                    sqlService.InsertIntoTable("Clients", new Dictionary<string, object>
            {
                { "CompanyName", ClientData.CompanyName },
                { "ContactPerson", ClientData.ContactPerson },
                { "Phone", ClientData.Phone },
                { "Email", ClientData.Email },
                { "Address", ClientData.Address },
                { "Notes", ClientData.Notes },
                { "DateAdded", DateTime.Now },
                { "IsActive", ClientData.IsActive }
            });

                    MessageBox.Show("Клиент успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Обновление клиента
                {
                    sqlService.UpdateTable("Clients", new Dictionary<string, object>
            {
                { "CompanyName", ClientData.CompanyName },
                { "ContactPerson", ClientData.ContactPerson },
                { "Phone", ClientData.Phone },
                { "Email", ClientData.Email },
                { "Address", ClientData.Address },
                { "Notes", ClientData.Notes },
                { "IsActive", ClientData.IsActive }
            }, $"ClientID = {ClientData.ClientID}");

                    MessageBox.Show("Клиент успешно обновлён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Закрываем форму
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

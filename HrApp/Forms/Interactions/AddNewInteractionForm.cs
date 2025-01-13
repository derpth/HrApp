using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HrApp.Forms.Interactions
{
    public partial class AddNewInteractionForm : Form
    {
        private int? clientId; // ID клиента (опционально, если передано)

        // Конструктор без параметров
        public AddNewInteractionForm()
        {
            InitializeComponent();

            // Загрузка списка клиентов при загрузке формы
            this.Load += (s, e) => LoadClients();
        }

        // Конструктор с параметром clientId
        public AddNewInteractionForm(int clientId) : this()
        {
            this.clientId = clientId;
        }

        private void LoadClients()
        {
            try
            {
                // Получаем список клиентов из базы
                var clients = SQLService.getShared().fetchClients();

                if (clients != null && clients.Count > 0)
                {
                    clientComboBox.DataSource = clients;
                    clientComboBox.DisplayMember = "CompanyName"; // Название компании
                    clientComboBox.ValueMember = "ClientID"; // ID компании

                    // Если clientId передан в конструкторе, выбираем соответствующего клиента
                    if (clientId.HasValue)
                    {
                        clientComboBox.SelectedValue = clientId.Value;
                        clientComboBox.Enabled = false; // Блокируем изменение, если клиент выбран заранее
                    }
                }
                else
                {
                    MessageBox.Show("Нет доступных клиентов для выбора.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка клиентов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(interactionDetailsRichTextBox.Text) || clientComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента и введите детали взаимодействия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Получение данных из формы
                var selectedClientId = (int)clientComboBox.SelectedValue;
                var interactionDate = interactionDateTimePicker.Value;
                var details = interactionDetailsRichTextBox.Text;

                // Добавление в базу данных
                SQLService.getShared().InsertIntoTable("Interactions", new Dictionary<string, object>
                {
                    { "ClientID", selectedClientId },
                    { "InteractionDate", interactionDate },
                    { "Details", details }
                });

                MessageBox.Show("Взаимодействие успешно добавлено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления взаимодействия: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

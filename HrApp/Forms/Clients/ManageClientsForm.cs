using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HrApp;

namespace HrApp.Forms.Clients
{
    public partial class ManageClientsForm : Form
    {
        private List<Client> clients = new List<Client>();

        public ManageClientsForm()
        {
            InitializeComponent();
            ConfigureDataGridView(); // Настройка таблицы
            LoadClients();           // Загрузка данных
        }

        private void ConfigureDataGridView()
        {
            clientDataGridView.Columns.Clear();

            clientDataGridView.Columns.Add("ClientID", "ID");
            clientDataGridView.Columns.Add("CompanyName", "Название компании");
            clientDataGridView.Columns.Add("ContactPerson", "Контактное лицо");
            clientDataGridView.Columns.Add("Phone", "Телефон");
            clientDataGridView.Columns.Add("Email", "Email");
            clientDataGridView.Columns.Add("Address", "Адрес");
            clientDataGridView.Columns.Add("Notes", "Заметки");
            clientDataGridView.Columns.Add("DateAdded", "Дата добавления");
            clientDataGridView.Columns.Add("IsActive", "Статус");

            // Настройка автоматического изменения размеров колонок и строк
            clientDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Настройка выравнивания содержимого в ячейках
            var cellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter, // Центровка текста
                WrapMode = DataGridViewTriState.True                   // Перенос текста
            };
            clientDataGridView.DefaultCellStyle = cellStyle;

            // Настройка выравнивания заголовков
            var headerStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            clientDataGridView.ColumnHeadersDefaultCellStyle = headerStyle;

            // Настройка изменения размеров при изменении размера формы
            this.Resize += (s, e) => AdjustDataGridViewSize();
        }

        private void AdjustDataGridViewSize()
        {
            clientDataGridView.Width = this.ClientSize.Width - 40;
            clientDataGridView.Height = this.ClientSize.Height - clientDataGridView.Top - 60;
        }

        private void LoadClients()
        {
            try
            {
                clients = SQLService.getShared().fetchClient();
                FillDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDataGrid()
        {
            clientDataGridView.Rows.Clear();

            foreach (var client in clients)
            {
                clientDataGridView.Rows.Add(
                    client.ClientID,
                    client.CompanyName,
                    client.ContactPerson,
                    client.Phone,
                    client.Email ?? "—",
                    client.Address ?? "—",
                    client.Notes ?? "—",
                    client.DateAdded.ToString("yyyy-MM-dd"),
                    client.IsActive ? "Активен" : "Неактивен"
                );
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var form = new AddClientForm();
            form.FormClosed += (s, args) => LoadClients();
            form.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count > 0)
            {
                var selectedRowIndex = clientDataGridView.SelectedRows[0].Index;
                var selectedClient = clients[selectedRowIndex];

                var form = new AddClientForm(selectedClient);
                form.FormClosed += (s, args) => LoadClients();
                form.Show();
            }
            else
            {
                MessageBox.Show("Выберите клиента для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count > 0)
            {
                var selectedRowIndex = clientDataGridView.SelectedRows[0].Index;
                var selectedClient = clients[selectedRowIndex];

                var confirmResult = MessageBox.Show(
                    $"Вы уверены, что хотите удалить клиента \"{selectedClient.CompanyName}\"?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        SQLService.getShared().DeleteRow("Clients", $"ClientID = {selectedClient.ClientID}");
                        LoadClients();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка удаления клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void historyOfInteractionsButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count > 0)
            {
                // Получение ClientID из выбранной строки в DataGridView
                var selectedRowIndex = clientDataGridView.SelectedRows[0].Index;
                var clientId = Convert.ToInt32(clientDataGridView.Rows[selectedRowIndex].Cells["ClientID"].Value);

                // Открытие формы истории взаимодействий
                var form = new ClientHistoryForm(clientId);
                form.Show();
            }
            else
            {
                MessageBox.Show("Выберите клиента для просмотра истории взаимодействий.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

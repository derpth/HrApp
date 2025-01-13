using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HrApp;
using HrApp.Forms.Interactions;

namespace HrApp.Forms.Clients
{
    public partial class ClientHistoryForm : Form
    {
        private readonly int clientId; // ID клиента
        private List<Interaction> interactions; // Список взаимодействий с клиентом

        public ClientHistoryForm(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.interactions = new List<Interaction>();

            // Загрузка взаимодействий при открытии формы
            this.Load += ClientHistoryForm_Load;

            // Обработка нажатий на кнопки
            addButton.Click += AddInteractionButton_Click;
            deleteButton.Click += DeleteInteractionButton_Click;

            // Изменение размеров DataGridView при изменении размеров формы
            this.Resize += (s, e) => AdjustDataGridViewSize();
        }

        private void ClientHistoryForm_Load(object sender, EventArgs e)
        {
            LoadInteractions();
            AdjustDataGridViewSize();
        }

        private void LoadInteractions()
        {
            try
            {
                // Получение взаимодействий из базы данных
                interactions = SQLService.getShared().FetchInteractions(clientId);

                // Заполнение таблицы
                clientHistoryDataGridView.Rows.Clear();
                foreach (var interaction in interactions)
                {
                    clientHistoryDataGridView.Rows.Add(
                        interaction.InteractionID,
                        interaction.InteractionDate.ToString("yyyy-MM-dd"),
                        interaction.Details
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных взаимодействий: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdjustDataGridViewSize()
        {
            // Установка размеров DataGridView в зависимости от размеров формы
            clientHistoryDataGridView.Width = this.ClientSize.Width - 40;
            clientHistoryDataGridView.Height = this.ClientSize.Height - clientHistoryDataGridView.Top - 60;

            // Включение автоматической подстройки ширины колонок и высоты строк
            clientHistoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientHistoryDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Настройка выравнивания содержимого в ячейках
            var cellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter, // Выравнивание по центру
                WrapMode = DataGridViewTriState.True // Перенос текста
            };
            clientHistoryDataGridView.DefaultCellStyle = cellStyle;

            // Настройка выравнивания заголовков
            var headerStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter // Выравнивание заголовков по центру
            };
            clientHistoryDataGridView.ColumnHeadersDefaultCellStyle = headerStyle;

            // Подгонка размеров
            clientHistoryDataGridView.AutoResizeColumns();
            clientHistoryDataGridView.AutoResizeRows();
        }


        private void AddInteractionButton_Click(object sender, EventArgs e)
        {
            // Открытие формы для добавления нового взаимодействия
            var addInteractionForm = new AddNewInteractionForm(clientId);
            if (addInteractionForm.ShowDialog() == DialogResult.OK)
            {
                LoadInteractions(); // Обновление данных после добавления
            }
        }

        private void DeleteInteractionButton_Click(object sender, EventArgs e)
        {
            if (clientHistoryDataGridView.SelectedRows.Count > 0)
            {
                var selectedRowIndex = clientHistoryDataGridView.SelectedRows[0].Index;
                if (clientHistoryDataGridView.Rows[selectedRowIndex].Cells[0].Value != null)
                {
                    var interactionId = (int)clientHistoryDataGridView.Rows[selectedRowIndex].Cells[0].Value;

                    var confirmResult = MessageBox.Show(
                        "Вы уверены, что хотите удалить выбранное взаимодействие?",
                        "Подтверждение удаления",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            SQLService.getShared().DeleteRow("Interactions", $"InteractionID = {interactionId}");
                            LoadInteractions(); // Обновление данных после удаления
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка удаления взаимодействия: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось получить ID взаимодействия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выберите взаимодействие для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

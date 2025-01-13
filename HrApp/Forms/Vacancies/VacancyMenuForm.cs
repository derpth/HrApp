using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HrApp.Forms.Candidates;

namespace HrApp.Forms.Vacancies
{
    public partial class VacancyMenuForm : Form
    {
        public List<Vacancy> vacancies = new List<Vacancy>();
        public bool isUser = false;

        public VacancyMenuForm(bool isUser = false)
        {
            InitializeComponent();

            // Загружаем данные из базы данных через SQLService
            SQLService.getShared().fetchVacancies();

            // Сохраняем список вакансий из SQLService
            this.vacancies = SQLService.getShared().vacancies;

            // Настраиваем DataGridView
            SetupDataGridView();

            // Заполняем DataGridView
            this.fillDataGrid();

            this.isUser = isUser;
            if (isUser)
            {
                this.addNewVacancyButton.Visible = false;
                this.editVacancyButton.Visible = false;
                this.deleteVacancyButton.Visible = false;
            }
        }

        private void SetupDataGridView()
        {
            vacancyDataGridView.Columns.Clear();

            // Добавляем столбцы
            vacancyDataGridView.Columns.Add("Title", "Название");
            vacancyDataGridView.Columns.Add("ClientId", "ID Клиента");
            vacancyDataGridView.Columns.Add("Description", "Описание");
            vacancyDataGridView.Columns.Add("Requirements", "Требования");
            vacancyDataGridView.Columns.Add("SalaryRange", "Зарплата");
            vacancyDataGridView.Columns.Add("Status", "Статус");
            vacancyDataGridView.Columns.Add("StartDate", "Дата начала");
            vacancyDataGridView.Columns.Add("EndDate", "Дата окончания");

            // Устанавливаем свойства
            vacancyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            vacancyDataGridView.AllowUserToAddRows = false;
            vacancyDataGridView.ReadOnly = true;
        }

        private void fillDataGrid()
        {
            // Очищаем текущие строки в DataGridView
            vacancyDataGridView.Rows.Clear();

            // Перебираем список вакансий и добавляем их в DataGridView
            foreach (var vacancy in this.vacancies)
            {
                var rowIndex = vacancyDataGridView.Rows.Add();

                // Заполняем ячейки строки
                vacancyDataGridView.Rows[rowIndex].Cells[0].Value = vacancy.Title;
                vacancyDataGridView.Rows[rowIndex].Cells[1].Value = vacancy.ClientID;
                vacancyDataGridView.Rows[rowIndex].Cells[2].Value = vacancy.Description ?? "N/A";
                vacancyDataGridView.Rows[rowIndex].Cells[3].Value = vacancy.Requirements ?? "N/A";
                vacancyDataGridView.Rows[rowIndex].Cells[4].Value = vacancy.SalaryRange ?? "N/A";
                vacancyDataGridView.Rows[rowIndex].Cells[5].Value = vacancy.Status;
                vacancyDataGridView.Rows[rowIndex].Cells[6].Value = vacancy.StartDate;
                vacancyDataGridView.Rows[rowIndex].Cells[7].Value = vacancy.EndDate ?? "N/A";
            }
        }

        private void addNewVacancyButton_Click(object sender, EventArgs e)
        {
            // Открываем форму для создания вакансии
            var form = new CreateVacancyForm();
            form.FormClosed += (s, args) => RefreshDataGrid();
            form.Show();
        }

        /*private void editVacancyButton_Click(object sender, EventArgs e)
        {
            if (vacancyDataGridView.SelectedRows.Count > 0)
            {
                // Открываем форму для редактирования вакансии
                var form = new CreateVacancyForm(this.vacancies[vacancyDataGridView.SelectedRows[0].Index]);
                form.FormClosed += (s, args) => RefreshDataGrid();
                form.Show();
            }
        }
        */

        private void editVacancyButton_Click(object sender, EventArgs e)
        {
            if (vacancyDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = vacancyDataGridView.SelectedRows[0].Index;
                var vacancy = this.vacancies[selectedRowIndex];

                var form = new CreateVacancyForm(vacancy);
                form.FormClosed += (s, e) => RefreshDataGrid();
                form.Show();
            }
        }

        /* public void RefreshDataGrid()
         {
             // Обновляем данные и DataGridView
             SQLService.getShared().fetchVacancies();
             this.vacancies = SQLService.getShared().vacancies;
             this.fillDataGrid();
         }
        */

        public void RefreshDataGrid()
        {
            SQLService.getShared().fetchVacancies();
            this.vacancies = SQLService.getShared().vacancies;
            this.fillDataGrid();
        }

        private void deleteVacancyButton_Click(object sender, EventArgs e)
        {
            if (vacancyDataGridView.SelectedRows.Count > 0)
            {
                var selectedRowIndex = vacancyDataGridView.SelectedRows[0].Index;
                var vacancyId = vacancies[selectedRowIndex].Id;

                var confirmResult = MessageBox.Show(
                    "Вы уверены, что хотите удалить эту вакансию?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    SQLService.getShared().DeleteRow("Vacancies", $"VacancyID = {vacancyId}");
                    SQLService.getShared().fetchVacancies();
                    this.vacancies = SQLService.getShared().vacancies;
                    this.fillDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Выберите вакансию для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VacancyMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.isUser)
            {
                Environment.Exit(0);
            }
        }
    }
}

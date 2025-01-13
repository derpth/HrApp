using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HrApp.Forms.Candidates
{
    public partial class EditCandidateForm : Form
    {
        private List<Candidate> candidates = new List<Candidate>();
        private List<Candidate> candidatesToShow = new List<Candidate>();

        public EditCandidateForm()
        {
            InitializeComponent();
            ConfigureDataGridView(); // Настройка DataGridView
            ReloadCandidates();
        }

        private void ReloadCandidates()
        {
            SQLService.getShared().fetchCandidates();
            this.candidates = SQLService.getShared().candidates;
            this.candidatesToShow = this.candidates;
            this.fillDataGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new AddCandidateForm();

            // Обработчик события FormClosed для обновления таблицы
            form.FormClosed += (s, args) => ReloadCandidates();
            form.Show();
        }

        private void fillDataGrid()
        {
            editDataGridView.Rows.Clear();

            foreach (var candidate in this.candidatesToShow)
            {
                editDataGridView.Rows.Add(
                    candidate.initials,
                    candidate.phoneNumber ?? "—",
                    candidate.email,
                    candidate.jobName
                );
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (editDataGridView.SelectedRows.Count > 0)
            {
                var selectedCandidate = this.candidates[editDataGridView.SelectedRows[0].Index];
                var form = new AddCandidateForm(selectedCandidate);

                // Обработчик события FormClosed для обновления таблицы
                form.FormClosed += (s, args) => ReloadCandidates();
                form.Show();
            }
            else
            {
                MessageBox.Show("Выберите кандидата для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sortTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sortTextBox.Text.Length == 0)
            {
                this.candidatesToShow = this.candidates;
                this.fillDataGrid();
            }
            else
            {
                var criteria = this.criteriaComboBox.SelectedItem?.ToString();
                var filterText = sortTextBox.Text.ToLower();

                switch (criteria)
                {
                    case "ФИО":
                        this.candidatesToShow = this.candidates.FindAll(c =>
                            c.initials != null && c.initials.ToLower().Contains(filterText));
                        break;

                    case "Email":
                        this.candidatesToShow = this.candidates.FindAll(c =>
                            c.email != null && c.email.ToLower().Contains(filterText));
                        break;

                    case "Номер телефона":
                        this.candidatesToShow = this.candidates.FindAll(c =>
                            c.phoneNumber != null && c.phoneNumber.ToLower().Contains(filterText));
                        break;

                    case "Название работы":
                        this.candidatesToShow = this.candidates.FindAll(c =>
                            c.jobName != null && c.jobName.ToLower().Contains(filterText));
                        break;

                    default:
                        MessageBox.Show("Выберите корректный критерий для фильтрации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                this.fillDataGrid();
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (editDataGridView.SelectedRows.Count > 0)
            {
                var selectedRowIndex = editDataGridView.SelectedRows[0].Index;
                var candidateId = this.candidates[selectedRowIndex].id;

                var confirmResult = MessageBox.Show(
                    "Вы уверены, что хотите удалить выбранного кандидата?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    SQLService.getShared().DeleteRow("Candidate", $"CandidateID = {candidateId}");
                    ReloadCandidates();
                }
            }
            else
            {
                MessageBox.Show("Выберите кандидата для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigureDataGridView()
        {
            editDataGridView.Columns.Clear();

            editDataGridView.Columns.Add("Initials", "ФИО");
            editDataGridView.Columns.Add("PhoneNumber", "Номер телефона");
            editDataGridView.Columns.Add("Email", "Email");
            editDataGridView.Columns.Add("JobName", "Название работы");

            foreach (DataGridViewColumn column in editDataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Заполняем доступное пространство равномерно
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Выравнивание текста в ячейке
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Выравнивание текста в заголовке
            }

            editDataGridView.AllowUserToAddRows = false;
            editDataGridView.AllowUserToDeleteRows = false;
            editDataGridView.ReadOnly = true;
            editDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }


}

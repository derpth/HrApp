using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HrApp;

namespace HrApp.Forms.Vacancies
{
    public partial class CreateVacancyForm : Form
    {
        List<Client> clients;
        private readonly Vacancy? originalVacancy;
        private Vacancy? editedVacancy;
        private bool isViewVacancy;

        public CreateVacancyForm(Vacancy? vacancy = null, bool isViewVacancy = false)
        {
            InitializeComponent();
            this.originalVacancy = vacancy;

            if (vacancy != null)
            {
                this.editedVacancy = (Vacancy)vacancy.Clone();

                // Инициализация значений в форме
                this.descriptionRichTextBox.Text = vacancy.Description ?? string.Empty;
                this.salaryTextBox.Text = vacancy.SalaryRange ?? string.Empty;
                this.requirmentsRichTextBox.Text = vacancy.Requirements ?? string.Empty;
                this.tittleTextBox.Text = vacancy.Title ?? string.Empty;
                this.startDateTimePicker.Value = DateTime.Parse(vacancy.StartDate);
                this.endDateTimePicker.Value = DateTime.Parse(vacancy.EndDate);
                this.statusComboBox.SelectedItem = vacancy.Status ?? "Открыта";
            }

            this.addVacancyButton.Click += addButton_Click;
            this.Load += CreateVacancyForm_Load;

            // Обновление таблицы в родительской форме после закрытия
            this.FormClosed += (s, e) =>
            {
                var parentForm = Application.OpenForms["VacancyMenuForm"];
                if (parentForm != null && parentForm is VacancyMenuForm managementForm)
                {
                    managementForm.RefreshDataGrid();
                }
            };

            if (isViewVacancy)
            {
                this.addVacancyButton.Visible = false;
                this.clientIdComboBox.Enabled = false;
                this.statusComboBox.Enabled = false;
                this.tittleTextBox.Enabled = false;
                this.startDateTimePicker.Enabled = false;
                this.endDateTimePicker.Enabled = false;
                this.requirmentsRichTextBox.Enabled = false;
                this.descriptionRichTextBox.Enabled = false;
                this.salaryTextBox.Enabled = false;
            }
        }

        private void CreateVacancyForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadStatusOptions();
        }

        private void LoadClients()
        {
            this.clients = SQLService.getShared().fetchClients();

            if (clients != null && clients.Count > 0)
            {
                clientIdComboBox.DataSource = clients;
                clientIdComboBox.DisplayMember = "CompanyName";
                clientIdComboBox.ValueMember = "ClientID";

                if (this.originalVacancy != null)
                {
                    clientIdComboBox.SelectedValue = this.originalVacancy.ClientID;
                }
            }
        }

        private void LoadStatusOptions()
        {
            string[] statuses = { "Открыта", "На паузе", "Закрыта" };
            statusComboBox.Items.AddRange(statuses);
            if (this.originalVacancy != null)
            {
                statusComboBox.SelectedItem = this.originalVacancy.Status;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, object>();

            if (this.editedVacancy != null)
            {
                if (this.originalVacancy.ClientID != (int)clientIdComboBox.SelectedValue)
                    values["ClientID"] = (int)clientIdComboBox.SelectedValue;

                if (!string.IsNullOrWhiteSpace(tittleTextBox.Text) && this.originalVacancy.Title != tittleTextBox.Text)
                    values["Title"] = tittleTextBox.Text;

                if (this.originalVacancy.Description != descriptionRichTextBox.Text)
                    values["Description"] = string.IsNullOrWhiteSpace(descriptionRichTextBox.Text) ? DBNull.Value : descriptionRichTextBox.Text;

                if (this.originalVacancy.Requirements != requirmentsRichTextBox.Text)
                    values["Requirements"] = string.IsNullOrWhiteSpace(requirmentsRichTextBox.Text) ? DBNull.Value : requirmentsRichTextBox.Text;

                if (this.originalVacancy.SalaryRange != salaryTextBox.Text)
                    values["SalaryRange"] = string.IsNullOrWhiteSpace(salaryTextBox.Text) ? DBNull.Value : salaryTextBox.Text;

                if (this.originalVacancy.Status != statusComboBox.SelectedItem?.ToString())
                    values["Status"] = string.IsNullOrWhiteSpace(statusComboBox.SelectedItem?.ToString()) ? DBNull.Value : statusComboBox.SelectedItem.ToString();

                if (this.originalVacancy.StartDate != startDateTimePicker.Value.ToString("yyyy-MM-dd"))
                    values["StartDate"] = startDateTimePicker.Value.ToString("yyyy-MM-dd");

                if (this.originalVacancy.EndDate != endDateTimePicker.Value.ToString("yyyy-MM-dd"))
                    values["EndDate"] = endDateTimePicker.Value.ToString("yyyy-MM-dd");

                if (values.Count > 0)
                {
                    SQLService.getShared().UpdateTable("Vacancies", values, $"VacancyID={this.editedVacancy.Id}");
                }

                this.Close();
                return;
            }

            if (clientIdComboBox.SelectedValue == null)
                return;

            var title = tittleTextBox.Text;
            var clientID = (int)clientIdComboBox.SelectedValue;
            var description = string.IsNullOrWhiteSpace(descriptionRichTextBox.Text) ? null : descriptionRichTextBox.Text;
            var requirements = string.IsNullOrWhiteSpace(requirmentsRichTextBox.Text) ? null : requirmentsRichTextBox.Text;
            var salaryRange = string.IsNullOrWhiteSpace(salaryTextBox.Text) ? null : salaryTextBox.Text;
            var status = statusComboBox.SelectedItem?.ToString();
            var startDate = startDateTimePicker.Value.ToString("yyyy-MM-dd");
            var endDate = endDateTimePicker.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(title) || DateTime.Parse(startDate) > DateTime.Parse(endDate))
                return;

            values = new Dictionary<string, object>
            {
                { "ClientID", clientID },
                { "Title", title },
                { "Description", description },
                { "Requirements", requirements },
                { "SalaryRange", salaryRange },
                { "Status", status },
                { "StartDate", startDate },
                { "EndDate", endDate }
            };

            SQLService.getShared().InsertIntoTable("Vacancies", values);

            this.Close();
        }

        private void clientIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.editedVacancy != null && clientIdComboBox.SelectedValue is int clientId)
            {
                this.editedVacancy.ClientID = clientId;
            }
        }
    }
}


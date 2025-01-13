using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HrApp.Forms;
using HrApp.Forms.Candidates;
using HrApp.Forms.Clients;
using HrApp.Forms.Vacancies;
using HrApp.Forms.VacanciesAndCandidates;

namespace HrApp
{
    public partial class MenuForm : Form
    {
        private readonly User currentUser;

        public MenuForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            this.initialsLabel.Text = $"Полное имя: {this.currentUser.FullName}";
            this.roleLabel.Text = $"Роль: {this.currentUser.Role.LocalizedString()}";
        }

        private void jobManagementButton_Click(object sender, EventArgs e)
        {
            var form = new VacancyMenuForm();
            form.Show();
        }

        private void сandidateManagementButton_Click(object sender, EventArgs e)
        {
            var form = new EditCandidateForm();
            form.Show();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void clientsManagementButton_Click(object sender, EventArgs e)
        {
            var form = new ManageClientsForm();
            form.Show();
        }

        private void vacanciesAndCandidatesButton_Click(object sender, EventArgs e)
        {
            var form = new VacanciesAndCandidatesForm();
            form.Show();
        }
    }
}

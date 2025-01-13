using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HrApp.Forms.Candidates;
using HrApp.Forms.Vacancies;

namespace HrApp.Forms.VacanciesAndCandidates
{
    public partial class VacanciesAndCandidatesForm : Form
    {
        private List<Vacancy> vacancies = new List<Vacancy>();
        private List<Candidate> candidates = new List<Candidate>();
        private List<Candidate> candidatesToShow = new List<Candidate>();

        public VacanciesAndCandidatesForm()
        {
            InitializeComponent();

            this.fetchVacancies();
            this.fetchCandidates();
        }

        private void fetchVacancies()
        {
            SQLService.getShared().fetchVacancies();
            this.vacancies = SQLService.getShared().vacancies;

            foreach (var vacancy in vacancies)
            {
                this.vacanciesListBox.Items.Add(vacancy.Title);
            }
        }

        private void fetchCandidates()
        {
            SQLService.getShared().fetchCandidates();
            this.candidates = SQLService.getShared().candidates;
        }

        private void vacanciesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (sender as ListBox).SelectedItem.ToString().ToLower();
            this.candidatesToShow = this.candidates.FindAll(c => c.jobName.ToLower() == item);
            this.candidatesListBox.Items.Clear();
            foreach (var candidate in this.candidatesToShow)
            {
                this.candidatesListBox.Items.Add(candidate.initials);
            }
        }

        private void vacanciesListBox_DoubleClick(object sender, EventArgs e)
        {
            var vacancy = this.vacancies[this.vacanciesListBox.SelectedIndex];
            var form = new CreateVacancyForm(vacancy, true);
            form.Show();
        }

        private void candidatesListBox_DoubleClick(object sender, EventArgs e)
        {
            var candidate = this.candidatesToShow[this.candidatesListBox.SelectedIndex];
            var form = new AddCandidateForm(candidate, true);
            form.Show();
        }
    }
}

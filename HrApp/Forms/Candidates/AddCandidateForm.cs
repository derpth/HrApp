using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HrApp.Forms.Candidates
{
    public partial class AddCandidateForm : Form
    {
        private readonly Candidate? originalCandidate;
        private Candidate? editedCandidate;
        private bool isViewCandidate;

        public AddCandidateForm(Candidate? candidate = null, bool isViewCandidate = false)
        {
            InitializeComponent();
            this.originalCandidate = candidate;
            this.isViewCandidate = isViewCandidate;
            if (candidate != null)
            {
                this.editedCandidate = (Candidate)candidate.Clone();

                this.initialsTextBox.Text = candidate.initials;
                if (candidate.phoneNumber != null)
                {
                    this.phoneNumberTextBox.Text = candidate.phoneNumber;
                }

                this.emailTextBox.Text = candidate.email;
                this.jobNameTextBox.Text = candidate.jobName;
                this.previousWorkRichTextBox.Text = candidate.previousWorkPlaces;
                this.hardSkillsRichTextBox.Text = candidate.hardSkills;
                this.softSkillsRichTextBox.Text = candidate.softSkills;

                this.addButton.Text = "Изменить кандидата";
            }

            if (isViewCandidate)
            {
                this.initialsTextBox.Enabled = false;
                this.phoneNumberTextBox.Enabled = false;
                this.emailTextBox.Enabled = false;
                this.jobNameTextBox.Enabled = false;
                this.previousWorkRichTextBox.Enabled = false;
                this.hardSkillsRichTextBox.Enabled = false;
                this.softSkillsRichTextBox.Enabled = false;
                this.addButton.Text = "Выгрузить резюме кандидата";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.isViewCandidate && this.editedCandidate != null)
            {
                var filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"HRApp\\{this.editedCandidate.initials}-CV.txt");
                this.CreateAppDataFolderIfNotExist();
                if (!File.Exists(filename))
                {
                    File.Create(filename).Dispose();
                }

                File.WriteAllText(filename, String.Empty);
                File.WriteAllText(filename,
                    $"Порядкой номер кандидата: {this.editedCandidate.id}" +
                    $"\nФИО: {this.editedCandidate.initials}" +
                    $"\nДолжность: {this.editedCandidate.jobName}" +
                    $"\nНомер телефона: {this.editedCandidate.phoneNumber}" +
                    $"\nЭлектронная почта: {this.editedCandidate.email}" +
                    $"\nОпыт работы: {this.editedCandidate.previousWorkPlaces}" +
                    $"\nHard Skills: {this.editedCandidate.hardSkills}" +
                    $"\nSoft Skills: {this.editedCandidate.softSkills}"
                );

                Process.Start("notepad.exe", filename);

                return;
            }
            
            if (this.editedCandidate == null)
            {
                var initials = this.initialsTextBox.Text;
                if (!initials.CheckString("Введите ФИО кандидата"))
                {
                    return;
                }

                var phoneNumber = this.phoneNumberTextBox.Text.PrepareSqlString();
                var previousPlaceWork = this.previousWorkRichTextBox.Text.PrepareSqlString();
                var email = this.emailTextBox.Text;
                if (!email.CheckString("Введите email"))
                {
                    return;
                }

                var hardSkills = this.hardSkillsRichTextBox.Text;
                if (!hardSkills.CheckString("Введите hardskills"))
                {
                    return;
                }

                var softSkills = this.softSkillsRichTextBox.Text;
                if (!softSkills.CheckString("Введите softskills"))
                {
                    return;
                }

                var jobName = this.jobNameTextBox.Text;
                if (!jobName.CheckString("Введите jobname"))
                {
                    return;
                }

                if (SQLService.getShared().checkIfCandidateExist(initials))
                {
                    MessageBox.Show("Кандидат уже существует в базе данных");
                    return;
                }

                var columns = "Initials, PhoneNumber, PreviousPlaceWork, Email, JobName, HardSkills, SoftSkills";
                var values = $"N'{initials}', {phoneNumber}, {previousPlaceWork}, N'{email}', N'{jobName}', N'{hardSkills}', N'{softSkills}'";
                SQLService.getShared().insertValuesInTable("Candidate", columns, values);

                MessageBox.Show("Кандидат был успешно добавлен в базу");
                this.Close();
            }
            else
            {
                var values = new Dictionary<string, object>();

                if (this.originalCandidate.initials != this.editedCandidate.initials)
                {
                    values["Initials"] = this.editedCandidate.initials;
                }

                if (this.originalCandidate.phoneNumber != this.editedCandidate.phoneNumber)
                {
                    values["PhoneNumber"] = this.editedCandidate.phoneNumber;
                }

                if (this.originalCandidate.previousWorkPlaces != this.editedCandidate.previousWorkPlaces)
                {
                    values["PreviousPlaceWork"] = this.editedCandidate.previousWorkPlaces;
                }

                if (this.originalCandidate.email != this.editedCandidate.email)
                {
                    values["Email"] = this.editedCandidate.email;
                }

                if (this.originalCandidate.jobName != this.editedCandidate.jobName)
                {
                    values["JobName"] = this.editedCandidate.jobName;
                }

                if (this.originalCandidate.hardSkills != this.editedCandidate.hardSkills)
                {
                    values["HardSkills"] = this.editedCandidate.hardSkills;
                }

                if (this.originalCandidate.softSkills != this.editedCandidate.softSkills)
                {
                    values["SoftSkills"] = this.editedCandidate.softSkills;
                }

                if (values.Count > 0)
                {
                    SQLService.getShared().updateValuesInTable("Candidate", values, $"CandidateId={this.editedCandidate.id}");
                }

                MessageBox.Show("Изменения успешно сохранены.");
                this.Close();
            }
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (this.editedCandidate == null)
            {
                return;
            }

            var textBox = sender as TextBox;
            var richTextBox = sender as RichTextBox;
            var tag = "";
            if (textBox != null)
            {
                tag = (string)textBox.Tag;
            }
            else if (richTextBox != null)
            {
                tag = (string)richTextBox.Tag;
            }
            else return;

            switch (tag)
            {
                case "1":
                    this.editedCandidate.initials = this.initialsTextBox.Text;
                    break;
                case "2":
                    this.editedCandidate.phoneNumber = this.phoneNumberTextBox.Text;
                    break;
                case "3":
                    this.editedCandidate.email = this.emailTextBox.Text;
                    break;
                case "4":
                    this.editedCandidate.jobName = this.jobNameTextBox.Text;
                    break;
                case "5":
                    this.editedCandidate.previousWorkPlaces = this.previousWorkRichTextBox.Text;
                    break;
                case "6":
                    this.editedCandidate.hardSkills = this.hardSkillsRichTextBox.Text;
                    break;
                case "7":
                    this.editedCandidate.softSkills = this.softSkillsRichTextBox.Text;
                    break;
                default:
                    break;
            }
        }

        public void CreateAppDataFolderIfNotExist()
        {
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HRApp");
            if (!Directory.Exists(folder)) {
                Directory.CreateDirectory(folder);
            }
        }
    }
}

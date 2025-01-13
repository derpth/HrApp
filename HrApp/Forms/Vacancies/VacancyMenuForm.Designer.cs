namespace HrApp.Forms.Vacancies
{
    partial class VacancyMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            jobManagementLabel = new Label();
            vacancyDataGridView = new DataGridView();
            ClientId = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Requirements = new DataGridViewTextBoxColumn();
            SalaryRange = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            DateCreated = new DataGridViewTextBoxColumn();
            addNewVacancyButton = new Button();
            editVacancyButton = new Button();
            deleteVacancyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)vacancyDataGridView).BeginInit();
            SuspendLayout();
            // 
            // jobManagementLabel
            // 
            jobManagementLabel.AutoSize = true;
            jobManagementLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            jobManagementLabel.Location = new Point(289, 9);
            jobManagementLabel.Name = "jobManagementLabel";
            jobManagementLabel.Size = new Size(286, 31);
            jobManagementLabel.TabIndex = 0;
            jobManagementLabel.Text = "Управление вакансиями";
            // 
            // vacancyDataGridView
            // 
            vacancyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vacancyDataGridView.Columns.AddRange(new DataGridViewColumn[] { ClientId, Title, Description, Requirements, SalaryRange, Status, StartDate, EndDate, DateCreated });
            vacancyDataGridView.Location = new Point(12, 43);
            vacancyDataGridView.Name = "vacancyDataGridView";
            vacancyDataGridView.RowHeadersWidth = 51;
            vacancyDataGridView.RowTemplate.Height = 29;
            vacancyDataGridView.Size = new Size(836, 320);
            vacancyDataGridView.TabIndex = 1;
            // 
            // ClientId
            // 
            ClientId.HeaderText = "ID Клиента";
            ClientId.MinimumWidth = 6;
            ClientId.Name = "ClientId";
            ClientId.Width = 125;
            // 
            // Title
            // 
            Title.HeaderText = "Название";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Описание";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // Requirements
            // 
            Requirements.HeaderText = "Требования";
            Requirements.MinimumWidth = 6;
            Requirements.Name = "Requirements";
            Requirements.Width = 125;
            // 
            // SalaryRange
            // 
            SalaryRange.HeaderText = "Зарплата";
            SalaryRange.MinimumWidth = 6;
            SalaryRange.Name = "SalaryRange";
            SalaryRange.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Дата начала";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            StartDate.Width = 125;
            // 
            // EndDate
            // 
            EndDate.HeaderText = "Дата окончания";
            EndDate.MinimumWidth = 6;
            EndDate.Name = "EndDate";
            EndDate.Width = 125;
            // 
            // DateCreated
            // 
            DateCreated.HeaderText = "Дата создания";
            DateCreated.MinimumWidth = 6;
            DateCreated.Name = "DateCreated";
            DateCreated.Width = 125;
            // 
            // addNewVacancyButton
            // 
            addNewVacancyButton.Location = new Point(12, 369);
            addNewVacancyButton.Name = "addNewVacancyButton";
            addNewVacancyButton.Size = new Size(186, 29);
            addNewVacancyButton.TabIndex = 2;
            addNewVacancyButton.Text = "Создать вакансию";
            addNewVacancyButton.UseVisualStyleBackColor = true;
            addNewVacancyButton.Click += addNewVacancyButton_Click;
            // 
            // editVacancyButton
            // 
            editVacancyButton.Location = new Point(204, 369);
            editVacancyButton.Name = "editVacancyButton";
            editVacancyButton.Size = new Size(186, 29);
            editVacancyButton.TabIndex = 3;
            editVacancyButton.Text = "Редактировать";
            editVacancyButton.UseVisualStyleBackColor = true;
            editVacancyButton.Click += editVacancyButton_Click;
            // 
            // deleteVacancyButton
            // 
            deleteVacancyButton.Location = new Point(668, 369);
            deleteVacancyButton.Name = "deleteVacancyButton";
            deleteVacancyButton.Size = new Size(180, 29);
            deleteVacancyButton.TabIndex = 4;
            deleteVacancyButton.Text = "Удалить";
            deleteVacancyButton.UseVisualStyleBackColor = true;
            deleteVacancyButton.Click += deleteVacancyButton_Click;
            // 
            // VacancyMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 410);
            Controls.Add(deleteVacancyButton);
            Controls.Add(editVacancyButton);
            Controls.Add(addNewVacancyButton);
            Controls.Add(vacancyDataGridView);
            Controls.Add(jobManagementLabel);
            Name = "VacancyMenuForm";
            Text = "HrApp | Управление вакансиями";
            FormClosed += VacancyMenuForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)vacancyDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label jobManagementLabel;
        private DataGridView vacancyDataGridView;
        private Button addNewVacancyButton;
        private Button editVacancyButton;
        private Button deleteVacancyButton;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Requirements;
        private DataGridViewTextBoxColumn SalaryRange;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn DateCreated;
    }
}
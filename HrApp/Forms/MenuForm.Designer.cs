namespace HrApp
{
    partial class MenuForm
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
            initialsLabel = new Label();
            roleLabel = new Label();
            сandidateManagementButton = new Button();
            jobManagementButton = new Button();
            clientsManagementButton = new Button();
            vacanciesAndCandidatesButton = new Button();
            SuspendLayout();
            // 
            // initialsLabel
            // 
            initialsLabel.AutoSize = true;
            initialsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            initialsLabel.Location = new Point(12, 9);
            initialsLabel.Name = "initialsLabel";
            initialsLabel.Size = new Size(49, 20);
            initialsLabel.TabIndex = 0;
            initialsLabel.Text = "ФИО:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            roleLabel.Location = new Point(12, 29);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(46, 20);
            roleLabel.TabIndex = 1;
            roleLabel.Text = "Роль:";
            // 
            // сandidateManagementButton
            // 
            сandidateManagementButton.Location = new Point(12, 52);
            сandidateManagementButton.Name = "сandidateManagementButton";
            сandidateManagementButton.Size = new Size(112, 50);
            сandidateManagementButton.TabIndex = 2;
            сandidateManagementButton.Text = "Управление кандидатами";
            сandidateManagementButton.UseVisualStyleBackColor = true;
            сandidateManagementButton.Click += сandidateManagementButton_Click;
            // 
            // jobManagementButton
            // 
            jobManagementButton.Location = new Point(130, 52);
            jobManagementButton.Name = "jobManagementButton";
            jobManagementButton.Size = new Size(112, 50);
            jobManagementButton.TabIndex = 3;
            jobManagementButton.Text = "Управление вакансиями";
            jobManagementButton.UseVisualStyleBackColor = true;
            jobManagementButton.Click += jobManagementButton_Click;
            // 
            // clientsManagementButton
            // 
            clientsManagementButton.Location = new Point(12, 108);
            clientsManagementButton.Name = "clientsManagementButton";
            clientsManagementButton.Size = new Size(112, 50);
            clientsManagementButton.TabIndex = 5;
            clientsManagementButton.Text = "Управление клиентами";
            clientsManagementButton.UseVisualStyleBackColor = true;
            clientsManagementButton.Click += clientsManagementButton_Click;
            // 
            // vacanciesAndCandidatesButton
            // 
            vacanciesAndCandidatesButton.Location = new Point(130, 108);
            vacanciesAndCandidatesButton.Name = "vacanciesAndCandidatesButton";
            vacanciesAndCandidatesButton.Size = new Size(112, 50);
            vacanciesAndCandidatesButton.TabIndex = 7;
            vacanciesAndCandidatesButton.Text = "Вакансии и кандидаты";
            vacanciesAndCandidatesButton.UseVisualStyleBackColor = true;
            vacanciesAndCandidatesButton.Click += vacanciesAndCandidatesButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 185);
            Controls.Add(vacanciesAndCandidatesButton);
            Controls.Add(clientsManagementButton);
            Controls.Add(jobManagementButton);
            Controls.Add(сandidateManagementButton);
            Controls.Add(roleLabel);
            Controls.Add(initialsLabel);
            Name = "MenuForm";
            Text = "HRApp | Меню";
            FormClosed += MenuForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label initialsLabel;
        private Label roleLabel;
        private Button сandidateManagementButton;
        private Button jobManagementButton;
        private Button clientsManagementButton;
        private Button vacanciesAndCandidatesButton;
    }
}
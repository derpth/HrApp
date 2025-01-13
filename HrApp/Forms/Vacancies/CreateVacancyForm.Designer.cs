namespace HrApp.Forms.Vacancies
{
    partial class CreateVacancyForm
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
            clientIdComboBox = new ComboBox();
            clientidLabel = new Label();
            tittleTextBox = new TextBox();
            tittleLabel = new Label();
            descriptionLabel = new Label();
            requirmentsRichTextBox = new RichTextBox();
            requirmentsLabel = new Label();
            statusLabel = new Label();
            descriptionRichTextBox = new RichTextBox();
            startDateTimePicker = new DateTimePicker();
            startDateLabel = new Label();
            endDateTimePicker = new DateTimePicker();
            endDateLabel = new Label();
            addVacancyButton = new Button();
            statusComboBox = new ComboBox();
            salaryTextBox = new TextBox();
            salaryLabel = new Label();
            SuspendLayout();
            // 
            // clientIdComboBox
            // 
            clientIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clientIdComboBox.FormattingEnabled = true;
            clientIdComboBox.Location = new Point(12, 38);
            clientIdComboBox.Name = "clientIdComboBox";
            clientIdComboBox.Size = new Size(151, 28);
            clientIdComboBox.TabIndex = 0;
            clientIdComboBox.SelectedIndexChanged += clientIdComboBox_SelectedIndexChanged;
            // 
            // clientidLabel
            // 
            clientidLabel.AutoSize = true;
            clientidLabel.Location = new Point(12, 9);
            clientidLabel.Name = "clientidLabel";
            clientidLabel.Size = new Size(103, 20);
            clientidLabel.TabIndex = 1;
            clientidLabel.Text = "Работадатель";
            // 
            // tittleTextBox
            // 
            tittleTextBox.Location = new Point(12, 95);
            tittleTextBox.Name = "tittleTextBox";
            tittleTextBox.Size = new Size(318, 27);
            tittleTextBox.TabIndex = 2;
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Location = new Point(12, 72);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(77, 20);
            tittleLabel.TabIndex = 3;
            tittleLabel.Text = "Название";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(336, 15);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(79, 20);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Описание";
            // 
            // requirmentsRichTextBox
            // 
            requirmentsRichTextBox.Location = new Point(12, 280);
            requirmentsRichTextBox.Name = "requirmentsRichTextBox";
            requirmentsRichTextBox.Size = new Size(318, 120);
            requirmentsRichTextBox.TabIndex = 6;
            requirmentsRichTextBox.Text = "";

            // 
            // requirmentsLabel
            // 
            requirmentsLabel.AutoSize = true;
            requirmentsLabel.Location = new Point(12, 257);
            requirmentsLabel.Name = "requirmentsLabel";
            requirmentsLabel.Size = new Size(94, 20);
            requirmentsLabel.TabIndex = 7;
            requirmentsLabel.Text = "Требования";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(179, 9);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 20);
            statusLabel.TabIndex = 9;
            statusLabel.Text = "Статус";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(336, 38);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(197, 288);
            descriptionRichTextBox.TabIndex = 11;
            descriptionRichTextBox.Text = "";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(12, 152);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(318, 27);
            startDateTimePicker.TabIndex = 12;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(12, 129);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(110, 20);
            startDateLabel.TabIndex = 13;
            startDateLabel.Text = "Дата создания";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(12, 213);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(318, 27);
            endDateTimePicker.TabIndex = 14;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(12, 190);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(121, 20);
            endDateLabel.TabIndex = 15;
            endDateLabel.Text = "Дата окончания";
            // 
            // addVacancyButton
            // 
            addVacancyButton.Location = new Point(124, 409);
            addVacancyButton.Name = "addVacancyButton";
            addVacancyButton.Size = new Size(310, 29);
            addVacancyButton.TabIndex = 16;
            addVacancyButton.Text = "Добавить вакансию";
            addVacancyButton.UseVisualStyleBackColor = true;
            addVacancyButton.Click += addButton_Click;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(179, 38);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(151, 28);
            statusComboBox.TabIndex = 17;
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new Point(336, 373);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(197, 27);
            salaryTextBox.TabIndex = 18;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(336, 341);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(73, 20);
            salaryLabel.TabIndex = 19;
            salaryLabel.Text = "Зарплата";
            // 
            // CreateVacancyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(salaryLabel);
            Controls.Add(salaryTextBox);
            Controls.Add(statusComboBox);
            Controls.Add(addVacancyButton);
            Controls.Add(endDateLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(startDateLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(statusLabel);
            Controls.Add(requirmentsLabel);
            Controls.Add(requirmentsRichTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(tittleLabel);
            Controls.Add(tittleTextBox);
            Controls.Add(clientidLabel);
            Controls.Add(clientIdComboBox);
            Name = "CreateVacancyForm";
            Text = "HrApp | Создание вакансии";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox clientIdComboBox;
        private Label clientidLabel;
        private TextBox tittleTextBox;
        private Label tittleLabel;
        private Label descriptionLabel;
        private RichTextBox requirmentsRichTextBox;
        private Label requirmentsLabel;
        private Label statusLabel;
        private RichTextBox descriptionRichTextBox;
        private DateTimePicker startDateTimePicker;
        private Label startDateLabel;
        private DateTimePicker endDateTimePicker;
        private Label endDateLabel;
        private Button addVacancyButton;
        private ComboBox statusComboBox;
        private TextBox salaryTextBox;
        private Label salaryLabel;
    }
}
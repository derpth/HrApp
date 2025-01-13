namespace HrApp.Forms.Candidates
{
    partial class EditCandidateForm
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
            editDataGridView = new DataGridView();
            Initials = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            JobName = new DataGridViewTextBoxColumn();
            AddButton = new Button();
            EditButton = new Button();
            criteriaComboBox = new ComboBox();
            sortTextBox = new TextBox();
            delButton = new Button();
            ((System.ComponentModel.ISupportInitialize)editDataGridView).BeginInit();
            SuspendLayout();
            // 
            // editDataGridView
            // 
            editDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editDataGridView.Columns.AddRange(new DataGridViewColumn[] { Initials, PhoneNumber, Email, JobName });
            editDataGridView.Location = new Point(12, 58);
            editDataGridView.Name = "editDataGridView";
            editDataGridView.RowHeadersWidth = 51;
            editDataGridView.RowTemplate.Height = 29;
            editDataGridView.Size = new Size(776, 327);
            editDataGridView.TabIndex = 0;
            // 
            // Initials
            // 
            Initials.HeaderText = "ФИО";
            Initials.MinimumWidth = 6;
            Initials.Name = "Initials";
            Initials.ReadOnly = true;
            Initials.Width = 125;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Номер телефона";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // JobName
            // 
            JobName.HeaderText = "Специальность";
            JobName.MinimumWidth = 6;
            JobName.Name = "JobName";
            JobName.ReadOnly = true;
            JobName.Width = 125;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 12);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(113, 29);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(131, 11);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(132, 29);
            EditButton.TabIndex = 2;
            EditButton.Text = "Изменить";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // criteriaComboBox
            // 
            criteriaComboBox.FormattingEnabled = true;
            criteriaComboBox.Items.AddRange(new object[] { "ФИО", "Email", "Номер телефона", "Название работы" });
            criteriaComboBox.Location = new Point(430, 12);
            criteriaComboBox.Name = "criteriaComboBox";
            criteriaComboBox.Size = new Size(159, 28);
            criteriaComboBox.TabIndex = 3;
            // 
            // sortTextBox
            // 
            sortTextBox.Location = new Point(595, 15);
            sortTextBox.Name = "sortTextBox";
            sortTextBox.Size = new Size(191, 27);
            sortTextBox.TabIndex = 4;
            sortTextBox.TextChanged += sortTextBox_TextChanged;
            // 
            // delButton
            // 
            delButton.Location = new Point(269, 11);
            delButton.Name = "delButton";
            delButton.Size = new Size(132, 29);
            delButton.TabIndex = 5;
            delButton.Text = "Удалить";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // EditCandidateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 411);
            Controls.Add(delButton);
            Controls.Add(sortTextBox);
            Controls.Add(criteriaComboBox);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(editDataGridView);
            Name = "EditCandidateForm";
            Text = "HrApp | Редактирование";
            ((System.ComponentModel.ISupportInitialize)editDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView editDataGridView;
        private Button AddButton;
        private Button EditButton;
        private ComboBox criteriaComboBox;
        private DataGridViewTextBoxColumn Initials;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn JobName;
        private TextBox sortTextBox;
        private Button delButton;
    }
}
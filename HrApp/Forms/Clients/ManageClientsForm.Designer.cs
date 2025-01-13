namespace HrApp.Forms.Clients
{
    partial class ManageClientsForm
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
            clientDataGridView = new DataGridView();
            CompanyName = new DataGridViewTextBoxColumn();
            ContactPerson = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            DateAdded = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            addClientButton = new Button();
            editClientButton = new Button();
            deleteClientButton = new Button();
            historyOfInteractionsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clientDataGridView
            // 
            clientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDataGridView.Columns.AddRange(new DataGridViewColumn[] { CompanyName, ContactPerson, Phone, Email, Address, Notes, DateAdded, IsActive });
            clientDataGridView.Location = new Point(12, 12);
            clientDataGridView.Name = "clientDataGridView";
            clientDataGridView.RowHeadersWidth = 51;
            clientDataGridView.RowTemplate.Height = 29;
            clientDataGridView.Size = new Size(776, 302);
            clientDataGridView.TabIndex = 0;
            // 
            // CompanyName
            // 
            CompanyName.HeaderText = "Название компании";
            CompanyName.MinimumWidth = 6;
            CompanyName.Name = "CompanyName";
            CompanyName.Width = 125;
            // 
            // ContactPerson
            // 
            ContactPerson.HeaderText = "Контактное лицо";
            ContactPerson.MinimumWidth = 6;
            ContactPerson.Name = "ContactPerson";
            ContactPerson.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Номер телефона";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Адрес";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // Notes
            // 
            Notes.HeaderText = "Заметки";
            Notes.MinimumWidth = 6;
            Notes.Name = "Notes";
            Notes.Width = 125;
            // 
            // DateAdded
            // 
            DateAdded.HeaderText = "Дата добавления";
            DateAdded.MinimumWidth = 6;
            DateAdded.Name = "DateAdded";
            DateAdded.Width = 125;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "Активность";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.Width = 125;
            // 
            // addClientButton
            // 
            addClientButton.Location = new Point(12, 332);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(177, 29);
            addClientButton.TabIndex = 1;
            addClientButton.Text = "Добавить";
            addClientButton.UseVisualStyleBackColor = true;
            addClientButton.Click += addButton_Click;
            // 
            // editClientButton
            // 
            editClientButton.Location = new Point(195, 332);
            editClientButton.Name = "editClientButton";
            editClientButton.Size = new Size(132, 29);
            editClientButton.TabIndex = 2;
            editClientButton.Text = "Изменить";
            editClientButton.UseVisualStyleBackColor = true;
            editClientButton.Click += editButton_Click;
            // 
            // deleteClientButton
            // 
            deleteClientButton.Location = new Point(333, 332);
            deleteClientButton.Name = "deleteClientButton";
            deleteClientButton.Size = new Size(131, 29);
            deleteClientButton.TabIndex = 3;
            deleteClientButton.Text = "Удалить";
            deleteClientButton.UseVisualStyleBackColor = true;
            deleteClientButton.Click += deleteButton_Click;
            // 
            // historyOfInteractionsButton
            // 
            historyOfInteractionsButton.Location = new Point(470, 332);
            historyOfInteractionsButton.Name = "historyOfInteractionsButton";
            historyOfInteractionsButton.Size = new Size(318, 29);
            historyOfInteractionsButton.TabIndex = 4;
            historyOfInteractionsButton.Text = "История взаимодействия";
            historyOfInteractionsButton.UseVisualStyleBackColor = true;
            historyOfInteractionsButton.Click += historyOfInteractionsButton_Click;
            // 
            // ManageClientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 385);
            Controls.Add(historyOfInteractionsButton);
            Controls.Add(deleteClientButton);
            Controls.Add(editClientButton);
            Controls.Add(addClientButton);
            Controls.Add(clientDataGridView);
            Name = "ManageClientsForm";
            Text = "ManageClientsForm";
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clientDataGridView;
        private Button addClientButton;
        private Button editClientButton;
        private Button deleteClientButton;
        private Button historyOfInteractionsButton;
        private DataGridViewTextBoxColumn CompanyName;
        private DataGridViewTextBoxColumn ContactPerson;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Notes;
        private DataGridViewTextBoxColumn DateAdded;
        private DataGridViewTextBoxColumn IsActive;
    }
}
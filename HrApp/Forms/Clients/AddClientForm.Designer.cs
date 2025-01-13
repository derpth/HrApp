namespace HrApp.Forms.Clients
{
    partial class AddClientForm
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
            titleTextBox = new TextBox();
            titleLabel = new Label();
            contactLabel = new Label();
            contactPersonTextBox = new TextBox();
            phoneLabel = new Label();
            phoneNumberTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            AddressLabel = new Label();
            addressTextBox = new TextBox();
            notesRichTextBox = new RichTextBox();
            notesLabel = new Label();
            statusLabel = new Label();
            isActiveCheckBox = new CheckBox();
            addClientButton = new Button();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 29);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(259, 27);
            titleTextBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(11, 6);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(152, 20);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Название компании";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new Point(11, 59);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(128, 20);
            contactLabel.TabIndex = 3;
            contactLabel.Text = "Контактное лицо";
            // 
            // contactPersonTextBox
            // 
            contactPersonTextBox.Location = new Point(11, 82);
            contactPersonTextBox.Name = "contactPersonTextBox";
            contactPersonTextBox.Size = new Size(260, 27);
            contactPersonTextBox.TabIndex = 2;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(11, 112);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(127, 20);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Номер телефона";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(11, 135);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(260, 27);
            phoneNumberTextBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 165);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(11, 188);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(260, 27);
            emailTextBox.TabIndex = 6;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(12, 218);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(51, 20);
            AddressLabel.TabIndex = 9;
            AddressLabel.Text = "Адрес";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(11, 241);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(260, 27);
            addressTextBox.TabIndex = 8;
            // 
            // notesRichTextBox
            // 
            notesRichTextBox.Location = new Point(12, 294);
            notesRichTextBox.Name = "notesRichTextBox";
            notesRichTextBox.Size = new Size(259, 120);
            notesRichTextBox.TabIndex = 10;
            notesRichTextBox.Text = "";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(12, 271);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(66, 20);
            notesLabel.TabIndex = 11;
            notesLabel.Text = "Заметки";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(286, 9);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(134, 20);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "Статус активности";
            // 
            // isActiveCheckBox
            // 
            isActiveCheckBox.AutoSize = true;
            isActiveCheckBox.Location = new Point(286, 41);
            isActiveCheckBox.Name = "isActiveCheckBox";
            isActiveCheckBox.Size = new Size(88, 24);
            isActiveCheckBox.TabIndex = 13;
            isActiveCheckBox.Text = "Активен";
            isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // addClientButton
            // 
            addClientButton.Location = new Point(53, 429);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(321, 29);
            addClientButton.TabIndex = 14;
            addClientButton.Text = "Добавить";
            addClientButton.UseVisualStyleBackColor = true;
            addClientButton.Click += SaveButton_Click;
            // 
            // AddClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 467);
            Controls.Add(addClientButton);
            Controls.Add(isActiveCheckBox);
            Controls.Add(statusLabel);
            Controls.Add(notesLabel);
            Controls.Add(notesRichTextBox);
            Controls.Add(AddressLabel);
            Controls.Add(addressTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(contactLabel);
            Controls.Add(contactPersonTextBox);
            Controls.Add(titleLabel);
            Controls.Add(titleTextBox);
            Name = "AddClientForm";
            Text = "AddClientFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private Label titleLabel;
        private Label contactLabel;
        private TextBox contactPersonTextBox;
        private Label phoneLabel;
        private TextBox phoneNumberTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label AddressLabel;
        private TextBox addressTextBox;
        private RichTextBox notesRichTextBox;
        private Label notesLabel;
        private Label statusLabel;
        private CheckBox isActiveCheckBox;
        private Button addClientButton;
    }
}
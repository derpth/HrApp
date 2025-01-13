namespace HrApp.Forms
{
    partial class RegisterForm
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
            loginTextBox = new TextBox();
            loginLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            fullNameLabel = new Label();
            fullNameTextBox = new TextBox();
            roleLabel = new Label();
            roleComboBox = new ComboBox();
            Reglabel = new Label();
            registerButton = new Button();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(12, 86);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(160, 27);
            loginTextBox.TabIndex = 0;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(12, 63);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(52, 20);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 128);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(62, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 151);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(160, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(12, 192);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(42, 20);
            fullNameLabel.TabIndex = 5;
            fullNameLabel.Text = "ФИО";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(12, 215);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(160, 27);
            fullNameTextBox.TabIndex = 4;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(12, 259);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(116, 20);
            roleLabel.TabIndex = 6;
            roleLabel.Text = "Выберите роль";
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(12, 282);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(160, 28);
            roleComboBox.TabIndex = 7;
            // 
            // Reglabel
            // 
            Reglabel.AutoSize = true;
            Reglabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Reglabel.Location = new Point(22, 21);
            Reglabel.Name = "Reglabel";
            Reglabel.Size = new Size(134, 28);
            Reglabel.TabIndex = 8;
            Reglabel.Text = "Регистрация";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(12, 333);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(160, 29);
            registerButton.TabIndex = 9;
            registerButton.Text = "Зарегистрироваться";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 377);
            Controls.Add(registerButton);
            Controls.Add(Reglabel);
            Controls.Add(roleComboBox);
            Controls.Add(roleLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(fullNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(loginLabel);
            Controls.Add(loginTextBox);
            Name = "RegisterForm";
            Text = "HrApp | Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private Label loginLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label fullNameLabel;
        private TextBox fullNameTextBox;
        private Label roleLabel;
        private ComboBox roleComboBox;
        private Label Reglabel;
        private Button registerButton;
    }
}
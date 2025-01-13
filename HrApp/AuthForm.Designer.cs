namespace HrApp
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            loginTextBox = new TextBox();
            groupBox2 = new GroupBox();
            passwordTextBox = new TextBox();
            signInButton = new Button();
            signUpButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 54);
            label1.TabIndex = 0;
            label1.Text = "HRApp";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(loginTextBox);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(158, 66);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Логин";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(6, 26);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.PlaceholderText = "Введите логин";
            loginTextBox.Size = new Size(146, 27);
            loginTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(passwordTextBox);
            groupBox2.Location = new Point(12, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(158, 66);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(6, 26);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Введите пароль";
            passwordTextBox.Size = new Size(146, 27);
            passwordTextBox.TabIndex = 0;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(12, 210);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(158, 29);
            signInButton.TabIndex = 3;
            signInButton.Text = "Войти";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += SignInButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(12, 245);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(158, 29);
            signUpButton.TabIndex = 4;
            signUpButton.Text = "Регистрация";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 291);
            Controls.Add(signUpButton);
            Controls.Add(signInButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "AuthForm";
            Text = "HRApp";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox loginTextBox;
        private GroupBox groupBox2;
        private TextBox passwordTextBox;
        private Button signInButton;
        private Button signUpButton;
    }
}

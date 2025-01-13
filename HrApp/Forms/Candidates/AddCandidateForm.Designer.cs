namespace HrApp.Forms.Candidates
{
    partial class AddCandidateForm
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
            initialsTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            phoneNumberTextBox = new TextBox();
            label3 = new Label();
            emailTextBox = new TextBox();
            previousWorkRichTextBox = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            hardSkillsRichTextBox = new RichTextBox();
            label6 = new Label();
            softSkillsRichTextBox = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            jobNameTextBox = new TextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // initialsTextBox
            // 
            initialsTextBox.Location = new Point(12, 32);
            initialsTextBox.Name = "initialsTextBox";
            initialsTextBox.Size = new Size(250, 27);
            initialsTextBox.TabIndex = 0;
            initialsTextBox.Tag = "1";
            initialsTextBox.TextChanged += textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 3;
            label2.Text = "Номер телефона:";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(12, 85);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(250, 27);
            phoneNumberTextBox.TabIndex = 2;
            phoneNumberTextBox.Tag = "2";
            phoneNumberTextBox.TextChanged += textBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(12, 138);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(250, 27);
            emailTextBox.TabIndex = 4;
            emailTextBox.Tag = "3";
            emailTextBox.TextChanged += textBox_TextChanged;
            // 
            // previousWorkRichTextBox
            // 
            previousWorkRichTextBox.Location = new Point(268, 32);
            previousWorkRichTextBox.Name = "previousWorkRichTextBox";
            previousWorkRichTextBox.Size = new Size(125, 186);
            previousWorkRichTextBox.TabIndex = 6;
            previousWorkRichTextBox.Tag = "5";
            previousWorkRichTextBox.Text = "";
            previousWorkRichTextBox.TextChanged += textBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 9);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 7;
            label4.Text = "Опыт работы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 9);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 9;
            label5.Text = "Hard Skills";
            // 
            // hardSkillsRichTextBox
            // 
            hardSkillsRichTextBox.Location = new Point(399, 32);
            hardSkillsRichTextBox.Name = "hardSkillsRichTextBox";
            hardSkillsRichTextBox.Size = new Size(125, 186);
            hardSkillsRichTextBox.TabIndex = 8;
            hardSkillsRichTextBox.Tag = "6";
            hardSkillsRichTextBox.Text = "";
            hardSkillsRichTextBox.TextChanged += textBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(530, 9);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 11;
            label6.Text = "Soft Skills";
            // 
            // softSkillsRichTextBox
            // 
            softSkillsRichTextBox.Location = new Point(530, 32);
            softSkillsRichTextBox.Name = "softSkillsRichTextBox";
            softSkillsRichTextBox.Size = new Size(125, 186);
            softSkillsRichTextBox.TabIndex = 10;
            softSkillsRichTextBox.Tag = "7";
            softSkillsRichTextBox.Text = "";
            softSkillsRichTextBox.TextChanged += textBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 168);
            label7.Name = "label7";
            label7.Size = new Size(160, 20);
            label7.TabIndex = 12;
            label7.Text = "Название должности:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(182, 307);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 13;
            // 
            // jobNameTextBox
            // 
            jobNameTextBox.Location = new Point(12, 191);
            jobNameTextBox.Name = "jobNameTextBox";
            jobNameTextBox.Size = new Size(250, 27);
            jobNameTextBox.TabIndex = 14;
            jobNameTextBox.Tag = "4";
            jobNameTextBox.TextChanged += textBox_TextChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 224);
            addButton.Name = "addButton";
            addButton.Size = new Size(250, 29);
            addButton.TabIndex = 15;
            addButton.Text = "Добавить кандидата";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddCandidateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 265);
            Controls.Add(addButton);
            Controls.Add(jobNameTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(softSkillsRichTextBox);
            Controls.Add(label5);
            Controls.Add(hardSkillsRichTextBox);
            Controls.Add(label4);
            Controls.Add(previousWorkRichTextBox);
            Controls.Add(label3);
            Controls.Add(emailTextBox);
            Controls.Add(label2);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(label1);
            Controls.Add(initialsTextBox);
            Name = "AddCandidateForm";
            Text = "HRApp | Добавить кандидата";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox initialsTextBox;
        private Label label1;
        private Label label2;
        private TextBox phoneNumberTextBox;
        private Label label3;
        private TextBox emailTextBox;
        private RichTextBox previousWorkRichTextBox;
        private Label label4;
        private Label label5;
        private RichTextBox hardSkillsRichTextBox;
        private Label label6;
        private RichTextBox softSkillsRichTextBox;
        private Label label7;
        private Label label8;
        private TextBox jobNameTextBox;
        private Button addButton;
    }
}
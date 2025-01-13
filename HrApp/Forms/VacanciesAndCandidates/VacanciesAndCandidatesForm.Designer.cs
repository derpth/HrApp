namespace HrApp.Forms.VacanciesAndCandidates
{
    partial class VacanciesAndCandidatesForm
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
            label1 = new Label();
            label2 = new Label();
            vacanciesListBox = new ListBox();
            candidatesListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Вакансии";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 9);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 1;
            label2.Text = "Возможные кандидаты";
            // 
            // vacanciesListBox
            // 
            vacanciesListBox.FormattingEnabled = true;
            vacanciesListBox.ItemHeight = 20;
            vacanciesListBox.Location = new Point(12, 32);
            vacanciesListBox.Name = "vacanciesListBox";
            vacanciesListBox.Size = new Size(340, 404);
            vacanciesListBox.TabIndex = 2;
            vacanciesListBox.SelectedIndexChanged += vacanciesListBox_SelectedIndexChanged;
            vacanciesListBox.DoubleClick += vacanciesListBox_DoubleClick;
            // 
            // candidatesListBox
            // 
            candidatesListBox.FormattingEnabled = true;
            candidatesListBox.ItemHeight = 20;
            candidatesListBox.Location = new Point(377, 32);
            candidatesListBox.Name = "candidatesListBox";
            candidatesListBox.Size = new Size(340, 404);
            candidatesListBox.TabIndex = 3;
            candidatesListBox.DoubleClick += candidatesListBox_DoubleClick;
            // 
            // VacanciesAndCandidatesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 450);
            Controls.Add(candidatesListBox);
            Controls.Add(vacanciesListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VacanciesAndCandidatesForm";
            Text = "VacanciesAndCandidatesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox vacanciesListBox;
        private ListBox candidatesListBox;
    }
}
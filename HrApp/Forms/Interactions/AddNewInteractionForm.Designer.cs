namespace HrApp.Forms.Interactions
{
    partial class AddNewInteractionForm
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
            clientLabel = new Label();
            clientComboBox = new ComboBox();
            interactionDetailsRichTextBox = new RichTextBox();
            interactionDateTimePicker = new DateTimePicker();
            saveButton = new Button();
            dateLabel = new Label();
            detailsLabel = new Label();
            SuspendLayout();
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new Point(33, 29);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(137, 20);
            clientLabel.TabIndex = 0;
            clientLabel.Text = "Выберите клиента";
            // 
            // clientComboBox
            // 
            clientComboBox.FormattingEnabled = true;
            clientComboBox.Location = new Point(33, 61);
            clientComboBox.Name = "clientComboBox";
            clientComboBox.Size = new Size(202, 28);
            clientComboBox.TabIndex = 1;
            // 
            // interactionDetailsRichTextBox
            // 
            interactionDetailsRichTextBox.Location = new Point(33, 196);
            interactionDetailsRichTextBox.Name = "interactionDetailsRichTextBox";
            interactionDetailsRichTextBox.Size = new Size(202, 90);
            interactionDetailsRichTextBox.TabIndex = 2;
            interactionDetailsRichTextBox.Text = "";
            // 
            // interactionDateTimePicker
            // 
            interactionDateTimePicker.Location = new Point(33, 130);
            interactionDateTimePicker.Name = "interactionDateTimePicker";
            interactionDateTimePicker.Size = new Size(202, 27);
            interactionDateTimePicker.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(85, 292);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 4;
            saveButton.Text = "Добавить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += addButton_Click;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(33, 107);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(160, 20);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Дата взаимодействия";
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Location = new Point(33, 173);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(177, 20);
            detailsLabel.TabIndex = 6;
            detailsLabel.Text = "Детали взаимодействия";
            // 
            // AddNewInteractionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 345);
            Controls.Add(detailsLabel);
            Controls.Add(dateLabel);
            Controls.Add(saveButton);
            Controls.Add(interactionDateTimePicker);
            Controls.Add(interactionDetailsRichTextBox);
            Controls.Add(clientComboBox);
            Controls.Add(clientLabel);
            Name = "AddNewInteractionForm";
            Text = "Добавление";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clientLabel;
        private ComboBox clientComboBox;
        private RichTextBox interactionDetailsRichTextBox;
        private DateTimePicker interactionDateTimePicker;
        private Button saveButton;
        private Label dateLabel;
        private Label detailsLabel;
    }
}
namespace HrApp.Forms.Clients
{
    partial class ClientHistoryForm
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
            clientHistoryDataGridView = new DataGridView();
            ClientID = new DataGridViewTextBoxColumn();
            InteractionDate = new DataGridViewTextBoxColumn();
            Details = new DataGridViewTextBoxColumn();
            addButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)clientHistoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clientHistoryDataGridView
            // 
            clientHistoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientHistoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { ClientID, InteractionDate, Details });
            clientHistoryDataGridView.Location = new Point(12, 12);
            clientHistoryDataGridView.Name = "clientHistoryDataGridView";
            clientHistoryDataGridView.RowHeadersWidth = 51;
            clientHistoryDataGridView.RowTemplate.Height = 29;
            clientHistoryDataGridView.Size = new Size(492, 188);
            clientHistoryDataGridView.TabIndex = 0;
            // 
            // ClientID
            // 
            ClientID.HeaderText = "ID клиента";
            ClientID.MinimumWidth = 6;
            ClientID.Name = "ClientID";
            ClientID.Width = 125;
            // 
            // InteractionDate
            // 
            InteractionDate.HeaderText = "Дата взаимодействия";
            InteractionDate.MinimumWidth = 6;
            InteractionDate.Name = "InteractionDate";
            InteractionDate.Width = 125;
            // 
            // Details
            // 
            Details.HeaderText = "Детали Взаимодействия";
            Details.MinimumWidth = 6;
            Details.Name = "Details";
            Details.Width = 125;
            // 
            // addButton
            // 
            addButton.Location = new Point(48, 206);
            addButton.Name = "addButton";
            addButton.Size = new Size(173, 29);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(288, 206);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(173, 29);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // ClientHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 251);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(clientHistoryDataGridView);
            Name = "ClientHistoryForm";
            Text = "История взаимодействия";
            ((System.ComponentModel.ISupportInitialize)clientHistoryDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clientHistoryDataGridView;
        private DataGridViewTextBoxColumn ClientID;
        private DataGridViewTextBoxColumn InteractionDate;
        private DataGridViewTextBoxColumn Details;
        private Button addButton;
        private Button deleteButton;
    }
}
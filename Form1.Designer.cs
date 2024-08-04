namespace WinFormsApp_Liles
{
    partial class Form1
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
            btnAddClient = new Button();
            btnEditClient = new Button();
            btnDelete = new Button();
            clientsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)clientsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1378, 58);
            label1.TabIndex = 0;
            label1.Text = "List of Clients";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(12, 133);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(150, 46);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditClient.Location = new Point(1079, 133);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(150, 46);
            btnEditClient.TabIndex = 2;
            btnEditClient.Text = "Edit CLient";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(1235, 133);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // clientsTable
            // 
            clientsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsTable.Location = new Point(14, 262);
            clientsTable.MultiSelect = false;
            clientsTable.Name = "clientsTable";
            clientsTable.RowHeadersVisible = false;
            clientsTable.RowHeadersWidth = 82;
            clientsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsTable.Size = new Size(1371, 824);
            clientsTable.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 1098);
            Controls.Add(clientsTable);
            Controls.Add(btnDelete);
            Controls.Add(btnEditClient);
            Controls.Add(btnAddClient);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Clients Manager";
            ((System.ComponentModel.ISupportInitialize)clientsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAddClient;
        private Button btnEditClient;
        private Button btnDelete;
        private DataGridView clientsTable;
    }
}

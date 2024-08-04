namespace WinFormsApp_Liles
{
    partial class CreateEditForm
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
            lbTitle = new Label();
            label1 = new Label();
            lbId = new Label();
            label2 = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbAddress = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(1163, 64);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Create Client";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 122);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 1;
            label1.Text = "Client ID";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(432, 122);
            lbId.Name = "lbId";
            lbId.Size = new Size(0, 32);
            lbId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 183);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(432, 176);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(574, 39);
            tbFirstName.TabIndex = 4;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(432, 260);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(574, 39);
            tbLastName.TabIndex = 5;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(432, 340);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(574, 39);
            tbEmail.TabIndex = 6;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(432, 416);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(574, 39);
            tbPhone.TabIndex = 7;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(432, 493);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(574, 39);
            tbAddress.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 267);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 9;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 347);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 423);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 11;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 500);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 12;
            label6.Text = "Address";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(432, 586);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(599, 586);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 707);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbAddress);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(label2);
            Controls.Add(lbId);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Name = "CreateEditForm";
            Text = " Create Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label1;
        private Label lbId;
        private Label label2;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbAddress;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private Button btnCancel;
    }
}
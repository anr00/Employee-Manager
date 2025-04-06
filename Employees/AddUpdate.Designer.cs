namespace Employees
{
    partial class AddUpdate
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
            lbId = new Label();
            lbFirstName = new Label();
            lbLastName = new Label();
            lbEmail = new Label();
            lbJobTitle = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbEmail = new TextBox();
            tbJobTitle = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lbEmployeeId = new Label();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(21, 18);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(767, 43);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Add Employee";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(41, 87);
            lbId.Name = "lbId";
            lbId.Size = new Size(92, 20);
            lbId.TabIndex = 1;
            lbId.Text = "Employee Id";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(41, 123);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(80, 20);
            lbFirstName.TabIndex = 2;
            lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(41, 165);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(79, 20);
            lbLastName.TabIndex = 3;
            lbLastName.Text = "Last Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(41, 208);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(52, 20);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "E-mail";
            // 
            // lbJobTitle
            // 
            lbJobTitle.AutoSize = true;
            lbJobTitle.Location = new Point(41, 254);
            lbJobTitle.Name = "lbJobTitle";
            lbJobTitle.Size = new Size(65, 20);
            lbJobTitle.TabIndex = 5;
            lbJobTitle.Text = "Job Title";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(256, 123);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(386, 27);
            tbFirstName.TabIndex = 6;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(256, 165);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(386, 27);
            tbLastName.TabIndex = 7;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(256, 208);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(386, 27);
            tbEmail.TabIndex = 8;
            // 
            // tbJobTitle
            // 
            tbJobTitle.Location = new Point(256, 254);
            tbJobTitle.Name = "tbJobTitle";
            tbJobTitle.Size = new Size(386, 27);
            tbJobTitle.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(256, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(366, 315);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbEmployeeId
            // 
            lbEmployeeId.AutoSize = true;
            lbEmployeeId.Location = new Point(256, 87);
            lbEmployeeId.Name = "lbEmployeeId";
            lbEmployeeId.Size = new Size(0, 20);
            lbEmployeeId.TabIndex = 12;
            // 
            // CreateAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 407);
            Controls.Add(lbEmployeeId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbJobTitle);
            Controls.Add(tbEmail);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(lbJobTitle);
            Controls.Add(lbEmail);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(lbId);
            Controls.Add(lbTitle);
            Name = "CreateAdd";
            Text = "Add Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbId;
        private Label lbFirstName;
        private Label lbLastName;
        private Label lbEmail;
        private Label lbJobTitle;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbEmail;
        private TextBox tbJobTitle;
        private Button btnSave;
        private Button btnCancel;
        private Label lbEmployeeId;
    }
}
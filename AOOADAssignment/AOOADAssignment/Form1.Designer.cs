namespace AOOADAssignment
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmEventTxtBox = new System.Windows.Forms.TextBox();
            this.createEventTxtBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ticketListView = new System.Windows.Forms.ListView();
            this.ticketEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketCancel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFilterEndDate = new System.Windows.Forms.Button();
            this.btnFilterStartDate = new System.Windows.Forms.Button();
            this.btnFliter = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.browseListView = new System.Windows.Forms.ListView();
            this.eventNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endDateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login ID";
            // 
            // loginIDTextBox
            // 
            this.loginIDTextBox.Location = new System.Drawing.Point(65, 10);
            this.loginIDTextBox.Name = "loginIDTextBox";
            this.loginIDTextBox.Size = new System.Drawing.Size(195, 20);
            this.loginIDTextBox.TabIndex = 2;
            this.loginIDTextBox.Text = "uID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(65, 36);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(195, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Text = "pass";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(282, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 46);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.confirmEventTxtBox);
            this.tabPage3.Controls.Add(this.createEventTxtBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create/Close/Confirm Event";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Confirm Event";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Create Event";
            // 
            // confirmEventTxtBox
            // 
            this.confirmEventTxtBox.Location = new System.Drawing.Point(20, 174);
            this.confirmEventTxtBox.Multiline = true;
            this.confirmEventTxtBox.Name = "confirmEventTxtBox";
            this.confirmEventTxtBox.Size = new System.Drawing.Size(722, 124);
            this.confirmEventTxtBox.TabIndex = 1;
            // 
            // createEventTxtBox
            // 
            this.createEventTxtBox.Location = new System.Drawing.Point(20, 28);
            this.createEventTxtBox.Multiline = true;
            this.createEventTxtBox.Name = "createEventTxtBox";
            this.createEventTxtBox.Size = new System.Drawing.Size(722, 127);
            this.createEventTxtBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ticketListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Ticket details or Cancel";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // ticketListView
            // 
            this.ticketListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ticketEventName,
            this.ticketStartDate,
            this.ticketEndDate,
            this.ticketCancel});
            this.ticketListView.FullRowSelect = true;
            this.ticketListView.Location = new System.Drawing.Point(20, 27);
            this.ticketListView.Name = "ticketListView";
            this.ticketListView.Size = new System.Drawing.Size(722, 263);
            this.ticketListView.TabIndex = 4;
            this.ticketListView.UseCompatibleStateImageBehavior = false;
            // 
            // ticketEventName
            // 
            this.ticketEventName.Text = "Event Name";
            this.ticketEventName.Width = 140;
            // 
            // ticketStartDate
            // 
            this.ticketStartDate.Text = "Start Date";
            this.ticketStartDate.Width = 140;
            // 
            // ticketEndDate
            // 
            this.ticketEndDate.Text = "End Date";
            this.ticketEndDate.Width = 140;
            // 
            // ticketCancel
            // 
            this.ticketCancel.Text = "Cancel Ticket";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFilterEndDate);
            this.tabPage1.Controls.Add(this.btnFilterStartDate);
            this.tabPage1.Controls.Add(this.btnFliter);
            this.tabPage1.Controls.Add(this.btnView);
            this.tabPage1.Controls.Add(this.browseListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Browse Event";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnFilterEndDate
            // 
            this.btnFilterEndDate.Location = new System.Drawing.Point(319, 19);
            this.btnFilterEndDate.Name = "btnFilterEndDate";
            this.btnFilterEndDate.Size = new System.Drawing.Size(140, 23);
            this.btnFilterEndDate.TabIndex = 7;
            this.btnFilterEndDate.Text = "End Date";
            this.btnFilterEndDate.UseVisualStyleBackColor = true;
            this.btnFilterEndDate.Click += new System.EventHandler(this.btnFilterEndDate_Click);
            // 
            // btnFilterStartDate
            // 
            this.btnFilterStartDate.Location = new System.Drawing.Point(174, 19);
            this.btnFilterStartDate.Name = "btnFilterStartDate";
            this.btnFilterStartDate.Size = new System.Drawing.Size(143, 23);
            this.btnFilterStartDate.TabIndex = 6;
            this.btnFilterStartDate.Text = "Start Date";
            this.btnFilterStartDate.UseVisualStyleBackColor = true;
            this.btnFilterStartDate.Click += new System.EventHandler(this.btnFilterStartDate_Click);
            // 
            // btnFliter
            // 
            this.btnFliter.Location = new System.Drawing.Point(18, 19);
            this.btnFliter.Name = "btnFliter";
            this.btnFliter.Size = new System.Drawing.Size(155, 23);
            this.btnFliter.TabIndex = 5;
            this.btnFliter.Text = "Event name";
            this.btnFliter.UseVisualStyleBackColor = true;
            this.btnFliter.Click += new System.EventHandler(this.btnEventFliter_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(545, 291);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(195, 23);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // browseListView
            // 
            this.browseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventNameCol,
            this.startDateCol,
            this.endDateCol});
            this.browseListView.FullRowSelect = true;
            this.browseListView.Location = new System.Drawing.Point(18, 18);
            this.browseListView.Name = "browseListView";
            this.browseListView.Size = new System.Drawing.Size(722, 267);
            this.browseListView.TabIndex = 3;
            this.browseListView.UseCompatibleStateImageBehavior = false;
            // 
            // eventNameCol
            // 
            this.eventNameCol.Text = "Event Name";
            this.eventNameCol.Width = 140;
            // 
            // startDateCol
            // 
            this.startDateCol.Text = "Start Date";
            this.startDateCol.Width = 140;
            // 
            // endDateCol
            // 
            this.endDateCol.Text = "End Date";
            this.endDateCol.Width = 140;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 343);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(794, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Brotic System";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmEventTxtBox;
        private System.Windows.Forms.TextBox createEventTxtBox;
        private System.Windows.Forms.ListView browseListView;
        private System.Windows.Forms.ColumnHeader eventNameCol;
        private System.Windows.Forms.ColumnHeader startDateCol;
        private System.Windows.Forms.ColumnHeader endDateCol;
        private System.Windows.Forms.ListView ticketListView;
        private System.Windows.Forms.ColumnHeader ticketEventName;
        private System.Windows.Forms.ColumnHeader ticketStartDate;
        private System.Windows.Forms.ColumnHeader ticketEndDate;
        private System.Windows.Forms.ColumnHeader ticketCancel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnFliter;
        private System.Windows.Forms.Button btnFilterEndDate;
        private System.Windows.Forms.Button btnFilterStartDate;
    }
}


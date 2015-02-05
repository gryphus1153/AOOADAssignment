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
            this.label4 = new System.Windows.Forms.Label();
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
            this.eventNameTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.genreTxtBox = new System.Windows.Forms.TextBox();
            this.endDateTxtBox = new System.Windows.Forms.TextBox();
            this.startDateTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.minSeatsTxtBox = new System.Windows.Forms.TextBox();
            this.performanceslbl = new System.Windows.Forms.Label();
            this.performanceTxtBox = new System.Windows.Forms.TextBox();
            this.addPerformanceBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.confirmEventTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.createBtn);
            this.tabPage3.Controls.Add(this.removeBtn);
            this.tabPage3.Controls.Add(this.addPerformanceBtn);
            this.tabPage3.Controls.Add(this.performanceTxtBox);
            this.tabPage3.Controls.Add(this.performanceslbl);
            this.tabPage3.Controls.Add(this.minSeatsTxtBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.startDateTxtBox);
            this.tabPage3.Controls.Add(this.endDateTxtBox);
            this.tabPage3.Controls.Add(this.genreTxtBox);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.eventNameTxtBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create/Close/Confirm Event";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Create Event";
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
            this.tabControl1.Controls.Add(this.tabPage4);
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
            // eventNameTxtBox
            // 
            this.eventNameTxtBox.Location = new System.Drawing.Point(127, 26);
            this.eventNameTxtBox.Name = "eventNameTxtBox";
            this.eventNameTxtBox.Size = new System.Drawing.Size(489, 20);
            this.eventNameTxtBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Event Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Genre";
            // 
            // genreTxtBox
            // 
            this.genreTxtBox.Location = new System.Drawing.Point(127, 107);
            this.genreTxtBox.Name = "genreTxtBox";
            this.genreTxtBox.Size = new System.Drawing.Size(489, 20);
            this.genreTxtBox.TabIndex = 9;
            // 
            // endDateTxtBox
            // 
            this.endDateTxtBox.Location = new System.Drawing.Point(127, 78);
            this.endDateTxtBox.Name = "endDateTxtBox";
            this.endDateTxtBox.Size = new System.Drawing.Size(489, 20);
            this.endDateTxtBox.TabIndex = 10;
            // 
            // startDateTxtBox
            // 
            this.startDateTxtBox.Location = new System.Drawing.Point(127, 52);
            this.startDateTxtBox.Name = "startDateTxtBox";
            this.startDateTxtBox.Size = new System.Drawing.Size(489, 20);
            this.startDateTxtBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Min. Seats";
            // 
            // minSeatsTxtBox
            // 
            this.minSeatsTxtBox.Location = new System.Drawing.Point(127, 141);
            this.minSeatsTxtBox.Name = "minSeatsTxtBox";
            this.minSeatsTxtBox.Size = new System.Drawing.Size(489, 20);
            this.minSeatsTxtBox.TabIndex = 15;
            // 
            // performanceslbl
            // 
            this.performanceslbl.AutoSize = true;
            this.performanceslbl.Location = new System.Drawing.Point(45, 176);
            this.performanceslbl.Name = "performanceslbl";
            this.performanceslbl.Size = new System.Drawing.Size(72, 13);
            this.performanceslbl.TabIndex = 16;
            this.performanceslbl.Text = "Performances";
            // 
            // performanceTxtBox
            // 
            this.performanceTxtBox.Location = new System.Drawing.Point(127, 176);
            this.performanceTxtBox.Multiline = true;
            this.performanceTxtBox.Name = "performanceTxtBox";
            this.performanceTxtBox.Size = new System.Drawing.Size(489, 122);
            this.performanceTxtBox.TabIndex = 17;
            // 
            // addPerformanceBtn
            // 
            this.addPerformanceBtn.Location = new System.Drawing.Point(46, 195);
            this.addPerformanceBtn.Name = "addPerformanceBtn";
            this.addPerformanceBtn.Size = new System.Drawing.Size(75, 23);
            this.addPerformanceBtn.TabIndex = 18;
            this.addPerformanceBtn.Text = "Add >>";
            this.addPerformanceBtn.UseVisualStyleBackColor = true;
            this.addPerformanceBtn.Click += new System.EventHandler(this.addPerformanceBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(46, 224);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 22);
            this.removeBtn.TabIndex = 19;
            this.removeBtn.Text = "Remove <<";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(652, 276);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(104, 35);
            this.createBtn.TabIndex = 20;
            this.createBtn.Text = "Confirm Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.confirmEventTxtBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(762, 317);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Confirm / Close Event";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // confirmEventTxtBox
            // 
            this.confirmEventTxtBox.Location = new System.Drawing.Point(20, 47);
            this.confirmEventTxtBox.Multiline = true;
            this.confirmEventTxtBox.Name = "confirmEventTxtBox";
            this.confirmEventTxtBox.Size = new System.Drawing.Size(722, 229);
            this.confirmEventTxtBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Event";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eventNameTxtBox;
        private System.Windows.Forms.TextBox startDateTxtBox;
        private System.Windows.Forms.TextBox endDateTxtBox;
        private System.Windows.Forms.TextBox genreTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox minSeatsTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addPerformanceBtn;
        private System.Windows.Forms.TextBox performanceTxtBox;
        private System.Windows.Forms.Label performanceslbl;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirmEventTxtBox;
    }
}


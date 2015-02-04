namespace AOOADAssignment
{
    partial class viewEventForm
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
            this.viewEventTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewEventTxtBox
            // 
            this.viewEventTxtBox.Location = new System.Drawing.Point(12, 44);
            this.viewEventTxtBox.Multiline = true;
            this.viewEventTxtBox.Name = "viewEventTxtBox";
            this.viewEventTxtBox.Size = new System.Drawing.Size(722, 204);
            this.viewEventTxtBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buy Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Follow";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // viewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 288);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewEventTxtBox);
            this.Name = "viewEventForm";
            this.Text = "viewEventForm";
            this.Load += new System.EventHandler(this.viewEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox viewEventTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
namespace TASK_KILLER
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
            this.programBox = new System.Windows.Forms.RichTextBox();
            this.getAppBtn = new System.Windows.Forms.Button();
            this.deleteAppBtn = new System.Windows.Forms.Button();
            this.AppCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.messagelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // programBox
            // 
            this.programBox.Location = new System.Drawing.Point(18, 21);
            this.programBox.Name = "programBox";
            this.programBox.Size = new System.Drawing.Size(173, 33);
            this.programBox.TabIndex = 0;
            this.programBox.Text = "IPA";
            this.programBox.TextChanged += new System.EventHandler(this.OnAppTextChanged);
            // 
            // getAppBtn
            // 
            this.getAppBtn.Location = new System.Drawing.Point(218, 21);
            this.getAppBtn.Name = "getAppBtn";
            this.getAppBtn.Size = new System.Drawing.Size(173, 33);
            this.getAppBtn.TabIndex = 1;
            this.getAppBtn.Text = "Get App(s)";
            this.getAppBtn.UseVisualStyleBackColor = true;
            this.getAppBtn.Click += new System.EventHandler(this.getAppBtn_Click);
            // 
            // deleteAppBtn
            // 
            this.deleteAppBtn.Enabled = false;
            this.deleteAppBtn.Location = new System.Drawing.Point(419, 21);
            this.deleteAppBtn.Name = "deleteAppBtn";
            this.deleteAppBtn.Size = new System.Drawing.Size(135, 33);
            this.deleteAppBtn.TabIndex = 2;
            this.deleteAppBtn.Text = "Stop App(s)";
            this.deleteAppBtn.UseVisualStyleBackColor = true;
            this.deleteAppBtn.Click += new System.EventHandler(this.deleteAppBtn_Click);
            // 
            // AppCheckBoxList
            // 
            this.AppCheckBoxList.FormattingEnabled = true;
            this.AppCheckBoxList.Location = new System.Drawing.Point(18, 83);
            this.AppCheckBoxList.Name = "AppCheckBoxList";
            this.AppCheckBoxList.Size = new System.Drawing.Size(536, 327);
            this.AppCheckBoxList.TabIndex = 4;
            this.AppCheckBoxList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnItemChecked);
            // 
            // messagelbl
            // 
            this.messagelbl.ForeColor = System.Drawing.Color.Green;
            this.messagelbl.Location = new System.Drawing.Point(18, 427);
            this.messagelbl.Name = "messagelbl";
            this.messagelbl.Size = new System.Drawing.Size(536, 24);
            this.messagelbl.TabIndex = 5;
            this.messagelbl.Text = "WAITING FOR COMMAND...";
            this.messagelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 473);
            this.Controls.Add(this.messagelbl);
            this.Controls.Add(this.AppCheckBoxList);
            this.Controls.Add(this.deleteAppBtn);
            this.Controls.Add(this.getAppBtn);
            this.Controls.Add(this.programBox);
            this.Name = "Form1";
            this.Text = "Capture Apps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox programBox;
        private System.Windows.Forms.Button getAppBtn;
        private System.Windows.Forms.Button deleteAppBtn;
        private System.Windows.Forms.CheckedListBox AppCheckBoxList;
        private System.Windows.Forms.Label messagelbl;
    }
}


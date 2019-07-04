namespace Domain_Checker
{
    partial class Domain_Checker
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.chkIsDomain = new System.Windows.Forms.CheckBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblActive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 26);
            this.txtUserName.TabIndex = 0;
            // 
            // chkIsDomain
            // 
            this.chkIsDomain.AutoSize = true;
            this.chkIsDomain.Location = new System.Drawing.Point(293, 14);
            this.chkIsDomain.Name = "chkIsDomain";
            this.chkIsDomain.Size = new System.Drawing.Size(99, 24);
            this.chkIsDomain.TabIndex = 2;
            this.chkIsDomain.Text = "Domain?";
            this.chkIsDomain.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 109);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(450, 319);
            this.txtOutput.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(118, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(89, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(398, 9);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 33);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(13, 83);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(0, 20);
            this.lblActive.TabIndex = 4;
            // 
            // Domain_Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 440);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.chkIsDomain);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Domain_Checker";
            this.Text = "Domain Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox chkIsDomain;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblActive;
    }
}


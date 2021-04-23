namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    partial class openAccount
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
            this.custLName = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.custFName = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.accountSelectCombo = new System.Windows.Forms.ComboBox();
            this.balanceInput = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custLName
            // 
            this.custLName.AutoSize = true;
            this.custLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custLName.Location = new System.Drawing.Point(142, 131);
            this.custLName.Name = "custLName";
            this.custLName.Size = new System.Drawing.Size(159, 20);
            this.custLName.TabIndex = 8;
            this.custLName.Text = "Customer Last Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(22, 131);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // custFName
            // 
            this.custFName.AutoSize = true;
            this.custFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custFName.Location = new System.Drawing.Point(142, 86);
            this.custFName.Name = "custFName";
            this.custFName.Size = new System.Drawing.Size(159, 20);
            this.custFName.TabIndex = 6;
            this.custFName.Text = "Customer First Name";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(22, 86);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(90, 20);
            this.fNameLabel.TabIndex = 5;
            this.fNameLabel.Text = "First Name:";
            // 
            // accountSelectCombo
            // 
            this.accountSelectCombo.FormattingEnabled = true;
            this.accountSelectCombo.Location = new System.Drawing.Point(26, 173);
            this.accountSelectCombo.Name = "accountSelectCombo";
            this.accountSelectCombo.Size = new System.Drawing.Size(227, 21);
            this.accountSelectCombo.TabIndex = 9;
            // 
            // balanceInput
            // 
            this.balanceInput.Location = new System.Drawing.Point(274, 173);
            this.balanceInput.Name = "balanceInput";
            this.balanceInput.Size = new System.Drawing.Size(224, 20);
            this.balanceInput.TabIndex = 10;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(26, 231);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(227, 23);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(274, 231);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(224, 23);
            this.createAccountBtn.TabIndex = 12;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // openAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(548, 283);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.balanceInput);
            this.Controls.Add(this.accountSelectCombo);
            this.Controls.Add(this.custLName);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.custFName);
            this.Controls.Add(this.fNameLabel);
            this.Name = "openAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.openAccount_FormClosing);
            this.Controls.SetChildIndex(this.fNameLabel, 0);
            this.Controls.SetChildIndex(this.custFName, 0);
            this.Controls.SetChildIndex(this.lastNameLabel, 0);
            this.Controls.SetChildIndex(this.custLName, 0);
            this.Controls.SetChildIndex(this.accountSelectCombo, 0);
            this.Controls.SetChildIndex(this.balanceInput, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.Controls.SetChildIndex(this.createAccountBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custLName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label custFName;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.ComboBox accountSelectCombo;
        private System.Windows.Forms.TextBox balanceInput;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button createAccountBtn;
    }
}

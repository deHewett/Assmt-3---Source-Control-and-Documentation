namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    partial class viewCustomer
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
            this.fNameLabel = new System.Windows.Forms.Label();
            this.custFName = new System.Windows.Forms.Label();
            this.custLName = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.custPhNum = new System.Windows.Forms.Label();
            this.phNumLabel = new System.Windows.Forms.Label();
            this.custEmail = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.accountsCombo = new System.Windows.Forms.ComboBox();
            this.transferBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(16, 97);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(90, 20);
            this.fNameLabel.TabIndex = 1;
            this.fNameLabel.Text = "First Name:";
            // 
            // custFName
            // 
            this.custFName.AutoSize = true;
            this.custFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custFName.Location = new System.Drawing.Point(136, 97);
            this.custFName.Name = "custFName";
            this.custFName.Size = new System.Drawing.Size(159, 20);
            this.custFName.TabIndex = 2;
            this.custFName.Text = "Customer First Name";
            // 
            // custLName
            // 
            this.custLName.AutoSize = true;
            this.custLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custLName.Location = new System.Drawing.Point(136, 142);
            this.custLName.Name = "custLName";
            this.custLName.Size = new System.Drawing.Size(159, 20);
            this.custLName.TabIndex = 4;
            this.custLName.Text = "Customer Last Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(16, 142);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // custPhNum
            // 
            this.custPhNum.AutoSize = true;
            this.custPhNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPhNum.Location = new System.Drawing.Point(136, 187);
            this.custPhNum.Name = "custPhNum";
            this.custPhNum.Size = new System.Drawing.Size(188, 20);
            this.custPhNum.TabIndex = 6;
            this.custPhNum.Text = "Customer Phone Number";
            // 
            // phNumLabel
            // 
            this.phNumLabel.AutoSize = true;
            this.phNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phNumLabel.Location = new System.Drawing.Point(16, 187);
            this.phNumLabel.Name = "phNumLabel";
            this.phNumLabel.Size = new System.Drawing.Size(115, 20);
            this.phNumLabel.TabIndex = 5;
            this.phNumLabel.Text = "Phone Number";
            // 
            // custEmail
            // 
            this.custEmail.AutoSize = true;
            this.custEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custEmail.Location = new System.Drawing.Point(136, 232);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(184, 20);
            this.custEmail.TabIndex = 8;
            this.custEmail.Text = "Customer Email Address";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(16, 232);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(115, 20);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email Address:";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(254, 314);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(233, 23);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // accountsLabel
            // 
            this.accountsLabel.AutoSize = true;
            this.accountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountsLabel.Location = new System.Drawing.Point(20, 270);
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.Size = new System.Drawing.Size(80, 20);
            this.accountsLabel.TabIndex = 16;
            this.accountsLabel.Text = "Accounts:";
            // 
            // accountsCombo
            // 
            this.accountsCombo.FormattingEnabled = true;
            this.accountsCombo.Location = new System.Drawing.Point(140, 272);
            this.accountsCombo.Name = "accountsCombo";
            this.accountsCombo.Size = new System.Drawing.Size(316, 21);
            this.accountsCombo.TabIndex = 17;
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(19, 314);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(214, 22);
            this.transferBtn.TabIndex = 18;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // viewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(524, 362);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.accountsCombo);
            this.Controls.Add(this.accountsLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.custPhNum);
            this.Controls.Add(this.phNumLabel);
            this.Controls.Add(this.custLName);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.custFName);
            this.Controls.Add(this.fNameLabel);
            this.Name = "viewCustomer";
            this.Controls.SetChildIndex(this.fNameLabel, 0);
            this.Controls.SetChildIndex(this.custFName, 0);
            this.Controls.SetChildIndex(this.lastNameLabel, 0);
            this.Controls.SetChildIndex(this.custLName, 0);
            this.Controls.SetChildIndex(this.phNumLabel, 0);
            this.Controls.SetChildIndex(this.custPhNum, 0);
            this.Controls.SetChildIndex(this.emailLabel, 0);
            this.Controls.SetChildIndex(this.custEmail, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.Controls.SetChildIndex(this.accountsLabel, 0);
            this.Controls.SetChildIndex(this.accountsCombo, 0);
            this.Controls.SetChildIndex(this.transferBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label custFName;
        private System.Windows.Forms.Label custLName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label custPhNum;
        private System.Windows.Forms.Label phNumLabel;
        private System.Windows.Forms.Label custEmail;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label accountsLabel;
        private System.Windows.Forms.ComboBox accountsCombo;
        private System.Windows.Forms.Button transferBtn;
    }
}

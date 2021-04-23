namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    partial class createCust
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
            this.custFirstName = new System.Windows.Forms.Label();
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.custLastName = new System.Windows.Forms.Label();
            this.phNumInput = new System.Windows.Forms.TextBox();
            this.custPhNumber = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.custEmail = new System.Windows.Forms.Label();
            this.cancelCust = new System.Windows.Forms.Button();
            this.submitCust = new System.Windows.Forms.Button();
            this.staffCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // custFirstName
            // 
            this.custFirstName.AutoSize = true;
            this.custFirstName.Location = new System.Drawing.Point(16, 75);
            this.custFirstName.Name = "custFirstName";
            this.custFirstName.Size = new System.Drawing.Size(60, 13);
            this.custFirstName.TabIndex = 1;
            this.custFirstName.Text = "First Name:";
            // 
            // fNameInput
            // 
            this.fNameInput.Location = new System.Drawing.Point(103, 72);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(325, 20);
            this.fNameInput.TabIndex = 2;
            // 
            // lNameInput
            // 
            this.lNameInput.Location = new System.Drawing.Point(103, 112);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(325, 20);
            this.lNameInput.TabIndex = 4;
            // 
            // custLastName
            // 
            this.custLastName.AutoSize = true;
            this.custLastName.Location = new System.Drawing.Point(16, 115);
            this.custLastName.Name = "custLastName";
            this.custLastName.Size = new System.Drawing.Size(61, 13);
            this.custLastName.TabIndex = 3;
            this.custLastName.Text = "Last Name:";
            // 
            // phNumInput
            // 
            this.phNumInput.Location = new System.Drawing.Point(103, 153);
            this.phNumInput.Name = "phNumInput";
            this.phNumInput.Size = new System.Drawing.Size(325, 20);
            this.phNumInput.TabIndex = 6;
            // 
            // custPhNumber
            // 
            this.custPhNumber.AutoSize = true;
            this.custPhNumber.Location = new System.Drawing.Point(16, 156);
            this.custPhNumber.Name = "custPhNumber";
            this.custPhNumber.Size = new System.Drawing.Size(81, 13);
            this.custPhNumber.TabIndex = 5;
            this.custPhNumber.Text = "Phone Number:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(103, 194);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(325, 20);
            this.emailInput.TabIndex = 8;
            // 
            // custEmail
            // 
            this.custEmail.AutoSize = true;
            this.custEmail.Location = new System.Drawing.Point(16, 197);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(35, 13);
            this.custEmail.TabIndex = 7;
            this.custEmail.Text = "Email:";
            // 
            // cancelCust
            // 
            this.cancelCust.Location = new System.Drawing.Point(103, 268);
            this.cancelCust.Name = "cancelCust";
            this.cancelCust.Size = new System.Drawing.Size(150, 23);
            this.cancelCust.TabIndex = 9;
            this.cancelCust.Text = "Cancel";
            this.cancelCust.UseVisualStyleBackColor = true;
            this.cancelCust.Click += new System.EventHandler(this.cancelCust_Click);
            // 
            // submitCust
            // 
            this.submitCust.Location = new System.Drawing.Point(277, 268);
            this.submitCust.Name = "submitCust";
            this.submitCust.Size = new System.Drawing.Size(150, 23);
            this.submitCust.TabIndex = 10;
            this.submitCust.Text = "Submit";
            this.submitCust.UseVisualStyleBackColor = true;
            this.submitCust.Click += new System.EventHandler(this.submitCust_Click);
            // 
            // staffCheckBox
            // 
            this.staffCheckBox.AutoSize = true;
            this.staffCheckBox.Location = new System.Drawing.Point(224, 235);
            this.staffCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.staffCheckBox.Name = "staffCheckBox";
            this.staffCheckBox.Size = new System.Drawing.Size(89, 17);
            this.staffCheckBox.TabIndex = 13;
            this.staffCheckBox.Text = "Staff Member";
            this.staffCheckBox.UseVisualStyleBackColor = true;
            // 
            // createCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(445, 301);
            this.Controls.Add(this.staffCheckBox);
            this.Controls.Add(this.submitCust);
            this.Controls.Add(this.cancelCust);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.phNumInput);
            this.Controls.Add(this.custPhNumber);
            this.Controls.Add(this.lNameInput);
            this.Controls.Add(this.custLastName);
            this.Controls.Add(this.fNameInput);
            this.Controls.Add(this.custFirstName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "createCust";
            this.Controls.SetChildIndex(this.custFirstName, 0);
            this.Controls.SetChildIndex(this.fNameInput, 0);
            this.Controls.SetChildIndex(this.custLastName, 0);
            this.Controls.SetChildIndex(this.lNameInput, 0);
            this.Controls.SetChildIndex(this.custPhNumber, 0);
            this.Controls.SetChildIndex(this.phNumInput, 0);
            this.Controls.SetChildIndex(this.custEmail, 0);
            this.Controls.SetChildIndex(this.emailInput, 0);
            this.Controls.SetChildIndex(this.cancelCust, 0);
            this.Controls.SetChildIndex(this.submitCust, 0);
            this.Controls.SetChildIndex(this.staffCheckBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custFirstName;
        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.Label custLastName;
        private System.Windows.Forms.TextBox phNumInput;
        private System.Windows.Forms.Label custPhNumber;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label custEmail;
        private System.Windows.Forms.Button cancelCust;
        private System.Windows.Forms.Button submitCust;
        private System.Windows.Forms.CheckBox staffCheckBox;
    }
}

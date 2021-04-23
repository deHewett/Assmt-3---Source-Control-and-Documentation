namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    partial class editCust
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
            this.submitCust = new System.Windows.Forms.Button();
            this.cancelCust = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.custEmail = new System.Windows.Forms.Label();
            this.phNumInput = new System.Windows.Forms.TextBox();
            this.custPhNumber = new System.Windows.Forms.Label();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.custFirstName = new System.Windows.Forms.Label();
            this.staffCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // submitCust
            // 
            this.submitCust.Location = new System.Drawing.Point(379, 358);
            this.submitCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitCust.Name = "submitCust";
            this.submitCust.Size = new System.Drawing.Size(200, 28);
            this.submitCust.TabIndex = 20;
            this.submitCust.Text = "Submit";
            this.submitCust.UseVisualStyleBackColor = true;
            this.submitCust.Click += new System.EventHandler(this.submitCust_Click);
            // 
            // cancelCust
            // 
            this.cancelCust.Location = new System.Drawing.Point(146, 358);
            this.cancelCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelCust.Name = "cancelCust";
            this.cancelCust.Size = new System.Drawing.Size(200, 28);
            this.cancelCust.TabIndex = 19;
            this.cancelCust.Text = "Cancel";
            this.cancelCust.UseVisualStyleBackColor = true;
            this.cancelCust.Click += new System.EventHandler(this.cancelCust_Click);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(147, 262);
            this.emailInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(432, 22);
            this.emailInput.TabIndex = 18;
            // 
            // custEmail
            // 
            this.custEmail.AutoSize = true;
            this.custEmail.Location = new System.Drawing.Point(31, 266);
            this.custEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(45, 16);
            this.custEmail.TabIndex = 17;
            this.custEmail.Text = "Email:";
            // 
            // phNumInput
            // 
            this.phNumInput.Location = new System.Drawing.Point(147, 212);
            this.phNumInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phNumInput.Name = "phNumInput";
            this.phNumInput.Size = new System.Drawing.Size(432, 22);
            this.phNumInput.TabIndex = 16;
            // 
            // custPhNumber
            // 
            this.custPhNumber.AutoSize = true;
            this.custPhNumber.Location = new System.Drawing.Point(31, 215);
            this.custPhNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.custPhNumber.Name = "custPhNumber";
            this.custPhNumber.Size = new System.Drawing.Size(101, 16);
            this.custPhNumber.TabIndex = 15;
            this.custPhNumber.Text = "Phone Number:";
            // 
            // lNameInput
            // 
            this.lNameInput.Location = new System.Drawing.Point(147, 161);
            this.lNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(432, 22);
            this.lNameInput.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name:";
            // 
            // fNameInput
            // 
            this.fNameInput.Location = new System.Drawing.Point(147, 112);
            this.fNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(432, 22);
            this.fNameInput.TabIndex = 12;
            // 
            // custFirstName
            // 
            this.custFirstName.AutoSize = true;
            this.custFirstName.Location = new System.Drawing.Point(31, 116);
            this.custFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.custFirstName.Name = "custFirstName";
            this.custFirstName.Size = new System.Drawing.Size(76, 16);
            this.custFirstName.TabIndex = 11;
            this.custFirstName.Text = "First Name:";
            // 
            // staffCheckBox
            // 
            this.staffCheckBox.AutoSize = true;
            this.staffCheckBox.Location = new System.Drawing.Point(316, 311);
            this.staffCheckBox.Name = "staffCheckBox";
            this.staffCheckBox.Size = new System.Drawing.Size(106, 20);
            this.staffCheckBox.TabIndex = 21;
            this.staffCheckBox.Text = "Staff Member";
            this.staffCheckBox.UseVisualStyleBackColor = true;
            // 
            // editCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(613, 399);
            this.Controls.Add(this.staffCheckBox);
            this.Controls.Add(this.submitCust);
            this.Controls.Add(this.cancelCust);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.phNumInput);
            this.Controls.Add(this.custPhNumber);
            this.Controls.Add(this.lNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fNameInput);
            this.Controls.Add(this.custFirstName);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "editCust";
            this.Controls.SetChildIndex(this.custFirstName, 0);
            this.Controls.SetChildIndex(this.fNameInput, 0);
            this.Controls.SetChildIndex(this.label2, 0);
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

        private System.Windows.Forms.Button submitCust;
        private System.Windows.Forms.Button cancelCust;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label custEmail;
        private System.Windows.Forms.TextBox phNumInput;
        private System.Windows.Forms.Label custPhNumber;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.Label custFirstName;
        private System.Windows.Forms.CheckBox staffCheckBox;
    }
}

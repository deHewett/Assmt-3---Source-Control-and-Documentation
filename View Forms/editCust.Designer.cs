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
            this.SuspendLayout();
            // 
            // submitCust
            // 
            this.submitCust.Location = new System.Drawing.Point(285, 250);
            this.submitCust.Name = "submitCust";
            this.submitCust.Size = new System.Drawing.Size(150, 23);
            this.submitCust.TabIndex = 20;
            this.submitCust.Text = "Submit";
            this.submitCust.UseVisualStyleBackColor = true;
            this.submitCust.Click += new System.EventHandler(this.submitCust_Click);
            // 
            // cancelCust
            // 
            this.cancelCust.Location = new System.Drawing.Point(110, 250);
            this.cancelCust.Name = "cancelCust";
            this.cancelCust.Size = new System.Drawing.Size(150, 23);
            this.cancelCust.TabIndex = 19;
            this.cancelCust.Text = "Cancel";
            this.cancelCust.UseVisualStyleBackColor = true;
            this.cancelCust.Click += new System.EventHandler(this.cancelCust_Click);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(110, 213);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(325, 20);
            this.emailInput.TabIndex = 18;
            // 
            // custEmail
            // 
            this.custEmail.AutoSize = true;
            this.custEmail.Location = new System.Drawing.Point(23, 216);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(35, 13);
            this.custEmail.TabIndex = 17;
            this.custEmail.Text = "Email:";
            // 
            // phNumInput
            // 
            this.phNumInput.Location = new System.Drawing.Point(110, 172);
            this.phNumInput.Name = "phNumInput";
            this.phNumInput.Size = new System.Drawing.Size(325, 20);
            this.phNumInput.TabIndex = 16;
            // 
            // custPhNumber
            // 
            this.custPhNumber.AutoSize = true;
            this.custPhNumber.Location = new System.Drawing.Point(23, 175);
            this.custPhNumber.Name = "custPhNumber";
            this.custPhNumber.Size = new System.Drawing.Size(81, 13);
            this.custPhNumber.TabIndex = 15;
            this.custPhNumber.Text = "Phone Number:";
            // 
            // lNameInput
            // 
            this.lNameInput.Location = new System.Drawing.Point(110, 131);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(325, 20);
            this.lNameInput.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name:";
            // 
            // fNameInput
            // 
            this.fNameInput.Location = new System.Drawing.Point(110, 91);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(325, 20);
            this.fNameInput.TabIndex = 12;
            // 
            // custFirstName
            // 
            this.custFirstName.AutoSize = true;
            this.custFirstName.Location = new System.Drawing.Point(23, 94);
            this.custFirstName.Name = "custFirstName";
            this.custFirstName.Size = new System.Drawing.Size(60, 13);
            this.custFirstName.TabIndex = 11;
            this.custFirstName.Text = "First Name:";
            // 
            // editCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(460, 291);
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
    }
}

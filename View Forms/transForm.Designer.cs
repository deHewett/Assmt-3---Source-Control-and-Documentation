namespace Assmt_2___GUI_Debugging_and_Testing.View_Forms
{
    partial class transForm
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
            this.custNameLbl = new System.Windows.Forms.Label();
            this.custNameActual = new System.Windows.Forms.Label();
            this.transferFromCombo = new System.Windows.Forms.ComboBox();
            this.transferToCombo = new System.Windows.Forms.ComboBox();
            this.transferAmountInput = new System.Windows.Forms.TextBox();
            this.transferFromLabel = new System.Windows.Forms.Label();
            this.transferToLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.transferBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custNameLbl
            // 
            this.custNameLbl.AutoSize = true;
            this.custNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.custNameLbl.Location = new System.Drawing.Point(19, 104);
            this.custNameLbl.Name = "custNameLbl";
            this.custNameLbl.Size = new System.Drawing.Size(55, 20);
            this.custNameLbl.TabIndex = 1;
            this.custNameLbl.Text = "Name:";
            // 
            // custNameActual
            // 
            this.custNameActual.AutoSize = true;
            this.custNameActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.custNameActual.Location = new System.Drawing.Point(137, 104);
            this.custNameActual.Name = "custNameActual";
            this.custNameActual.Size = new System.Drawing.Size(211, 20);
            this.custNameActual.TabIndex = 2;
            this.custNameActual.Text = "Customer Name Placeholder";
            // 
            // transferFromCombo
            // 
            this.transferFromCombo.FormattingEnabled = true;
            this.transferFromCombo.Location = new System.Drawing.Point(23, 164);
            this.transferFromCombo.Name = "transferFromCombo";
            this.transferFromCombo.Size = new System.Drawing.Size(325, 21);
            this.transferFromCombo.TabIndex = 3;
            // 
            // transferToCombo
            // 
            this.transferToCombo.FormattingEnabled = true;
            this.transferToCombo.Location = new System.Drawing.Point(373, 164);
            this.transferToCombo.Name = "transferToCombo";
            this.transferToCombo.Size = new System.Drawing.Size(325, 21);
            this.transferToCombo.TabIndex = 4;
            // 
            // transferAmountInput
            // 
            this.transferAmountInput.Location = new System.Drawing.Point(23, 220);
            this.transferAmountInput.Name = "transferAmountInput";
            this.transferAmountInput.Size = new System.Drawing.Size(675, 20);
            this.transferAmountInput.TabIndex = 5;
            // 
            // transferFromLabel
            // 
            this.transferFromLabel.AutoSize = true;
            this.transferFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.transferFromLabel.Location = new System.Drawing.Point(19, 141);
            this.transferFromLabel.Name = "transferFromLabel";
            this.transferFromLabel.Size = new System.Drawing.Size(50, 20);
            this.transferFromLabel.TabIndex = 6;
            this.transferFromLabel.Text = "From:";
            // 
            // transferToLabel
            // 
            this.transferToLabel.AutoSize = true;
            this.transferToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.transferToLabel.Location = new System.Drawing.Point(369, 141);
            this.transferToLabel.Name = "transferToLabel";
            this.transferToLabel.Size = new System.Drawing.Size(31, 20);
            this.transferToLabel.TabIndex = 7;
            this.transferToLabel.Text = "To:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.balanceLabel.Location = new System.Drawing.Point(19, 197);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(69, 20);
            this.balanceLabel.TabIndex = 8;
            this.balanceLabel.Text = "Amount:";
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(23, 264);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(325, 23);
            this.transferBtn.TabIndex = 9;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(373, 264);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(325, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // transfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(720, 305);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.transferToLabel);
            this.Controls.Add(this.transferFromLabel);
            this.Controls.Add(this.transferAmountInput);
            this.Controls.Add(this.transferToCombo);
            this.Controls.Add(this.transferFromCombo);
            this.Controls.Add(this.custNameActual);
            this.Controls.Add(this.custNameLbl);
            this.Name = "transfForm";
            this.Controls.SetChildIndex(this.custNameLbl, 0);
            this.Controls.SetChildIndex(this.custNameActual, 0);
            this.Controls.SetChildIndex(this.transferFromCombo, 0);
            this.Controls.SetChildIndex(this.transferToCombo, 0);
            this.Controls.SetChildIndex(this.transferAmountInput, 0);
            this.Controls.SetChildIndex(this.transferFromLabel, 0);
            this.Controls.SetChildIndex(this.transferToLabel, 0);
            this.Controls.SetChildIndex(this.balanceLabel, 0);
            this.Controls.SetChildIndex(this.transferBtn, 0);
            this.Controls.SetChildIndex(this.closeBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custNameLbl;
        private System.Windows.Forms.Label custNameActual;
        private System.Windows.Forms.ComboBox transferFromCombo;
        private System.Windows.Forms.ComboBox transferToCombo;
        private System.Windows.Forms.TextBox transferAmountInput;
        private System.Windows.Forms.Label transferFromLabel;
        private System.Windows.Forms.Label transferToLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}

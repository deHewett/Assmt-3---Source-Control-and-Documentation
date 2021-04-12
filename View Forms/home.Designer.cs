namespace Assmt_2___GUI_Debugging_and_Testing
{
    partial class home
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
            this.mngCustBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mngCustBtn
            // 
            this.mngCustBtn.Location = new System.Drawing.Point(171, 226);
            this.mngCustBtn.Name = "mngCustBtn";
            this.mngCustBtn.Size = new System.Drawing.Size(288, 108);
            this.mngCustBtn.TabIndex = 1;
            this.mngCustBtn.Text = "Manage Customers";
            this.mngCustBtn.UseVisualStyleBackColor = true;
            this.mngCustBtn.Click += new System.EventHandler(this.mngCustBtn_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(627, 584);
            this.Controls.Add(this.mngCustBtn);
            this.Name = "home";
            this.Controls.SetChildIndex(this.mngCustBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mngCustBtn;
    }
}

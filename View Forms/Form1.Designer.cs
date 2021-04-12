namespace Assmt_2___GUI_Debugging_and_Testing
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
            this.custList = new System.Windows.Forms.ListBox();
            this.addCust = new System.Windows.Forms.Button();
            this.editCust = new System.Windows.Forms.Button();
            this.dltCust = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchCust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custList
            // 
            this.custList.FormattingEnabled = true;
            this.custList.Location = new System.Drawing.Point(19, 93);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(302, 446);
            this.custList.TabIndex = 1;
            // 
            // addCust
            // 
            this.addCust.Location = new System.Drawing.Point(352, 187);
            this.addCust.Name = "addCust";
            this.addCust.Size = new System.Drawing.Size(250, 95);
            this.addCust.TabIndex = 2;
            this.addCust.Text = "Add A Customer";
            this.addCust.UseVisualStyleBackColor = true;
            this.addCust.Click += new System.EventHandler(this.addCust_Click);
            // 
            // editCust
            // 
            this.editCust.Location = new System.Drawing.Point(352, 288);
            this.editCust.Name = "editCust";
            this.editCust.Size = new System.Drawing.Size(250, 95);
            this.editCust.TabIndex = 3;
            this.editCust.Text = "Edit Customer";
            this.editCust.UseVisualStyleBackColor = true;
            this.editCust.Click += new System.EventHandler(this.editCust_Click);
            // 
            // dltCust
            // 
            this.dltCust.Location = new System.Drawing.Point(352, 389);
            this.dltCust.Name = "dltCust";
            this.dltCust.Size = new System.Drawing.Size(250, 95);
            this.dltCust.TabIndex = 4;
            this.dltCust.Text = "Delete Customer";
            this.dltCust.UseVisualStyleBackColor = true;
            this.dltCust.Click += new System.EventHandler(this.dltCust_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(352, 490);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(250, 49);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(352, 93);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(250, 20);
            this.searchBox.TabIndex = 6;
            // 
            // searchCust
            // 
            this.searchCust.Location = new System.Drawing.Point(352, 120);
            this.searchCust.Name = "searchCust";
            this.searchCust.Size = new System.Drawing.Size(250, 39);
            this.searchCust.TabIndex = 7;
            this.searchCust.Text = "Search";
            this.searchCust.UseVisualStyleBackColor = true;
            this.searchCust.Click += new System.EventHandler(this.searchCust_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(627, 584);
            this.Controls.Add(this.searchCust);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dltCust);
            this.Controls.Add(this.editCust);
            this.Controls.Add(this.addCust);
            this.Controls.Add(this.custList);
            this.Name = "Form1";
            this.Controls.SetChildIndex(this.custList, 0);
            this.Controls.SetChildIndex(this.addCust, 0);
            this.Controls.SetChildIndex(this.editCust, 0);
            this.Controls.SetChildIndex(this.dltCust, 0);
            this.Controls.SetChildIndex(this.exit, 0);
            this.Controls.SetChildIndex(this.searchBox, 0);
            this.Controls.SetChildIndex(this.searchCust, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox custList;
        private System.Windows.Forms.Button addCust;
        private System.Windows.Forms.Button editCust;
        private System.Windows.Forms.Button dltCust;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchCust;
    }
}

namespace ACS_aupchurchM1A
{
    partial class frmCustomers
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
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.tbxContactName = new System.Windows.Forms.TextBox();
            this.tbxContactTitle = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(37, 33);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(88, 15);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(37, 72);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(109, 15);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(37, 113);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(100, 15);
            this.lblContactName.TabIndex = 2;
            this.lblContactName.Text = "Contact Name";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(37, 155);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(91, 15);
            this.lblContactTitle.TabIndex = 3;
            this.lblContactTitle.Text = "Contact Title";
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.BackColor = System.Drawing.Color.Red;
            this.tbxCustomerID.Location = new System.Drawing.Point(169, 25);
            this.tbxCustomerID.Multiline = true;
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.ReadOnly = true;
            this.tbxCustomerID.Size = new System.Drawing.Size(239, 20);
            this.tbxCustomerID.TabIndex = 4;
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.BackColor = System.Drawing.Color.Red;
            this.tbxCompanyName.Location = new System.Drawing.Point(169, 64);
            this.tbxCompanyName.Multiline = true;
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.ReadOnly = true;
            this.tbxCompanyName.Size = new System.Drawing.Size(239, 20);
            this.tbxCompanyName.TabIndex = 5;
            // 
            // tbxContactName
            // 
            this.tbxContactName.BackColor = System.Drawing.Color.Red;
            this.tbxContactName.Location = new System.Drawing.Point(169, 110);
            this.tbxContactName.Multiline = true;
            this.tbxContactName.Name = "tbxContactName";
            this.tbxContactName.ReadOnly = true;
            this.tbxContactName.Size = new System.Drawing.Size(239, 20);
            this.tbxContactName.TabIndex = 6;
            // 
            // tbxContactTitle
            // 
            this.tbxContactTitle.BackColor = System.Drawing.Color.Red;
            this.tbxContactTitle.Location = new System.Drawing.Point(169, 152);
            this.tbxContactTitle.Multiline = true;
            this.tbxContactTitle.Name = "tbxContactTitle";
            this.tbxContactTitle.ReadOnly = true;
            this.tbxContactTitle.Size = new System.Drawing.Size(239, 20);
            this.tbxContactTitle.TabIndex = 7;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(10, 228);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(98, 228);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(186, 228);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(274, 228);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = "&Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(362, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 263);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.tbxContactTitle);
            this.Controls.Add(this.tbxContactName);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.tbxCustomerID);
            this.Controls.Add(this.lblContactTitle);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCustomerID);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Table";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.TextBox tbxContactName;
        private System.Windows.Forms.TextBox tbxContactTitle;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnExit;
    }
}


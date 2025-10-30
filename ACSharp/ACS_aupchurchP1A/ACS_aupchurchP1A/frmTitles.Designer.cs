namespace ACS_aupchurchP1A
{
    partial class frmTitles
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYearPub = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPusherID = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxYearPub = new System.Windows.Forms.TextBox();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.tbxPubID = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(36, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(28, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Text";
            // 
            // lblYearPub
            // 
            this.lblYearPub.AutoSize = true;
            this.lblYearPub.Location = new System.Drawing.Point(36, 111);
            this.lblYearPub.Name = "lblYearPub";
            this.lblYearPub.Size = new System.Drawing.Size(78, 13);
            this.lblYearPub.TabIndex = 1;
            this.lblYearPub.Text = "Year Published";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(36, 155);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN";
            // 
            // lblPusherID
            // 
            this.lblPusherID.AutoSize = true;
            this.lblPusherID.Location = new System.Drawing.Point(36, 202);
            this.lblPusherID.Name = "lblPusherID";
            this.lblPusherID.Size = new System.Drawing.Size(64, 13);
            this.lblPusherID.TabIndex = 3;
            this.lblPusherID.Text = "Publisher ID";
            // 
            // tbxTitle
            // 
            this.tbxTitle.BackColor = System.Drawing.Color.White;
            this.tbxTitle.Location = new System.Drawing.Point(126, 63);
            this.tbxTitle.Multiline = true;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.ReadOnly = true;
            this.tbxTitle.Size = new System.Drawing.Size(184, 20);
            this.tbxTitle.TabIndex = 4;
            // 
            // tbxYearPub
            // 
            this.tbxYearPub.BackColor = System.Drawing.Color.White;
            this.tbxYearPub.Location = new System.Drawing.Point(126, 104);
            this.tbxYearPub.Multiline = true;
            this.tbxYearPub.Name = "tbxYearPub";
            this.tbxYearPub.ReadOnly = true;
            this.tbxYearPub.Size = new System.Drawing.Size(184, 20);
            this.tbxYearPub.TabIndex = 5;
            // 
            // tbxISBN
            // 
            this.tbxISBN.BackColor = System.Drawing.Color.White;
            this.tbxISBN.Location = new System.Drawing.Point(126, 152);
            this.tbxISBN.Multiline = true;
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.ReadOnly = true;
            this.tbxISBN.Size = new System.Drawing.Size(184, 20);
            this.tbxISBN.TabIndex = 6;
            // 
            // tbxPubID
            // 
            this.tbxPubID.BackColor = System.Drawing.Color.White;
            this.tbxPubID.Location = new System.Drawing.Point(126, 195);
            this.tbxPubID.Multiline = true;
            this.tbxPubID.Name = "tbxPubID";
            this.tbxPubID.ReadOnly = true;
            this.tbxPubID.Size = new System.Drawing.Size(184, 20);
            this.tbxPubID.TabIndex = 7;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(25, 255);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(112, 255);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(199, 255);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(286, 255);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = "&Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // frmTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 316);
            this.ControlBox = false;
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.tbxPubID);
            this.Controls.Add(this.tbxISBN);
            this.Controls.Add(this.tbxYearPub);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblPusherID);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblYearPub);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTitles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titles Database";
            this.Load += new System.EventHandler(this.frmTitles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYearPub;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPusherID;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxYearPub;
        private System.Windows.Forms.TextBox tbxISBN;
        private System.Windows.Forms.TextBox tbxPubID;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}


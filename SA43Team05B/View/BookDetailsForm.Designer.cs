namespace SA43Team05B.View
{
    partial class BookDetailsForm
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
            this.LblBookTitle = new System.Windows.Forms.Label();
            this.TxtbBookTitle = new System.Windows.Forms.TextBox();
            this.TxtbBookID = new System.Windows.Forms.TextBox();
            this.BookDetailsTitleLbl = new System.Windows.Forms.Label();
            this.LblBookID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblBookTitle
            // 
            this.LblBookTitle.AutoSize = true;
            this.LblBookTitle.Location = new System.Drawing.Point(424, 235);
            this.LblBookTitle.Name = "LblBookTitle";
            this.LblBookTitle.Size = new System.Drawing.Size(38, 20);
            this.LblBookTitle.TabIndex = 8;
            this.LblBookTitle.Text = "Title";
            // 
            // TxtbBookTitle
            // 
            this.TxtbBookTitle.Location = new System.Drawing.Point(479, 235);
            this.TxtbBookTitle.Name = "TxtbBookTitle";
            this.TxtbBookTitle.Size = new System.Drawing.Size(104, 26);
            this.TxtbBookTitle.TabIndex = 6;
            // 
            // TxtbBookID
            // 
            this.TxtbBookID.Location = new System.Drawing.Point(479, 190);
            this.TxtbBookID.Name = "TxtbBookID";
            this.TxtbBookID.Size = new System.Drawing.Size(104, 26);
            this.TxtbBookID.TabIndex = 7;
            // 
            // BookDetailsTitleLbl
            // 
            this.BookDetailsTitleLbl.AutoSize = true;
            this.BookDetailsTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDetailsTitleLbl.Location = new System.Drawing.Point(24, 55);
            this.BookDetailsTitleLbl.Name = "BookDetailsTitleLbl";
            this.BookDetailsTitleLbl.Size = new System.Drawing.Size(143, 29);
            this.BookDetailsTitleLbl.TabIndex = 5;
            this.BookDetailsTitleLbl.Text = "BookDetails";
            // 
            // LblBookID
            // 
            this.LblBookID.AutoSize = true;
            this.LblBookID.Location = new System.Drawing.Point(424, 190);
            this.LblBookID.Name = "LblBookID";
            this.LblBookID.Size = new System.Drawing.Size(26, 20);
            this.LblBookID.TabIndex = 4;
            this.LblBookID.Text = "ID";
            // 
            // BookDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1066, 576);
            this.Controls.Add(this.LblBookTitle);
            this.Controls.Add(this.TxtbBookTitle);
            this.Controls.Add(this.TxtbBookID);
            this.Controls.Add(this.BookDetailsTitleLbl);
            this.Controls.Add(this.LblBookID);
            this.Name = "BookDetailsForm";
            this.Controls.SetChildIndex(this.LblBookID, 0);
            this.Controls.SetChildIndex(this.BookDetailsTitleLbl, 0);
            this.Controls.SetChildIndex(this.TxtbBookID, 0);
            this.Controls.SetChildIndex(this.TxtbBookTitle, 0);
            this.Controls.SetChildIndex(this.LblBookTitle, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBookTitle;
        private System.Windows.Forms.TextBox TxtbBookTitle;
        private System.Windows.Forms.TextBox TxtbBookID;
        private System.Windows.Forms.Label BookDetailsTitleLbl;
        private System.Windows.Forms.Label LblBookID;
    }
}

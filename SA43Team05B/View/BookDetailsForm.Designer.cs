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
            this.LblID = new System.Windows.Forms.Label();
            this.BookDetailsTitleLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(105, 77);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(31, 25);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID";
            // 
            // BookDetailsTitleLbl
            // 
            this.BookDetailsTitleLbl.AutoSize = true;
            this.BookDetailsTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDetailsTitleLbl.Location = new System.Drawing.Point(36, 26);
            this.BookDetailsTitleLbl.Name = "BookDetailsTitleLbl";
            this.BookDetailsTitleLbl.Size = new System.Drawing.Size(143, 29);
            this.BookDetailsTitleLbl.TabIndex = 1;
            this.BookDetailsTitleLbl.Text = "BookDetails";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 30);
            this.textBox1.TabIndex = 2;
            // 
            // BookDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 381);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BookDetailsTitleLbl);
            this.Controls.Add(this.LblID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookDetailsForm";
            this.Text = "LibrarySystemManage";
            this.Load += new System.EventHandler(this.BookDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label BookDetailsTitleLbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}
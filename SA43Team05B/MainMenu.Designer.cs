namespace SA43Team05B
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.membersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.createBooksToolStripMenuItem,
            this.borrowBooksToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // createBooksToolStripMenuItem
            // 
            this.createBooksToolStripMenuItem.Name = "createBooksToolStripMenuItem";
            this.createBooksToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.createBooksToolStripMenuItem.Text = "Create ";
            // 
            // borrowBooksToolStripMenuItem
            // 
            this.borrowBooksToolStripMenuItem.Name = "borrowBooksToolStripMenuItem";
            this.borrowBooksToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.borrowBooksToolStripMenuItem.Text = "Borrow";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(154, 30);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.createToolStripMenuItem});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.membersToolStripMenuItem.Text = "Member";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(149, 30);
            this.searchToolStripMenuItem1.Text = "Search";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 576);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Library Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
    }
}



namespace F21SC_WebBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pagename = new System.Windows.Forms.ToolStripTextBox();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.home = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.urltextBox = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.favourite = new System.Windows.Forms.Button();
            this.page = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.page, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 486);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagename,
            this.Settings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pagename
            // 
            this.pagename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.pagename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pagename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.pagename.Name = "pagename";
            this.pagename.Size = new System.Drawing.Size(500, 36);
            // 
            // Settings
            // 
            this.Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favouritesToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.modifyHomepageToolStripMenuItem});
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(10, 5, 5, 0);
            this.Settings.Size = new System.Drawing.Size(90, 36);
            this.Settings.Text = "Settings";
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.favouritesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.favouritesToolStripMenuItem.Text = "Favourites";
            this.favouritesToolStripMenuItem.Click += new System.EventHandler(this.favouritesToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.historyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // modifyHomepageToolStripMenuItem
            // 
            this.modifyHomepageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.modifyHomepageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.modifyHomepageToolStripMenuItem.Name = "modifyHomepageToolStripMenuItem";
            this.modifyHomepageToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.modifyHomepageToolStripMenuItem.Text = "Modify Homepage";
            this.modifyHomepageToolStripMenuItem.Click += new System.EventHandler(this.modifyHomepageToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Controls.Add(this.home, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.back, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.forward, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.refresh, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.urltextBox, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.go, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.favourite, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(890, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.home.Location = new System.Drawing.Point(3, 3);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(39, 28);
            this.home.TabIndex = 0;
            this.home.Text = "🏠";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.back.Location = new System.Drawing.Point(48, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(39, 28);
            this.back.TabIndex = 1;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.forward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.forward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.forward.Location = new System.Drawing.Point(93, 3);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(39, 28);
            this.forward.TabIndex = 2;
            this.forward.Text = ">";
            this.forward.UseVisualStyleBackColor = false;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.refresh.Location = new System.Drawing.Point(138, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(39, 28);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "⟳";
            this.refresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // urltextBox
            // 
            this.urltextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.urltextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urltextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.urltextBox.Location = new System.Drawing.Point(183, 3);
            this.urltextBox.Name = "urltextBox";
            this.urltextBox.Size = new System.Drawing.Size(614, 22);
            this.urltextBox.TabIndex = 4;
            this.urltextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urltextBox_KeyPress);
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.go.Dock = System.Windows.Forms.DockStyle.Fill;
            this.go.Location = new System.Drawing.Point(803, 3);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(39, 28);
            this.go.TabIndex = 5;
            this.go.Text = "🔍";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // favourite
            // 
            this.favourite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(170)))));
            this.favourite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favourite.Location = new System.Drawing.Point(848, 3);
            this.favourite.Name = "favourite";
            this.favourite.Size = new System.Drawing.Size(39, 28);
            this.favourite.TabIndex = 6;
            this.favourite.Text = "❤️";
            this.favourite.UseVisualStyleBackColor = false;
            this.favourite.Click += new System.EventHandler(this.favourite_Click);
            // 
            // page
            // 
            this.page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page.Location = new System.Drawing.Point(3, 83);
            this.page.Multiline = true;
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(890, 400);
            this.page.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox pagename;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyHomepageToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button favourite;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox page;
        public System.Windows.Forms.TextBox urltextBox;
    }
}


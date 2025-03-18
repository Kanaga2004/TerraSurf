
namespace F21SC_WebBrowser
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.favouriteslistBox = new System.Windows.Forms.ListBox();
            this.Modify = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // favouriteslistBox
            // 
            this.favouriteslistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.favouriteslistBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.favouriteslistBox.FormattingEnabled = true;
            this.favouriteslistBox.ItemHeight = 16;
            this.favouriteslistBox.Location = new System.Drawing.Point(12, 48);
            this.favouriteslistBox.Name = "favouriteslistBox";
            this.favouriteslistBox.Size = new System.Drawing.Size(190, 132);
            this.favouriteslistBox.TabIndex = 0;
            this.favouriteslistBox.SelectedIndexChanged += new System.EventHandler(this.favouriteslistBox_SelectedIndexChanged);
            this.favouriteslistBox.DoubleClick += new System.EventHandler(this.favouriteslistBox_DoubleClick);
            // 
            // Modify
            // 
            this.Modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.Modify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.Modify.Location = new System.Drawing.Point(12, 12);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(92, 30);
            this.Modify.TabIndex = 1;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = false;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.Delete.Location = new System.Drawing.Point(110, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 30);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(216, 192);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.favouriteslistBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox favouriteslistBox;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Delete;
    }
}
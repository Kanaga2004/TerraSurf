
namespace F21SC_WebBrowser
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.historylistBox = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historylistBox
            // 
            this.historylistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.historylistBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.historylistBox.FormattingEnabled = true;
            this.historylistBox.ItemHeight = 16;
            this.historylistBox.Location = new System.Drawing.Point(25, 50);
            this.historylistBox.Name = "historylistBox";
            this.historylistBox.Size = new System.Drawing.Size(176, 148);
            this.historylistBox.TabIndex = 0;
            this.historylistBox.SelectedIndexChanged += new System.EventHandler(this.historylistBox_SelectedIndexChanged);
            this.historylistBox.DoubleClick += new System.EventHandler(this.historylistBox_DoubleClick);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.Delete.Location = new System.Drawing.Point(25, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 32);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.DeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.DeleteAll.Location = new System.Drawing.Point(106, 12);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(95, 32);
            this.DeleteAll.TabIndex = 2;
            this.DeleteAll.Text = "Delete All";
            this.DeleteAll.UseVisualStyleBackColor = false;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(227, 220);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.historylistBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox historylistBox;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button DeleteAll;
    }
}
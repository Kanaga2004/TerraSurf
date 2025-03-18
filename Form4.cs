using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F21SC_WebBrowser
{
    public partial class Form4 : Form
    { 
        private string homeUrl; // string that holds the url of the home page
        public void SetHomeUrl(string name) //to set the private string homeURL
        {
            homeUrl = name;
        }

        public string GetHomeUrl() //to get the private string homeURL
        {
            return homeUrl;
        }
        public Form4()
        {
            InitializeComponent();
            this.Text = "Edit Home";
        }

        private void done_Click(object sender, EventArgs e) // event handler for submit
        {
            string url = homeTB.Text; // get the new url from the TextBox
            SetHomeUrl(url); // set HomeUrl to the new url
            this.Close(); // close the form
        }

        private void homeTB_KeyPress(object sender, KeyPressEventArgs e) // event handler for shortcut key
        {
            if (e.KeyChar == (char)Keys.Enter)  // on pressing enter
            {
                string url = homeTB.Text; // get the new url from the TextBox
                SetHomeUrl(url); // set HomeUrl to the new url
                this.Close(); // close the form
            }
        }
    }
}

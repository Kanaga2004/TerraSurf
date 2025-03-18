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
    public partial class Form2 : Form
    {
        private string favoriteName; // string that holds the name of the favourite
        public Form2()
        {
            InitializeComponent();
            this.Text = "Name Prompt";
        }
        public void SetFavoriteName(string name) // to set the private string favourite name
        {
            favoriteName = name;
        }
        public string GetFavoriteName() // to get the private string favourite name
        {
            return favoriteName;
        } 

        private void Submit_Click(object sender, EventArgs e) // event handler for submit
        {
            string name = nameTB.Text; // get the name from the TextBox
            SetFavoriteName(name); // set favourite name to the name
            this.Close(); // close the form 
        }

        private void nameTB_KeyPress(object sender, KeyPressEventArgs e) // event handler for shortcut key
        {
            if (e.KeyChar == (char)Keys.Enter) {  // on pressing enter
                string name = nameTB.Text; // get the name from the TextBox
                SetFavoriteName(name); // set favourite name to the name
                this.Close(); // close the form
            }
        }
    }
}

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
    public partial class Form5 : Form
    {
        private HController hcontrol; // create a hController object
        private int selectedIndex = -1; // set the current index to -1

        public Form5(HController control)
        {
            InitializeComponent();
            hcontrol = control;  // get the HController from form 1 with the history list
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            historylistBox.Items.Clear(); // delete all history displayed
            foreach (History h in hcontrol.GetHistories()) //traverse through history list
            {
                historylistBox.Items.Add(h.GetURL()); // display each history url
            }
        }


        private void DeleteAll_Click(object sender, EventArgs e) //event handler for deleting all
        {
            hcontrol.DeleteAll(); //  use deleteall funtion in the HController
            UpdateListBox(); // display changes
        }
        private void historylistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = historylistBox.SelectedIndex; //get the index of selected url
        }

        private void Delete_Click(object sender, EventArgs e)  //event handler for deleting
        {
            if (selectedIndex >= 0) // check if an URL is selected
            {
                History url = hcontrol.GetHistories()[selectedIndex]; // get selected URL
                hcontrol.Delete(url); // using delete from HController delete the selected URL
                UpdateListBox(); // display changes
            }
        }

        private void historylistBox_DoubleClick(object sender, EventArgs e) //event handler for double clicking on an URL
        {
            if (selectedIndex >= 0) // check if an URL is selected 
            {
                Form1 form1 = this.Owner as Form1;
                if (form1 != null)
                {
                    string url = historylistBox.SelectedItem.ToString(); // get the url selected
                    form1.RenderURL(url);  // using the RenderURL in form1 to render the selected url
                }
            }
        }
    }
}

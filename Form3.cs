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
    public partial class Form3 : Form
    {
        private FController fcontrol; // create a FController object
        private int currentindex = -1; // set the current index to -1
        public Form3(FController control)
        {
            InitializeComponent();
            this.Text = "Favourites";
            fcontrol = control; // get the FController from form 1 with the list of favourites
            UpdateListBox(); 
        }
        private void UpdateListBox() 
        {
            favouriteslistBox.Items.Clear(); // delete all favourites displayed
            foreach (Favourites favorite in fcontrol.GetFavourites()) //traverse through favourites list
            {
                favouriteslistBox.Items.Add($"{favorite.Name}: {favorite.URL}"); // display each favourite url and their name
            }
        }

        private void Modify_Click(object sender, EventArgs e) //event handler for modify
        {
            if (currentindex >= 0) // check if an URL is selected
            {
                Favourites selected = fcontrol.GetFavourites()[currentindex]; // get the Favourite item from the list
                string newName; // initialize a string to store the new name
                using (Form2 form2 = new Form2())
                {
                    form2.ShowDialog(); //prompt form 2
                    newName = form2.GetFavoriteName(); // get the favourite name from form 2
                }
                fcontrol.RenameFavourite(selected.URL, newName);// use rename funtion in the FController class
                UpdateListBox(); // display the changes
            }

        }

        private void Delete_Click(object sender, EventArgs e) //event handler for deleting
        {
            if (currentindex >= 0) // check if an URL is selected
            {
                Favourites selected = fcontrol.GetFavourites()[currentindex]; // get the Favourite item from the list
                fcontrol.DeleteFavourite(selected.URL); // use delete funtion in the FController class
                currentindex = -1; // decrease the index
                UpdateListBox(); // display the changes
            }
        }

        private void favouriteslistBox_SelectedIndexChanged(object sender, EventArgs e) //event handler for selecting an url
        {
            currentindex = favouriteslistBox.SelectedIndex; // get the index of the selected URL
        }

        private void favouriteslistBox_DoubleClick(object sender, EventArgs e) //event handler for double clicking on an URL
        {
            if (currentindex >= 0) // check if an URL is selected 
            {
                Form1 form1 = this.Owner as Form1;
                if (form1 != null)
                {
                    string url = fcontrol.GetFavourites()[currentindex].URL; // get the url selected
                    form1.RenderURL(url); // using the RenderURL in form1 to render the selected url 
                }
            }
        }
    }
}

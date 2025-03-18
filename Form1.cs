using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace F21SC_WebBrowser
{
    public partial class Form1 : Form
    {
        private String homeURL = "www.hw.ac.uk"; //string that holds home page url
        private int index = -1; // int index that stores the current index
        private FController favoritesControl = new FController(); // to manage favourites
        private HController historiesControl = new HController(); // to manage history

        public Form1()
        {
            InitializeComponent();
            RenderURL("www.hw.ac.uk"); // initialize the browser as hw site on startup
            this.Text = "TerraSurf"; // name of the web browser
        }

        private void home_Click(object sender, EventArgs e) // event handler for home button
        {
            RenderURL(homeURL); //render home url
        }

        private void back_Click(object sender, EventArgs e) // event handler for back
        {
            if (index > 0) // if there is a previous page 
            {
                index--; // get the previous index
                string url = historiesControl.GetHistories()[index].GetURL(); // get the previous url from the history list
                RenderURL(url); 
            }
        }

        private void forward_Click(object sender, EventArgs e) // event handler for forward
        {
            if (index < historiesControl.GetHistories().Count - 1) // if there is a next page
            {
                index++; // get the next index
                string url = historiesControl.GetHistories()[index].GetURL(); // get the next url from the history list
                RenderURL(url);
            }
        }

        private void refresh_Click(object sender, EventArgs e) // event handler for refresh
        {
            if (index >= 0 && index < historiesControl.GetHistories().Count) // if a url has been searched for
            {
                string url = historiesControl.GetHistories()[index].GetURL(); // get the current url 
                RenderURL(url);
            }
        }

 
        private void go_Click(object sender, EventArgs e) // event handler for search
        {
            RenderURL(urltextBox.Text); // render the url in the text box
        }

        private void favourite_Click(object sender, EventArgs e) // event handler to add favourite
        {
            string currentURL = urltextBox.Text; // get the url from text box
            string favoriteName; // string favourite name
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog(); // prompt form 2
                favoriteName=form2.GetFavoriteName(); // get the favourite name from form 2
            }
            favoritesControl.AddFavourite(favoriteName, currentURL); //Add the name and url into favourites list
        }

        private void favouritesToolStripMenuItem_Click(object sender, EventArgs e) //event handler to view all favourites
        {
            using (Form3 form3 = new Form3(favoritesControl)) 
            {
                form3.Owner = this; 
                form3.ShowDialog(); // prompt form 3
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e) // event handler to veiw history
        {
            using (Form5 form5 = new Form5(historiesControl)) 
            {
                form5.Owner = this;
                form5.ShowDialog(); //prompt form 5 
            }
        }

        private void modifyHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newhomeURL; //intialize a string
            using (Form4 form4= new Form4())
            {
                form4.ShowDialog(); // prompt form 4
                newhomeURL = form4.GetHomeUrl(); //get the new home url from form 4
            }
            homeURL = newhomeURL; // set the homeURL as new url
        }

        public void RenderURL(string url) // method to render url
        {
            try
            {
                if (!url.StartsWith("https") && !url.StartsWith("http")) // checks if the url has http or https
                {
                    url = "https://" + url; //adds https:// if it doesnt have https
                }
                Uri uri; // creates a Uri object
                urltextBox.Text = url; // display the url in the search bar
                if (Uri.TryCreate(url, UriKind.Absolute, out uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps)) // try creating a Uri out of url and save it as uri and check if the uri has http or https
                {
                    if (index == -1 || (historiesControl.GetHistories().Count > 0 && historiesControl.GetHistories()[index].GetURL() != url)) // if the url add is first url or the url added doesnt already exist at the cuurent index
                    {
                        index++; // increment the index
                        historiesControl.AddHistory(url); // add url into history
                    }

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri); // create a Htpp request

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) // get the Http response
                    {
                        pagename.Text ="Status "+ response.StatusCode.ToString(); // display the stauts code
                        if (response.StatusCode == HttpStatusCode.OK) //check if the status is ok
                        {
                            using (Stream stream = response.GetResponseStream()) //get the response stream
                            {
                                using (StreamReader reader = new StreamReader(stream)) // read the response stream
                                {

                                    string html = reader.ReadToEnd(); // get the HTML 
                                    page.Text = html; // Display the html content
                                    int startindex = html.IndexOf("<title>")+"<title>".Length; //get the index where the title tag ends
                                    int endindex = html.IndexOf("</title>")- startindex; //get the index where the title closing tag starts
                                    string titleText = html.Substring(startindex, endindex); // get the title using substring
                                    pagename.Text = titleText + ": Status " + response.StatusCode.ToString(); // Display the tittle along with the status code
                                }
                            }
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse httpResponse)// catch response exception
                {
                    pagename.Text = "Status " + httpResponse.StatusCode.ToString();// display the status code
                    if (httpResponse.StatusDescription.CompareTo("Not Found") == 0) // if status code is Not found
                    {
                        MessageBox.Show("404 Not Found"); 
                    }
                    else if (httpResponse.StatusDescription.CompareTo("Forbidden") == 0) // if status code is Forbidden
                    {
                        MessageBox.Show("403 Forbidden");
                    }
                    else if (httpResponse.StatusDescription.CompareTo("Bad Request") == 0) // if status code is Bad Request
                    {
                        MessageBox.Show("400 Bad Request");
                    }
                }
                else
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }

        private void urltextBox_KeyPress(object sender, KeyPressEventArgs e) //event handler for shortcut keys
        {
            if (e.KeyChar == (char)Keys.Enter)//if the enter key is pressed
            {
                RenderURL(urltextBox.Text); // render the url in the text box
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F21SC_WebBrowser
{
    public class History // History class
    {
        private string URL; // 1 attribute that stores the url as a string
        public History(string url) // constructor
        {
            this.URL = url;
        }
        public string GetURL() // get the URL
        {
            return this.URL;
        }
    }
    public class HController // Class to manage history
    {
        private List<History> h = new List<History>(); // List of type History
        public List<History> GetHistories() // return the history list
        {
            return h;
        }
        public void AddHistory(string url) // add a new url into the list
        {
            h.Add(new History(url));
        }
        public void Delete(History url)
        {
            h.Remove(url); // remove the url from the list
        }
        public void DeleteAll()
        {
            h.Clear(); // clear the list
        }
    }
}

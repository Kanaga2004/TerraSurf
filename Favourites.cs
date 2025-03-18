using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F21SC_WebBrowser
{
    public class Favourites // Favourites Class
    {
        public string Name; // name of the favourite
        public string URL; // url of the favourite

        public Favourites(string name, string url) // constructor
        {
            this.Name = name;
            this.URL = url;
        }
    }

    public class FController // Class to manage favourites
    {
        private List<Favourites> f = new List<Favourites>(); // list of type favourites
        public List<Favourites> GetFavourites() // returns the list
        {
            return f;
        }
        public void AddFavourite(string name, string url)
        {
            f.Add(new Favourites(name, url)); // add the new favourites to the list
        }
        public void DeleteFavourite(string url)
        {
            for (int i = 0; i < f.Count; i++) // traverse the list
            {
                if (url.Equals(f[i].URL)) // check if the url is at the current index
                {
                    f.Remove(f[i]); // remove the favourites from the list
                }
            }
        }
        public void RenameFavourite(string url, string newName)
        {
            for (int i = 0; i < f.Count; i++) // traverse the list
            {
                if (url.Equals(f[i].URL)) // check if the url is at the current index
                {
                    f[i].Name = newName; // set the new name as the favourites 
                }
            }
        }
    }
}


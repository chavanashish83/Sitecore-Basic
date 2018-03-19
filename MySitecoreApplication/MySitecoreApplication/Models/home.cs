using MySitecoreApplication.UserDefined.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySitecoreApplication.Models
{
    public class Home
    {
        public Home()
        {
            HomePageEntity = new HomePageEntity();
        }
        public HomePageEntity HomePageEntity { get; set; }
    }
}
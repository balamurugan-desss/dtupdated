using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TransCanada.Models
{
    public class allcontact
    {

        public string curl { get; set; }
        public string lurl { get; set; }
        [Display(Name = "Location")]
        public string location { get; set; }
        public string Type { get; set; }
        [Display(Name ="First Name")]
        public string fname { get; set; }
        [Display(Name = "Last Name")]
        public string lname { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Mobile")]
        public string phone { get; set; }
        [Display(Name = "Office Phone")]
        public string offphone { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        public string mainurl { get; set; }
    }
}
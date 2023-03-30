using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Training1.Models
{
    public class Flower
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSelected { get; set; }
    }
}
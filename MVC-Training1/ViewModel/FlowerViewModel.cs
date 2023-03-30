using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Training1.Models;

namespace MVC_Training1.ViewModel
{
    public class FlowerViewModel
    {
        public List<Flower> Flowers { get; set; }
        public string SelectedFlower { get; set; }
    }
}
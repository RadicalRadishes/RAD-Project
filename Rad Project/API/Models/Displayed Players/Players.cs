using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models.Displayed_Players
{
    public class Players
    {
        public int ID { get; set; }
        public string GamerTag { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string ImageURL { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarThunderShellGuide.Models
{
    public class TankViewModel
    {
        public int tankId { get; set; }
        public string name { get; set; }
        public string nation { get; set; }
        public string afvClass { get; set; }
        public double battleRating { get; set; }
        public List<ShellViewModel> shells { get; set; }
        public string imageUrl { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarThunderShellGuide.Models
{
    public class JsonTreeModel
    {
        public string text { get; set; }
        public JsonTreeStateModel state { get; set; }
        public int id { get; set; }
        public List<JsonTreeModel> children { get; set; }
        public string icon { get; set; }
    }

    public class JsonTreeStateModel
    {
        public bool opened { get; set; }
    }
}
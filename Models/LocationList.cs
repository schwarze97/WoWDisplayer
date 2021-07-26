using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WoWDisplayer.Models
{
    public abstract class LocationList
    {
        public IEnumerable<Location> list { get; set; }
        public DropDownList dropDown { get; set; }
        public bool isFilled { get; set; }

        public abstract void LoadList();
    }
}

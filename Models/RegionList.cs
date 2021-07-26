using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WoWDisplayer.Models
{
    public class RegionList : LocationList
    {
        public IEnumerable<Region> list { get; set; }
        public DropDownList dropDown { get; set; }
        public bool isFilled { get; set; }


        public RegionList()
        { 
        }

        public RegionList(IEnumerable<Region> list, DropDownList dropDown, bool isFilled)
        {
            this.list = list;
            this.dropDown = dropDown;
            this.isFilled = isFilled;
        }


        public override void LoadList()
        {
            if (!this.isFilled)
            {
                foreach (Region region in this.list)
                {
                    this.dropDown.Items.Add(region.Name);
                }

                this.isFilled = true;
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WoWDisplayer.Models
{
    public class Region : Location
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int ID { set; get; }

        public Region()
        {
        }

        public Region(string Code)
        {
            this.Code = Code;
        }

        public Region(string Name, string Code)
        {
            this.Name = Name;
            this.Code = Code;
        }

    }
}
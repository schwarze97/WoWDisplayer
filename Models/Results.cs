using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WoWDisplayer.Models
{
    public class Results
    {
        [JsonProperty("data")]
        public Data data { get; set; }

        public Results()
        { 
        }

        public Results(Data data)
        {
            this.data = data;
        }
    }
}
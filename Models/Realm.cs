using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WoWDisplayer.Models
{
    public class Realm : Location
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        
        [JsonProperty("slug")]
        public string Slug { get; set; }

        public Realm()
        {
        }

        public Realm(string Slug, int ID)
        {
            this.Slug = Slug;
            this.ID = ID;
        }
    }
}
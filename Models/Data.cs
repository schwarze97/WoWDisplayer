using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WoWDisplayer.Models
{
    public class Data
    {
        [JsonProperty("realms")]
        public List<Realm> realms { get; set; }

        public Data()
        {
        }

        public Data(List<Realm> realms)
        {
            this.realms = realms;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;

namespace WoWDisplayer.Models
{
    public class ClientAuthorization
    {
        [JsonProperty("access_token")]
        public string Token { get; set; }

        [JsonProperty("token_type")]
        public string Type { get; set; }

        [JsonProperty("expires_in")]
        public int Expire { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        public ClientAuthorization()
        {

        }

        public ClientAuthorization(string Token, string Type, int Expire, string Scope)
        {
            this.Token = Token;
            this.Type = Type;
            this.Expire = Expire;
            this.Scope = Scope;
        }



    }
}
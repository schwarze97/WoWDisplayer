using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Net;
using Newtonsoft.Json;

namespace WoWDisplayer.Models
{
    public class RealmList : LocationList
    {
        public IEnumerable<Realm> list { get; set; }
        public DropDownList dropDown { get; set; }
        public bool isFilled { get; set; }
        public string selectedRegion { get; set; }
        public string Token { get; set; }


        public RealmList()
        {
        }

        public RealmList(DropDownList dropDown, bool isFilled, string Token)
        {
            this.dropDown = dropDown;
            this.isFilled = isFilled;
            this.Token = Token;
        }

        public RealmList(IEnumerable<Realm> list, DropDownList dropDown, bool isFilled, string selectedRegion, string Token)
        {
            this.list = list;
            this.dropDown = dropDown;
            this.isFilled = isFilled;
            this.selectedRegion = selectedRegion;
            this.Token = Token;
        }


        public override void LoadList()
        {
            string apiURL = "";

            if (selectedRegion == "cn")
            {
                apiURL = $"https://gateaway.battlenet.com.{selectedRegion}/data/wow/search/connected-realm?namespace=dynamic-{selectedRegion}&locale=en_GB&access_token={Token}";

            }
            else
            {
                apiURL = $"https://{selectedRegion}.api.blizzard.com/data/wow/search/connected-realm?namespace=dynamic-{selectedRegion}&locale=en_GB&access_token={Token}";
            }

            var rootRealm = new RootRealm();

            using (WebClient client = new WebClient())
            {
                var realmInfo = client.DownloadString(apiURL);
                rootRealm = JsonConvert.DeserializeObject<RootRealm>(realmInfo);
            }

             
            List<Realm> realmList = new List<Realm>();

            foreach (Results result in rootRealm.results)
            {
                foreach (Realm realm in result.data.realms)
                {
                    realmList.Add(realm);
                }
            }

            this.list = realmList;
            list = list.OrderBy(s => s.Slug);

            if (!this.isFilled)
            {
                foreach (Realm realm in this.list)
                {
                    this.dropDown.Items.Add(realm.Slug);
                }

                this.isFilled = true;
            }

        }
    }
    
}
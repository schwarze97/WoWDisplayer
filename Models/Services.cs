using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Net;


namespace WoWDisplayer.Models
{
    public static class Services
    {
        public static bool ClearDropDown(DropDownList dropDown)
        {
            dropDown.Items.Clear();            
            bool filled = false;
            return filled;
        }

        public static void SelectRegion(RegionList regionList, RealmList realmList)
        {
            foreach (Region region in regionList.list)
            {
                if (regionList.dropDown.SelectedItem.Text == region.Name)
                {
                    realmList.selectedRegion = region.Code;
                }
            }
        }

        public static Character GetCharacter(string region, string realm, string name, string namesp, string locale, string token)
        {
            string apiURL = $"https://{region}.api.blizzard.com/profile/wow/character/{realm}/{name}?namespace={namesp}&locale={locale}&access_token={token}";

            Character character = new Character();

            using (WebClient client = new WebClient())
            {
                var info = client.DownloadString(apiURL);
                character = JsonConvert.DeserializeObject<Character>(info);
            }

            return character;
            
        }
    }
}
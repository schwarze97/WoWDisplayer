using Newtonsoft.Json;
using System;
using System.Net;
using System.Web.UI;
using System.Collections.Generic;
using WoWDisplayer.Models;
using System.Web.UI.WebControls;


namespace WoWDisplayer
{
    public partial class HomePage : Page
    {
        private static bool isFilledRegionList = false;
        private static bool isFilledRealmList = false;

        private static string token;
        private static string selectedRealm;
        private static string name;
        private static string locale;
        private static string namesp;

        private static RegionList regionList;
        private static RealmList realmList;

        private static List<Region> region_list = new List<Region>()
            {
                new Region("United States", "us"),
                new Region("Europe", "eu"),
                new Region("Korea", "kr"),
                new Region("Taiwan", "tw"),
                new Region("China", "cn")
            };


        public HomePage()
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                token = Session["Token"].ToString();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.ToString();
                Response.Redirect("ErrorDisplay.aspx");
            }

            regionList = new RegionList(region_list, RegionDropDown, isFilledRegionList);

            if (!isFilledRegionList)
                regionList.LoadList();

            isFilledRegionList = true;

        }

        

        protected void RegionDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFilledRealmList = Services.ClearDropDown(RealmDropDown);
                        
            if (RegionDropDown.SelectedItem.Text == RegionDropDown.Items[0].ToString())
            {
                string script = "alert('Please, select a region.');";
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(RegionDropDown, this.GetType(), "Test", script, true);

                isFilledRealmList = Services.ClearDropDown(RealmDropDown);
                isFilledRegionList = Services.ClearDropDown(RegionDropDown);

                Response.Redirect(Request.RawUrl);
            }



            realmList = new RealmList(RealmDropDown, isFilledRealmList, token);
            Services.SelectRegion(regionList, realmList);

            try
            {
                realmList.LoadList();
            }
            catch (Exception ex)
            {
                Session["ErrorMessage"] = ex.ToString();
                Response.Redirect("ErrorDisplay.aspx");
            }

        }

        protected void RealmDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRealm = RealmDropDown.SelectedItem.Text;
        }

        protected void LocaleTextBox_TextChanged(object sender, EventArgs e) //Locale
        {
            locale = LocaleTextBox.Text;
        }

        protected void CharacterNameTextBox_TextChanged(object sender, EventArgs e) //Character Name
        {
            name = CharacterNameTextBox.Text;
        }

        protected void NamespaceTextBox_TextChanged(object sender, EventArgs e) //Namespace
        {
            namesp = NamespaceTextBox.Text;
        }

        protected void GetInformationButton_Click(object sender, EventArgs e)
        {

            bool InputsAreFilled = !string.IsNullOrWhiteSpace(name)
                && !string.IsNullOrWhiteSpace(locale)
                && !string.IsNullOrWhiteSpace(namesp);

            if (InputsAreFilled)
            {
                try
                {
                    var character = Services.GetCharacter(realmList.selectedRegion, selectedRealm, name, namesp, locale, token);

                    NameTextBox.Text = character.Name;
                    LevelTextBox.Text = character.Level.ToString();
                    IDTextBox.Text = character.ID.ToString();
                }
                catch (Exception ex)
                {
                    Session["ErrorMessage"] = ex.ToString();
                    Response.Redirect("ErrorDisplay.aspx");
                }
            }
            else
            {
                string script = "alert('Please, fill the required fields.');";
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(GetInformationButton, this.GetType(), "Test", script, true);
            }


        }

        protected void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LevelTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
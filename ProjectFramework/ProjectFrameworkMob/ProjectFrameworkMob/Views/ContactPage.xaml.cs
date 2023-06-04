using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectFrameworkCommonLib;

namespace ProjectFrameworkMob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
            FillSettings();
        }
        private void FillSettings()
        {
            lblName.Text = App.ContactManagerObj.CSettings.ConName;
            lblAdress.Text = App.ContactManagerObj.CSettings.Adress;
            lblWeb.Text = App.ContactManagerObj.CSettings.Web;
            lblNumber.Text = App.ContactManagerObj.CSettings.Number;

        }
        private async void Button_Clicked(object sender, EventArgs e) //get contact settings
        {
            try
            {
                lblStatus.Text = "Getting Settings from Server..";

                ContactSettings CSettings = await App.ContactServiceObj.GetSettingsInfo();
              

                lblName.Text = CSettings.ConName;
                lblAdress.Text = CSettings.Adress;
                lblWeb.Text = CSettings.Web;
                lblNumber.Text = CSettings.Number;

                lblStatus.Text = "Success..";

            }
            catch (Exception Ex)
            {
                lblStatus.Text = "Failed..| " + Ex.Message;
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)//upadte contact settings
        {
            try
            {
                lblStatus.Text = "Updating Settings to Server..";

                App.ContactManagerObj.CSettings.ConName = lblName.Text;
                App.ContactManagerObj.CSettings.Adress = lblAdress.Text;
                App.ContactManagerObj.CSettings.Web = lblWeb.Text;
                App.ContactManagerObj.CSettings.Number = lblNumber.Text;
                bool bResult = await App.ContactServiceObj.UpdateSettingsInfo(App.ContactManagerObj.CSettings);

                if (bResult)
                {
                    App.SettingsManagerObj.SaveSettings();
                    lblStatus.Text = "Success..";
                }
                else
                {
                    lblStatus.Text = "Failed to Update..";
                }


            }
            catch (Exception Ex)
            {
                lblStatus.Text = "Failed..| " + Ex.Message;
            }

        }
    }
}
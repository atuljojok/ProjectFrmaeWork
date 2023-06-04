using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
using ProjectFrameworkCommonLib;
using ProjectFrameworkWeb.BLL;

namespace ProjectFrameworkWeb
{
    public partial class Contact : Page
    {
        ContactSettings CSettings = new ContactSettings();
       private SettingsBLL SettingsBLLObj = new SettingsBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelName.Text = SettingsBLLObj.GetValue("CoName");
            LabelAdress.Text = SettingsBLLObj.GetValue("Adress");
            LabelWeb.Text = SettingsBLLObj.GetValue("Web");
            LabelNum.Text = SettingsBLLObj.GetValue("Number");
        }
    }
}
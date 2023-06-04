using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectFrameworkWeb.BLL;

namespace ProjectFrameworkWeb.Admin
{
    public partial class ContactSettings : System.Web.UI.Page
    {
        private SettingsBLL SettingsBLLObj = new SettingsBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Load the Data
                TextBoxAppName.Text = SettingsBLLObj.GetValue("CoName");
                TextBoxAdress.Text = SettingsBLLObj.GetValue("Adress");
                TextBoxWeb.Text = SettingsBLLObj.GetValue("Web");
                TextBoxNum.Text = SettingsBLLObj.GetValue("Number");
              
               
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsBLLObj.SetValue("CoName", TextBoxAppName.Text);
                SettingsBLLObj.SetValue("Adress", TextBoxAdress.Text);
                SettingsBLLObj.SetValue("Web", TextBoxWeb.Text);
                SettingsBLLObj.SetValue("Number", TextBoxNum.Text);


                LabelStatus.Text = "Settings Updated Successfully...";
                Response.Redirect("~/Page/Contact");
            }
            catch (Exception Ex)
            {
                LabelStatus.Text = Ex.Message;
            }
        }
    }
}
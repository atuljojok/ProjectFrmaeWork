using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectFrameworkCommonLib;

namespace ProjectFramework.Web.Models
{       
    public class ContactViewModel:ViewModelBase
    {
        private BLL.SettingsBLL SettingsBLLObj = new BLL.SettingsBLL();
      
        public string EnableMobAuth { get; set; }
        public bool IsChecked { get; set; }

        public ContactViewModel()
        {
            
            LoadSettings();
        }
        private void LoadSettings()
        {
           
        }
        public bool UpdateSettings()
        {
            try
            {
                SettingsBLLObj.SetValue("Adress", Adress);
                SettingsBLLObj.SetValue("CoName", CoName);
                SettingsBLLObj.SetValue("Web", Web);
                SettingsBLLObj.SetValue("Number", Number);
               
                LoadSettings();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

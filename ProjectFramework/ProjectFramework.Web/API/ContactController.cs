using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectFrameworkCommonLib;




namespace ProjectFramework.Web.API
{
    [Route("api/contact")]
    //[ApiController]
    public class ContactController : ControllerBase
    {
        private BLL.SettingsBLL SettingsBLLObj = new BLL.SettingsBLL();
        private Models.ContactViewModel Cmodel = new Models.ContactViewModel();
        [Route("GetSettingsInfo")]
        [HttpGet]
        public ActionResult GetSettingsInfo()
        {
            try
            {
                ContactSettings CSettings = new ContactSettings();
                CSettings.Adress = SettingsBLLObj.GetValue("Adress");
                CSettings.ConName = SettingsBLLObj.GetValue("CoName");
                CSettings.Web = SettingsBLLObj.GetValue("Web");
                CSettings.Number = SettingsBLLObj.GetValue("Number");

                return Ok(CSettings); ;
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }

        }
        [Route("GetSettingsInfoEx")]
        [HttpGet]
        public ActionResult GetSettingsInfoEx(string Key)
        {
            try
            {
                string Value = "Key Value";

                return Ok(Value);
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }

        }
        [Route("UpdateSettingsInfo")]
        [HttpPost]
        public ActionResult UpdateSettingsInfo([FromBody]ContactSettings CSettings)
        {
            
            try
            {
               
                SettingsBLLObj.SetValue("CoName",CSettings.ConName);
                SettingsBLLObj.SetValue("Adress", CSettings.Adress);
                SettingsBLLObj.SetValue("Web", CSettings.Web);
                SettingsBLLObj.SetValue("Number", CSettings.Number);

                return Ok("Settings Updated Successfully");
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }

        }
    }
}


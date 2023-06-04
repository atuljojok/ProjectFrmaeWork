using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectFrameworkCommonLib;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectFramework.Web.API
{
    [Route("api/settings")]
    public class SettingsController : ControllerBase
    {
        private BLL.SettingsBLL SettingsBLLObj = new BLL. SettingsBLL();
        [Route("GetSettingsInfo")]
        [HttpGet]
        public ActionResult GetSettingsInfo()
        {
            try
            {
                AppSettings Settings = new AppSettings();
                Settings.AppName = SettingsBLLObj.GetValue("AppName");
                Settings.MainHeading = SettingsBLLObj.GetValue("MainHeading");
                Settings.MainDesc = SettingsBLLObj.GetValue("MainDesc");
                return Ok(Settings); ;
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
        public ActionResult UpdateSettingsInfo([FromBody]AppSettings Settings)
        {
            try
            {
                SettingsBLLObj.SetValue("AppName", Settings.AppName);
                return Ok("Settings Updated Successfully");
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }

        }
    }
}

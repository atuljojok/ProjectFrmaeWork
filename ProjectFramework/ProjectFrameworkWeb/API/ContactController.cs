using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectFrameworkCommonLib;
using ProjectFrameworkWeb.BLL;

namespace ProjectFrameworkWeb.API
{
    public class ContactController : TokenCheckController
    {
        private SettingsBLL SettingsBLLObj = new SettingsBLL();

        [HttpGet]
        public HttpResponseMessage GetSettingsInfo()
        {
            try
            {
                ContactSettings Settings = new ContactSettings();




                Settings.ConName = SettingsBLLObj.GetValue("CoName");
                Settings.Adress = SettingsBLLObj.GetValue("Adress");
                Settings.Web = SettingsBLLObj.GetValue("Web");
                Settings.Number = SettingsBLLObj.GetValue("Number");
                var message = Request.CreateResponse(HttpStatusCode.OK, Settings);
                message.Headers.Location = new Uri(Request.RequestUri.ToString());
                return message;
            }
            catch (Exception Ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex.Message);
            }

        }
        [HttpGet]
        public HttpResponseMessage GetSettingsInfoEx(string Key)
        {
            try
            {
                string Value = SettingsBLLObj.GetValue(Key);
                var message = Request.CreateResponse(HttpStatusCode.OK, Value);
                message.Headers.Location = new Uri(Request.RequestUri.ToString());
                return message;
            }
            catch (Exception Ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex.Message);
            }

        }
        [HttpPost]
        public HttpResponseMessage UpdateSettingsInfo(ContactSettings Settings)
        {
            try
            {
                SettingsBLLObj.SetValue("CoName", Settings.ConName);
                SettingsBLLObj.SetValue("Adress", Settings.Adress);
                SettingsBLLObj.SetValue("Web", Settings.Web);
                SettingsBLLObj.SetValue("Number", Settings.Number);
                var message = Request.CreateResponse(HttpStatusCode.OK, "Settings Updated Successfully");
                message.Headers.Location = new Uri(Request.RequestUri.ToString());
                return message;
            }
            catch (Exception Ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex.Message);
            }

        }

    }
}
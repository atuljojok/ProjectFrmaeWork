using Newtonsoft.Json;
using ProjectFrameworkCommonLib;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFrameworkMob.Services
{
   public partial class ContactApiService
    {
        public async Task<ContactSettings> GetSettingsInfo()
        {
            ContactSettings CSettings = new ContactSettings();
            try
            {

                var requestTask = await AppCServiceClient.GetAsync("api/Contact/GetSettingsInfo");
                var response = Task.Run(() => requestTask);
                Task<string> ResponseData;
                if (response.Result.IsSuccessStatusCode)
                {
                    ResponseData = response.Result.Content.ReadAsStringAsync();

                    CSettings = JsonConvert.DeserializeObject<ContactSettings>(ResponseData.Result);

                }
                else
                {
                    ResponseData = response.Result.Content.ReadAsStringAsync();
                    throw new Exception(ResponseData.Result);
                }
                return CSettings;
            }
            catch (Exception Ex)
            {
                throw Ex;
               
            }

        }
        public async Task<bool> UpdateSettingsInfo(ContactSettings CSettings)
        {
            bool bResult = false;
            try
            {
                var serializedItem = JsonConvert.SerializeObject(CSettings);
                string Paramters = "api/Contact/UpdateSettingsInfo";
                var requestTask = await AppCServiceClient.PostAsync(Paramters, new StringContent(serializedItem, Encoding.UTF8, "application/json"));
                var response = Task.Run(() => requestTask);
                Task<string> ResponseData;
                if (response.Result.IsSuccessStatusCode)
                {
                    bResult = true;

                }
                else
                {
                    ResponseData = response.Result.Content.ReadAsStringAsync();
                    throw new Exception(ResponseData.Result);
                }
                return bResult;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}


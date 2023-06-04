using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Xamarin.Essentials;
using System.Threading.Tasks;

namespace ProjectFrameworkMob.Services
{
  public partial class ContactApiService
    {
        AppCommunicationClient AppCServiceClient;
        bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;
        public HttpStatusCode StatusCode { get; set; }

        public ContactApiService()
        {

            InitializeClient();
        }
        public void InitializeClient()
        {
            AppCServiceClient = new AppCommunicationClient();
            AppCServiceClient.BaseAddress = new Uri($"{App.AzureBackendUrl}/");
        }
        public void SetUserCredentials(int CustomerID, string CustomerEmail, string AuthenticationToken)
        {
            AppCServiceClient.SetUserCredentials(CustomerID, CustomerEmail, AuthenticationToken);
        }

    }
}


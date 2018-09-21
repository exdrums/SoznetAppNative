using System;
using System.Net.Http;

namespace NetMobile.Services
{
    public class UserService
    {
        #region Constructor

        public UserService()
        {
            // TODO: Inject DI
        }

        #endregion

        #region Properties

        const string BaseUrl = "http://localhost:5000/api/";

        #endregion

        #region Actions

        // TODO: Implement all methods

        #endregion

        #region Private methods

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        #endregion

    }
}

using System;
using NetMobile.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetMobile.Services
{
    public class AuthService
    {
        #region Constructor

        public AuthService()
        {
            // TODO: Inject DI
        }

        #endregion

        #region Properties

        const string BaseUrl = "http://localhost:5000/api/auth/";
        public string UserToken { get; set; }
        public object DecodedToken { get; set; }
        public User CurrentUser { get; set; }

        #endregion

        #region Actions

        /// <summary>
        /// POST Method to login current user
        /// </summary>
        /// <returns>Current user</returns>
        /// /// <param name="userToAuth">User to login.</param>
        public async Task<User> Login(AuthUser userToAuth)
        {
            HttpClient client = GetClient();
            // TODO: implement logic 

            return null;
        }

        /// <summary>
        /// Register the new user.
        /// </summary>
        /// <returns>Registered user.</returns>
        /// <param name="user">User to register.</param>
        public async Task<User> Register(User user)
        {
            HttpClient client = GetClient();


            return null;
        }

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

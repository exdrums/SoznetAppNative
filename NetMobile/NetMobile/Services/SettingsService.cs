using System;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace NetMobile.Services
{
    public class SettingsService : ISettingsService
    {
        #region Constructor

        public SettingsService()
        {

        }

        #endregion

        #region Settings Constants

        private const string UserToken = "userToken";
        private readonly string UserTokenDefault = string.Empty;
        private const string BaseUrl = "baseUrl";
        private readonly string BaseUrlDefault = string.Empty; //GlobalSettings.Instance...


        #endregion

        #region Settings Properties

        public string AuthUserToken
        {
            get => GetValueOrDefault(UserToken, UserTokenDefault);
            set => AddOrUpdateValue(UserToken, value);
        }

        #endregion

        #region Public Methods

        public async Task AddOrUpdateValue<T>(string key, T value) //=> AddOrUpdateValueInternal(key, value);
        {
            if (value == null)
                await Remove(key);

            Application.Current.Properties[key] = value;
            try
            {
                await Application.Current.SavePropertiesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to save: " + key, " Message: " + ex.Message);
            }
        }

        public T GetValueOrDefault<T>(string key, T defaultValue = default(T)) 
        {
            object value = null;
            if (Application.Current.Properties.ContainsKey(key))
            {
                value = Application.Current.Properties[key];
            }
            return value != null ? (T)value : defaultValue;
        }

        #endregion

        #region Internal Methods

        async Task Remove(string key)
        {
            try
            {
                if (Application.Current.Properties[key] != null)
                {
                    Application.Current.Properties.Remove(key);
                    await Application.Current.SavePropertiesAsync();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to remove: " + key, " Message: " + ex.Message);
            }
        }

        #endregion
    }
}

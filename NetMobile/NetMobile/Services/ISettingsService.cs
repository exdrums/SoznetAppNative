using System;
using System.Threading.Tasks;
namespace NetMobile.Services
{
    public interface ISettingsService
    {
        string AuthUserToken{ get; set; }

        Task AddOrUpdateValue<T>(string key, T value);
        T GetValueOrDefault<T>(string key, T defaultValue = default(T));
    }
}

using Codelab.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Codelab.ViewModels
{
    public class ProfileViewModel
    {
        static public UserProfileModel UserProfile;

        static public async Task<ApiResponse> GetUser()
        {
            ApiResponse response = null;
            HttpClient httpClient = new HttpClient();
            var httpresponse = await httpClient.GetStringAsync("https://api.github.com/users/kenyansongithub");
            var user = JsonConvert.DeserializeObject<UserProfileModel>(httpresponse);
            response = new ApiResponse
            {
                Content = httpresponse,
                StatusCode = 200
            };

            UserProfile = user;

            return response;
        }
    }
}

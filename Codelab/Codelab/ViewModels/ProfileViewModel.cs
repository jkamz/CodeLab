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

        static public async Task<ApiResponse> GetUser(string url)
        {
            ApiResponse response = null;
            try
            {
                HttpClient httpClient = new HttpClient();
                var httpresponse = await httpClient.GetStringAsync(url);
                var user = JsonConvert.DeserializeObject<UserProfileModel>(httpresponse);
                response = new ApiResponse
                {
                    Content = httpresponse,
                };

                UserProfile = user;
            }
                
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return response;
        }
    }
}

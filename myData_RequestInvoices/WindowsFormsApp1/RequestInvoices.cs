using Mono.Web;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RequestInvoices
    {
        public  async Task<string> MakeRequestAsync(string UserID, string Subscription, string Mark)
        {
            HttpResponseMessage response ;
         
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(20);
                var queryString = HttpUtility.ParseQueryString(string.Empty);


                // Request headers
                client.DefaultRequestHeaders.Add("aade-user-id", UserID);
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Subscription);

                // Request parameters
                queryString["mark"] = Mark;

                var uri = "https://mydata-dev.azure-api.net/RequestInvoices?" + queryString;

                response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    //Read respone
                }
            }
           
            return response.ToString();
        }
    }
}

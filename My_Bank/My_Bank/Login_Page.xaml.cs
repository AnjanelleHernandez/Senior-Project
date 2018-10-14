using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_Bank
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login_Page : ContentPage
	{

        static HttpClient client = new HttpClient();

        public Login_Page ()
		{
			InitializeComponent();
            //Task<string> task1 = ApiConnection();
            //apiLabel.Text = task1.Result;
           
        }
        private async Task<string> ApiConnection()
        {
            client.BaseAddress = new Uri("http://localhost:57525/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("api/values");
            string Response = "";
            if (response.IsSuccessStatusCode)
            {
               Response = await response.Content.ReadAsStringAsync();
            }
            return Response;
        }
        async void NavigateButton_HomeScreenOnClicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new Home_Screen();
            //await Navigation.PushAsync(new Home_Screen());
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage result = await client.GetAsync("http://api/values");
            if (result.IsSuccessStatusCode)
            {
                apiLabel.Text = result.ToString();
            }

        }
        private async void NavigateButton_CreateAccountOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create_Account());
        }
    }
}
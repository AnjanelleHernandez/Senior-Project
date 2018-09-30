using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace My_Bank
{
	public partial class App : Application
	{
        static HttpClient client = new HttpClient();

        public App ()
		{
			InitializeComponent();

			//MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            MainPage = new NavigationPage(new Login_Page());
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

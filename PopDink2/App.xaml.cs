using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PopDink2.views;
namespace PopDink2
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new PopDink();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}

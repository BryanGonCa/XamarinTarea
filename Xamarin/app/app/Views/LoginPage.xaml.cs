using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public LoginPage()
        {
            InitializeComponent();
            btLogin.Clicked += BtLogin_Clicked;
        }
        private void BtLogin_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ListViewPage1 ());
        }
    }
}
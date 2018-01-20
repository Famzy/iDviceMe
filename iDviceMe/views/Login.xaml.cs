using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;
using iDviceMe.Modules;

namespace iDviceMe.views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            Init();
        }
        void Init(){
            BackgroundColor = Constants.BackgroundColor;
            lbl_Name.TextColor = Constants.MainTextColor;
            lbl_password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            usr_Name.Completed += (s, e) => usr_password.Focus();
            usr_password.Completed += (s, e) => SignInProcedure(s, e);
        }

        void SignInProcedure(object sender, EventArgs e){
            
            Users users = new Users(usr_Name.Text, usr_password.Text);

            if (users.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Okay");
            }
            else{

                DisplayAlert("Login", "Login not Correct, empty username or pawword", "Okay");
            }
        }
    }
}

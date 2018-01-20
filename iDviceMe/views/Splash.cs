using System;

using Xamarin.Forms;

namespace iDviceMe.views
{
    public class Splash : ContentPage
    {
        public Splash()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


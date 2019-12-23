using System;

namespace iPhoneHomeQuickActions
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnPage1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void BtnPage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void BtnPage3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}

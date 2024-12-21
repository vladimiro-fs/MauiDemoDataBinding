namespace MauiDemoDataBinding
{
    using MauiDemoDataBinding.Pages;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NotifyBinding());
        }
    }
}

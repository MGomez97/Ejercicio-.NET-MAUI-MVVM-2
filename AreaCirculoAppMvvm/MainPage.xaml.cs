using AreaCirculoAppMvvm.ViewModels;

namespace AreaCirculoAppMvvm.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}

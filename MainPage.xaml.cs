using System.Diagnostics;
using System.Windows.Input;

namespace DisabledGestureResponse
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            Debug.WriteLine("Tapped");
        }

        public ICommand TappedCommand { get; } = new Command(() => 
        {
            Debug.WriteLine("TappedCommand");
        }); 
    }
}
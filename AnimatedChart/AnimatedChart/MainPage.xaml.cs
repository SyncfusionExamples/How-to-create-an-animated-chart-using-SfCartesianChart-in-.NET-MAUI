namespace AnimatedChart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Animation_Clicked(object sender, EventArgs e)
        {
            series.ItemsSource = viewModel.Data2;    
        }
    }
}
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
#if WINDOWS || MACCATALYST
            viewModel.Data.Add(new ChartDataModel("Oct", 73));

#elif ANDROID || IOS
            viewModel.Data.Add(new ChartDataModel("Jun", 81));
#endif
        }
    }
}
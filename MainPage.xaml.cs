namespace KOstka_MAUI_nigg
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
       Random r = new Random();
            int KOstka_MAUI_nigg = r.Next(1, 7);

            CounterBtn.Text ="Wylosowany rzut :" + KOstka_MAUI_nigg.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}

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

            RollValueLabel.Text = "Wylosowany rzut :" + KOstka_MAUI_nigg.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            Random r = new Random();
            int KOstka_MAUI_nigg = r.Next(1, 10);

            RollValueLabel.Text = "Wylosowany rzut :" + KOstka_MAUI_nigg.ToString();

            SemanticScreenReader.Announce(CounterBtn9.Text);
        }

        private void OnCounterClicked3(object sender, EventArgs e)
        {
            Random r = new Random();
            int KOstka_MAUI_nigg = r.Next(1, 12);

            RollValueLabel.Text = "Wylosowany rzut :" + KOstka_MAUI_nigg.ToString();

            SemanticScreenReader.Announce(CounterBtn12.Text);
        }
    }

}

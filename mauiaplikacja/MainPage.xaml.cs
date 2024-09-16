namespace DiceRoll
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //wygenerowanie liczby losowej
            Random r = new Random();
            //genrujemy rzut kostką K6 - <1;6>
            int diceRoll = r.Next(1, 7);

            CounterBtn.Text = "Wysolowany rzut: " + diceRoll.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
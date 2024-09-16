namespace mauiaplikacja
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            // Tworzenie obiektu Random
            Random r = new Random();
            int diceRoll = 0;

            // Sprawdzenie, który RadioButton jest zaznaczony
            if (Dice4RadioButton.IsChecked)
            {
                // Rzut kostką K4
                diceRoll = r.Next(1, 5);
            }
            else if (Dice6RadioButton.IsChecked)
            {
                // Rzut kostką K6
                diceRoll = r.Next(1, 7);
            }
            else if (Dice10RadioButton.IsChecked)
            {
                // Rzut kostką K10
                diceRoll = r.Next(1, 11);
            }
            else if (Dice12RadioButton.IsChecked)
            {
                // Rzut kostką K12
                diceRoll = r.Next(1, 13);
            }

            // Wyświetlenie wyniku
            RollValueLabel.Text = "Wynik rzutu: " + diceRoll.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
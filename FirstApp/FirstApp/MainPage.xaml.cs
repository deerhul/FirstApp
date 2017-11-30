using System;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {

        static string bomb = new Random().Next(1,4).ToString();
        private int score = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(Object sender, EventArgs e)
        {
            Button button = sender as Button;

            //Game Over
            if (button.Text == bomb)
            {
                await DisplayAlert("Bomb Exploded!", "GAME OVER", "Retry");
                score = 0;
                bomb = new Random().Next(1, 10).ToString(); //assign new number as bomb               
            }
            else
            {
                score++;
                scoreLabel.Text = "Score: " + score;
                bomb = new Random().Next(1,10).ToString();
            }
        }
    }
}

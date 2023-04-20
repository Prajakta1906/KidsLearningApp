using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Game
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void White_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("White");
        }

        private void Red_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Red");
        }
        private void Blue_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Blue");
        }
        private void Yellow_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Yellow");
        }

        private void Green_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Green");
        }
        private void Black_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Black");
        }
        private void Pink_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Pink");
        }
        private void Orange_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync("Orange");
        }
        private void mybtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }


    }
}

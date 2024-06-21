
using static System.Net.WebRequestMethods;

namespace FlipCoin
{
    public partial class MainPage : ContentPage
    {
        String nomeLadoSelecionado, caraCoroa;
        int ladoSelecionado;

        public MainPage()
        {
            InitializeComponent();
            CoinPck.SelectedIndex = 0;
        }

        private void OnFlipCoinClicked(object sender, EventArgs e)
        {
            ladoSelecionado = CoinPck.SelectedIndex;
            int ladoSorteado = new Random().Next(1, 3);
            if (ladoSorteado == 1) // Cara
            {
                caraCoroa = "Cara";
                CoinLbl.Text = caraCoroa;
                CC.Source = ImageSource.FromUri(new Uri("https://www2.sorteador.com.br/_imgs/caracoroa/cara.jpg"));
            }
            else
            {
                caraCoroa = "Coroa";
                CoinLbl.Text = caraCoroa;
                CC.Source = ImageSource.FromUri(new Uri("https://www2.sorteador.com.br/_imgs/caracoroa/coroa.jpg"));
            }

            if (ladoSelecionado == 0)
            {
                nomeLadoSelecionado = "Cara";
            }
            else
            {
                nomeLadoSelecionado = "Coroa";
            }

            if (ladoSorteado == 1 && ladoSelecionado == 0)
            {
                DisplayAlert("Você ganhou!", $"Você selecionou {nomeLadoSelecionado} e caiu {caraCoroa}!", "Ok");
            }
            else if (ladoSorteado == 2 && ladoSelecionado == 1)
            {
                DisplayAlert("Você ganhou!", $"Você selecionou {nomeLadoSelecionado} e caiu {caraCoroa}!", "Ok");
            }
            else
            {
                DisplayAlert("Você perdeu!", $"Você selecionou {nomeLadoSelecionado} e caiu {caraCoroa}!", "Ok");
            }
        }
    }
}
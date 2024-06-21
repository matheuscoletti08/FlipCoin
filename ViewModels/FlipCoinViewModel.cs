using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FlipCoin.Models;

namespace FlipCoin.ViewModels
{
    internal partial class FlipCoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _ladoSelecionado;
        [ObservableProperty]
        private string _ladoSorteado;
        [ObservableProperty]
        private string _caraCoroa = "Cara ou Coroa?";
        [ObservableProperty]
        private string _imageCoin;


        public ICommand RollCommand { get; }

        public void Flip()
        {
            Coin coin = new Coin();
            coin.Flip();
            ImageCoin = $"https://www2.sorteador.com.br/_imgs/caracoroa/{coin.LadoSorteado}.jpg";

            if (LadoSorteado == "cara" && LadoSelecionado == "cara")
            {
                CaraCoroa = "Você Ganhou! Selecionou Cara e caiu Cara";
                return;
            }
            else if (LadoSorteado == "coroa" && LadoSelecionado == "coroa")
            {
                CaraCoroa = "Você Ganhou! Selecionou Coroa e caiu Coroa";
                return;
            }
            CaraCoroa = "Você Perdeu!";
        }
        public FlipCoinViewModel()
        {
            RollCommand = new Command(Flip);
        }
    }
}

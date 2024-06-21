using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlipCoin.Models
{
    internal class Coin
    {
        public string LadoSorteado {  get; set; }
        

        public void Flip()
        {
            LadoSorteado =  new Random().Next(2) == 0 ?  "cara" : "coroa";
        }
    }
}

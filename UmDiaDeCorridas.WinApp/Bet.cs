using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmDiaDeCorridas.WinApp
{
    public class Bet
    {
        public int Amount; //A quantidade de dinheiro que foi apostada
        public int Dog; // o numero do cão em que apostados
        public Guy Bettor; //o cara que fez a aposta

        /// <summary>
        /// Retorna uma sequência de caracteres que diz quem fez a aposta, quanto dinheiro foi apostado e em qual cão foi realizado a aposta.
        /// Se a quantidade for zero, a aposta não foi feita.
        /// </summary>
        public string GetDescription()
        {
            if (Amount == 0)
            {
                return string.Format("{0} não apostou nesta rodada.", Bettor.Name);
            }

            return string.Format("{0} apostou R${1} no cão numero {2}.", Bettor.Name, Amount, Dog);

        }

        /// <summary>
        /// O parametro deve receber o vencedor da corrida, se o cão venceu, retora a quantidade apostada, de outra forma, retorne um valor negativo correspondente ao valor apostado.
        /// </summary>
        public int PayOut(int winner)
        {
            if (winner == Dog)
                return Amount * 2;

            return Amount;
        }

    }
}

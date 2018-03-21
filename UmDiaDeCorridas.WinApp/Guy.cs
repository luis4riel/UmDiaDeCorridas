using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmDiaDeCorridas.WinApp
{
    public class Guy
    {
        public string Name; //nome do cara
        public Bet MyBet; //uma instancia de Bet() que mantm as apostas
        public int Cash; //quanto dinheiro resta
        public RadioButton MyRadioButton;
        public Label MyLabel;

        /// <summary>
        ///Atribua ao meu rotulo a descrição da minha aposta, e ao rotulo do meu botão de radio o meu dinheiro ("João tem 43 reais")
        /// </summary>
        public void UpdateLabels()
        {
            if (MyBet != null)
                this.MyLabel.Text = this.MyBet.GetDescription();
            else
                this.MyLabel.Text = string.Format("{0} não apostou nesta rodada.", this.Name);

            this.MyRadioButton.Text = string.Format("{0} tem R${1}", this.Name, this.Cash);
        }

        /// <summary>
        ///reinicialize minha aposta para que ela zere
        /// </summary>
        public void ClearBet()
        {
            if (MyBet != null)
                this.MyBet.Amount = 0; this.MyBet.Dog = 0;
        }

        /// <summary>
        ///crie uma nova aposta e armazene-a no meu campo Bet
        ///Retorne verdadeiro se o cara tem dinheiro suficiente para apostar
        /// </summary>
        public bool PlaceBet(int amount, int dog)
        {
            if (this.Cash < amount)
                return false;

            this.MyBet = new Bet();
            MyBet.Amount = amount;
            MyBet.Bettor = this;
            MyBet.Dog = dog;

            //subtraio o valor da aposta no montante do apostador
            this.Cash = (this.Cash - amount);

            return true;
        }

        /// <summary>
        ///Cobre minha aposta se eu ganhei
        /// </summary>
        public void Collect(int winner)
        {
            if (MyBet != null)
                if (MyBet.Dog == winner)
                    this.Cash = this.Cash + MyBet.PayOut(winner);
                else
                    this.Cash = this.Cash - MyBet.PayOut(winner);

        }
    }
}
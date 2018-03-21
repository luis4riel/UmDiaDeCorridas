using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmDiaDeCorridas.WinApp
{
    public partial class Principal : Form
    {

        private List<Guy> guys = new List<Guy>();
        private List<GreyHound> greyHounds = new List<GreyHound>();

        public Principal()
        {
            InitializeComponent();

            int raceTrackLenght = picPista.Size.Width;

            if (guys != null || greyHounds != null)
            {
                #region Declaração dos apostadores
                Guy joao = new Guy();
                joao.Name = "João";
                joao.Cash = 50;
                joao.MyLabel = lblJoao;
                joao.MyRadioButton = rbtJoao;
                guys.Add(joao);

                Guy beto = new Guy();
                beto.Name = "Beto";
                beto.Cash = 75;
                beto.MyLabel = lblBeto;
                beto.MyRadioButton = rbtBeto;
                guys.Add(beto);

                Guy alfredo = new Guy();
                alfredo.Name = "Alfredo";
                alfredo.Cash = 45;
                alfredo.MyLabel = lblAlfredo;
                alfredo.MyRadioButton = rbtAlfredo;
                guys.Add(alfredo);
                #endregion

                #region Declaração dos cães

                GreyHound greyHound1 = new GreyHound();
                greyHound1.StartingPosition = 1;
                greyHound1.RaceTrackLenght = raceTrackLenght;
                greyHound1.MyPictureBox = pic1;
                greyHounds.Add(greyHound1);

                GreyHound greyHound2 = new GreyHound();
                greyHound2.StartingPosition = 2;
                greyHound2.RaceTrackLenght = raceTrackLenght;
                greyHound2.MyPictureBox = pic2;
                greyHounds.Add(greyHound2);

                GreyHound greyHound3 = new GreyHound();
                greyHound3.StartingPosition = 3;
                greyHound3.RaceTrackLenght = raceTrackLenght;
                greyHound3.MyPictureBox = pic3;
                greyHounds.Add(greyHound3);

                GreyHound greyHound4 = new GreyHound();
                greyHound4.StartingPosition = 4;
                greyHound4.RaceTrackLenght = raceTrackLenght;
                greyHound4.MyPictureBox = pic4;
                greyHounds.Add(greyHound4);

                #endregion
            }

        }
        private void Principal_Load(object sender, EventArgs e)
        {
            foreach (Guy selectGuy in guys)
            {
                selectGuy.UpdateLabels();
            }
        }

        /// <summary>
        /// Alterar o nome no radio button no canto inferior esquerdo do forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtJoao_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Guy selectGuy in guys)
            {
                if (sender == selectGuy.MyRadioButton)
                {
                    lblApostaNome.Text = selectGuy.Name;
                    break;
                }
            }
        }

        /// <summary>
        /// Captura as informações do botão "Apostar", converte e atualiza os labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAposta_Click(object sender, EventArgs e)
        {
            foreach (Guy selectGuy in guys)
            {
                if (selectGuy.Name == lblApostaNome.Text)
                {
                    int mascada = Convert.ToInt32(nudValor.Value);
                    int dognho = Convert.ToInt32(nudCao.Value);

                    if (selectGuy.PlaceBet(mascada, dognho))
                        selectGuy.UpdateLabels();
                    else
                        MessageBox.Show("Não tem dinheiro pra apostar o MERDA!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
            

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            int GreyHoundWinner = Run();


            foreach (Guy selectguy in guys)
            {
                selectguy.Collect(GreyHoundWinner);
                selectguy.ClearBet();
                selectguy.UpdateLabels();
            }
            foreach (GreyHound selectDognho in greyHounds)
            {
                selectDognho.TakeStartingPosition();
            }


            MessageBox.Show(string.Format("O cão número {0} venceu a corrida!", GreyHoundWinner), "Fim de corrida", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Enabled = true;
        }

        private int Run()
        {
            int winner = 0;
            while (winner == 0)
            {
                foreach (GreyHound dognho in greyHounds)
                {
                    bool isWinner = dognho.Run();
                    if (isWinner)
                        winner = dognho.StartingPosition;
                    Thread.Sleep(15);
                }
            }
            return winner;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmDiaDeCorridas.WinApp
{
    public class GreyHound
    {
        public int StartingPosition; //Onde a caixa de imagem inicia
        public int RaceTrackLenght; //comprimento da pista
        public PictureBox MyPictureBox = null; //Objeto caixa de imagem
        public int Location = 0; //Posição da pista, se 0 está na linha de largada
        public Random MyRandom;
        

        /// <summary>
        ///mova-se para frente 1, 2, 3, ou 4 espaços aleatoriamente
        ///atualize a posição da minha caixa de imagem no formulario
        ///retorna true se eu ganhei a corrida
        /// </summary>
        public bool Run()
        {
            Point p = MyPictureBox.Location;
            MyRandom = new Random();

            p.X = p.X + MyRandom.Next(10);
            MyPictureBox.Location = p;

            if(p.X >= (RaceTrackLenght - this.MyPictureBox.Size.Width))
                return true;
            return false;
        }

        /// <summary>
        ///Volte minha posição para a linha de partida
        /// </summary>
        public void TakeStartingPosition()
        {
            Point p = this.MyPictureBox.Location;
            p.X = StartingPosition;
            this.MyPictureBox.Location = p;
        }
    }
}

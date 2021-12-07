using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble_Segui_Bottos_TDA
{
    class Jeton

    {



        private char lettre;
        private int scoreLettre;
        private int dupliqué;
        private Sac_Jetons jeton;

        public Jeton(char lettre, int scoreLettre, int dupliqué)
        {
            this.lettre = lettre;
            this.scoreLettre = scoreLettre;
            this.dupliqué = dupliqué;
        }

        public char Lettre
        {
            get { return this.lettre; }
            set { lettre = value; }
        }

        public int ScoreLettre
        {
            get { return this.scoreLettre; }
            set { scoreLettre = value; }
        }

        public int Dupliqué
        {
            get { return this.dupliqué; }
            set { dupliqué = value; }
        }


        public override string ToString() // Retourne une chaîne de caractères qui décrit un jeton.
        {
            return "La lettre " + lettre + " a un score de " + scoreLettre + " et est dupliqué " + dupliqué + " fois.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble_Segui_Bottos_TDA
{
    class Sac_Jetons
    {
        private List<string> jeton;
        private string Jetons;

        public Sac_Jetons(List<string> jeton, string Jetons)
        {
            this.jeton = new List<Jeton>(27);
            string[] Valeurs = File.ReadAllLines(Jetons);
            for(int i=0; i<Valeurs.Length; i++)
            {

            }

        }

        public Jeton Retire_Jeton(Random r) // Cette méthode permet de tirer au hasard un jeton parmi les possibles.
        {
            int nbreAléatoire = r.Next(0, 103); // Choisis un nombre entre 0 et 102 (nombre total de jetons)
            return Jeton[nbreAléatoire]; // revoir
        }
    }
}

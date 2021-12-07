using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble_Segui_Bottos_TDA
{
    class Joueur
    {
        private string nom;
        private int score;
        private List<string> motsTrouvés;

        public Joueur(string nom, List<string> motsTrouvés)
        {
            this.nom = nom;
            this.score = 0;
            this.motsTrouvés = null;
        }
        // La création d’un joueur n’est possible que si celui-ci a un nom au départ du jeu. ??
        public string Nom
        {
            get { return this.nom; }
            set { nom = value; }
        }

        public int Score
        {
            get { return this.score; }
            set { score = 0; } // ?
        }

        public string AffichageMotsTrouvés() // Méthode qui permet d'afficher la liste de mots trouvés de manière lisible.
        {
            string Affichage = "";
            for (int a = 0; a <= motsTrouvés.Count - 1; a++)
            {
                Affichage += "\n" + motsTrouvés[a];
            }
            return Affichage;
        }

        public void Add_Mot(string mot)     // Ajoute le mot dans la liste des mots déjà trouvés par le joueur au cours de la partie.
        {
            this.motsTrouvés.Add(mot);
        }

        public override string ToString() // Retourne une chaîne de caractères qui décrit un joueur (nom, score et mots trouvés).
        {
            return "Le joueur se nomme " + Nom + ", son score est de " + Score + " points." + AffichageMotsTrouvés();
     
        }

        public void Add_Score(int val) // Ajoute une valeur au score.
        {
            score += val;
        }

        public void Add_Main_Courante(Jeton monjeton) // Ajoute un jeton à la main courante.
        {

        }

        public void Remove_Main_Courante(Jeton monjeton) // Retire un jeton de la main courante.
        {

        }



    }
}

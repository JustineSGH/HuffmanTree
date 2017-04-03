using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Algorithme1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez saisir une phrase et valider avec la touche \"Entrée\" : ");
            string saisie = Console.ReadLine();
            /*Je créée une nouvelle instance de ma classe ParcoursArbre*/
            ParcoursArbre algo = new ParcoursArbre();
            algo.Parcours(saisie);
        }
    }
    /*-----------------------------------------------------------------------------PARCOURS ARBRE--------------------------------------------------------*/
    public class ParcoursArbre
    {
        int i;
        /*définition du dictionnaire*/
        public Dictionary<char, int> dico = new Dictionary<char, int>(); 
        public void Parcours(string saisie)
        {
            /*compter le nombre d'occurence*/
            for (i = 0; i < saisie.Length; i++)
            {
                if (!dico.ContainsKey(saisie[i]))
                {
                    dico.Add(saisie[i], 0);
                }
                dico[saisie[i]]++;
            }
            /*fonction de tri */
            var tri = from pair in dico orderby pair.Value descending select pair;
            foreach (KeyValuePair<char, int> pair in tri)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            //Compression de ma chaine de caractère 
            Noeud Arbre = new Noeud();
            Noeud NoeudActif = Arbre;

            foreach (KeyValuePair<char, int> clef in tri)    
            {
                char Caractere = clef.Key;
                //Création d'un fils gauche et d'un fils droit
                Noeud FilsGauche = new Noeud();
                Noeud FilsDroit = new Noeud();
                FilsGauche.setMot(Caractere);
                NoeudActif.setFilsGauche(FilsGauche);
                NoeudActif.setFilsDroit(FilsDroit);
                NoeudActif=FilsDroit;
            }

            string MotEncoder = null;
            for (i = 0; i < saisie.Length; i++)//Parcours de ma chaine de caractere
            {
                char caractereMot = saisie[i];
                if (i != 0)
                {
                    MotEncoder = MotEncoder + Arbre.encode(caractereMot);
                }
                else
                {
                    MotEncoder = Arbre.encode(caractereMot);
                }
            }
            Console.WriteLine("Vous avez saisie: "+ saisie + ". Voici la chaine compressée : " + MotEncoder);
  
           //Décompression de ma chaine binaire
           String MotDecoder = null;
            Noeud NoeudActif2 = Arbre;

            for (i = 0; i < MotEncoder.Length; i++) //Parcours de ma chaine binaire
            {
                Char caractereMot = MotEncoder[i];
                
                if (caractereMot == '1')
                {
                    NoeudActif2 = NoeudActif2.getFilsDroit();
                }
                else
                {
                    NoeudActif2 = NoeudActif2.getFilsGauche();
                    string conversion = Convert.ToString(NoeudActif2.getMot());
                    MotDecoder = MotDecoder + conversion;
                    NoeudActif2 = Arbre;
                }
            }
            Console.WriteLine("Voici la chaine décompressée: "+ MotDecoder);
        }
    }
        /*------------------------------------------------------Class NOEUD----------------------------------------------------------------*/
        public class Noeud
        {
            private char Mot;
            public Noeud FilsDroit { get; set; }
            public Noeud FilsGauche { get; set; }

        public string encode(char Lettre)
            {
                if (FilsGauche.getMot() == Lettre)
                {
                    return "0";
                }
                else
                {
                    return "1" + FilsDroit.encode(Lettre);
                }
            }
            public char getMot()
            {
                return Mot;
            }
            public void setMot(char Mot)
            {
                this.Mot = Mot;
            }

            public Noeud getFilsGauche()
            {
                return FilsGauche;
            }

            public void setFilsGauche(Noeud FilsGauche)
            {
                this.FilsGauche = FilsGauche;
            }

            public Noeud getFilsDroit()
            {
                return FilsDroit;
            }

            public void setFilsDroit(Noeud FilsDroit)
            {
                this.FilsDroit = FilsDroit;
            }
        }
 }


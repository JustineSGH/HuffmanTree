using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
/*
namespace Algorithme1
{

            
            while (noeuds.Count > 1)
            {
                List<Node> NoeudOrdonne = noeuds.OrderBy(node => node.Nombre_Occurence).ToList<Node>();
                if (NoeudOrdonne.Count >= 2)
                {
                    List<Node> Valeur = NoeudOrdonne.Take(2).ToList<Node>();

                    Node Ajout = new Node()
                    {
                        Nombre_Occurence = Valeur[0].Nombre_Occurence + Valeur[1].Nombre_Occurence,
                        FilsGauche = Valeur[0],
                        FilsDroit = Valeur[1]
                    };
                    noeuds.Remove(Valeur[0]);
                    noeuds.Remove(Valeur[1]);
                    noeuds.Add(Ajout);
                }
                this.Racine = noeuds.FirstOrDefault();
            }
        }
        public BitArray Encodage(string saisie) 
        {
            List<bool> EncodageSaisie = new List<bool>();

            for (int i = 0; i < saisie.Length; i++)
            {
                List<bool> EncodageFrequence = this.Racine.Traverse(saisie[i], new List<bool>());
                EncodageSaisie.AddRange(EncodageFrequence);
            }
            BitArray bits = new BitArray(EncodageSaisie.ToArray());
            return bits;
        }
        }
    }
    
    }

    }*/
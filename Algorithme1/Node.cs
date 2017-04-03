using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 /*
namespace Algorithme1
{
      
        public List<bool> Traverse(char caractere, List<bool> donnee)
        {
            if (FilsDroit == null && FilsGauche == null)
            {
                if (caractere.Equals(this.Caractere))
                {
                    return donnee;
                }
                else
                {
                    return null;
                }
            }
            else
            { 
                List<bool> gauche = null;
                List<bool> droit = null;

            if (FilsGauche != null)
            {
                List<bool> ParcoursGauche = new List<bool>();
                ParcoursGauche.AddRange(donnee);
                ParcoursGauche.Add(false);

                gauche = FilsGauche.Traverse(caractere, ParcoursGauche);
            }

            if (FilsDroit != null)
            {
                List<bool> ParcoursDroit = new List<bool>();
                ParcoursDroit.AddRange(donnee);
                ParcoursDroit.Add(true);
                droit = FilsDroit.Traverse(caractere, ParcoursDroit);
            }

            if (gauche != null)
            {
                return gauche;
            }
            else
            {
                return droit;
            }
        }
    }
}*/
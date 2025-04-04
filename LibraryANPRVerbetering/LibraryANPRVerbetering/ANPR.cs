using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryANPRVerbetering
{
    public class ANPR
    {
        //lokale variabelen
        string zoekterm;
        List<string> lokRegistraties = new List<string>();
        //constructormethod
        public ANPR(string nummerplaat, List<string> registraties)
        {
            zoekterm = nummerplaat;
            lokRegistraties = registraties;
        }

        //method
        public List<string> Zoeken()
        {
            List<string> resultaat = new List<string>();
            for (int i = 0; i <= lokRegistraties.Count-1; i++)
            {
                string registratie = lokRegistraties[i];
                int positie = registratie.IndexOf(";");
                string nummerplaat = registratie.Substring(0, positie);
                string moment = registratie.Substring(positie + 1);
                if (nummerplaat.Contains(zoekterm))
                {
                    resultaat.Add(string.Format("{0} passeerde op {1}.", nummerplaat, moment));
                }
            }
            return resultaat;            
        }
    }
}

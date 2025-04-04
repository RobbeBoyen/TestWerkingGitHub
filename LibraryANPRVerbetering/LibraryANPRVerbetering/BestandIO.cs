using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryANPRVerbetering
{
    public class BestandIO
    {
        public List<string> Ophalen(string pad)
        {
            StreamReader streamreader = new StreamReader(pad);
            List<string> invoer = new List<string>();
            while (streamreader.EndOfStream == false)
            {
                invoer.Add(streamreader.ReadLine());
            }
            streamreader.Close();
            return invoer;
        }

        public void Wegschrijven(string pad, List<string> lijst)
        {
            StreamWriter streamwriter = new StreamWriter(pad, false);
            foreach (string item in lijst)
            {
                streamwriter.WriteLine();
            }
            streamwriter.Close();
        }
    }
}

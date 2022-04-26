using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdlGsbRapportsVisite
{
    public class Secretaire
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string ticket { get; set; }
        public Secretaire(string nom, string prenom, string ticket)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ticket = ticket;
        }

    }
}

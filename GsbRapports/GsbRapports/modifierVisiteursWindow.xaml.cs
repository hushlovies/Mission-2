using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net;
using dllRapportVisites;
using Newtonsoft.Json;
using System.Collections.Specialized;//pour api

namespace GsbRapports
{
    /// <summary>
    /// Logique d'interaction pour modifierVisiteursWindow.xaml
    /// </summary>
    public partial class modifierVisiteursWindow : Window
    {
        private Secretaire laSecretaire;
        private WebClient wb;
        private string site;
        public modifierVisiteursWindow(Secretaire laSecretaire, WebClient wb, String site)
        {
            InitializeComponent();
            this.laSecretaire = laSecretaire;
            this.site = site;
            this.wb = wb;
            string url = this.site + "visiteurs?ticket=" + this.laSecretaire.getHashTicketMdp(); //retourne le mdp hashé
            string reponse = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(reponse);
            string visiteurs = d.visiteurs.ToString();
            string ticket = d.ticket;
            this.laSecretaire.ticket = ticket;
            List<Visiteur> l = JsonConvert.DeserializeObject<List<Visiteur>>(visiteurs);

            this.cmbVisiteur.ItemsSource = l;
            this.cmbVisiteur.DisplayMemberPath = "concatNomPrenom";
        }
    }
}

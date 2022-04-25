using dllRapportVisites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace GsbRapports
{
    /// <summary>
    /// Logique d'interaction pour ajouterVisiteurWindow.xaml
    /// </summary>
    public partial class ajouterVisiteurWindow : Window
    {
        private Secretaire laSecretaire;
        private WebClient wb;
        private string site;

        public ajouterVisiteurWindow(Secretaire laSecretaire, WebClient wb, string site)
        {
            InitializeComponent();
            this.laSecretaire = laSecretaire;
            this.wb = wb;
            this.site = site;
        }

        private void btnValider_Click1(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    string url = this.site + "visiteurs";
                    NameValueCollection parametres = new NameValueCollection();
                    parametres.Add("ticket", this.laSecretaire.getHashTicketMdp());
                    parametres.Add("id", this.txtIdVisiteur.Text);
                    parametres.Add("nom", this.txtNom.Text);
                    parametres.Add("prenom", this.txtPrenom.Text);
                    parametres.Add("adresse", this.txtAdresse.Text);
                    parametres.Add("ville", this.txtVille.Text);
                    parametres.Add("cp", this.txtCodePostale.Text);
                    parametres.Add("dateEmbauche", this.txtDateEmbauche.Text);
                    byte[] tabByte = wb.UploadValues(url, parametres); // envoie des donnés en post 
                    string ticket = UnicodeEncoding.UTF8.GetString(tabByte);
                    this.laSecretaire.ticket = ticket.Substring(2);// anti slash n 
                    MessageBox.Show("Ajout d'un visiteur effectué");

                }
                catch (WebException ex)
                {
                    if (ex.Response is HttpWebResponse)
                        MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());
                }
            
        }
    }
}

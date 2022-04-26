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
<<<<<<< HEAD
using System.Net;
using dllRapportVisites;
using Newtonsoft.Json;
using System.Collections.Specialized;//pour api
=======
using dllRapportVisites;
using Newtonsoft.Json;
using System.Collections.Specialized;
>>>>>>> Kaira

namespace GsbRapports
{
    /// <summary>
    /// Logique d'interaction pour ajoutFamilleWindow.xaml
    /// </summary>
    public partial class ajoutFamilleWindow : Window
    {
        private Secretaire laSecretaire;
        private WebClient wb;
        private string site;

<<<<<<< HEAD
=======


>>>>>>> Kaira
        public ajoutFamilleWindow(Secretaire laSecretaire, WebClient wb, string site)
        {
            InitializeComponent();
            this.laSecretaire = laSecretaire;
<<<<<<< HEAD
            this.site = site;
            this.wb = wb;
        }

        private void btnValider_Click_1(object sender, RoutedEventArgs e)
=======
            this.wb = wb;
            this.site = site;
        

        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
>>>>>>> Kaira
        {
            try
            {
                string url = this.site + "familles";
<<<<<<< HEAD
                NameValueCollection n = new NameValueCollection();
                n.Add("ticket", this.laSecretaire.getHashTicketMdp());
                n.Add("idFamille", txtId.Text.ToString());
                n.Add("libelle", txtLibelle.Text);
                byte[] tabByte = wb.UploadValues(url, n);
                string ticket = UnicodeEncoding.UTF8.GetString(tabByte);
                this.laSecretaire.ticket = ticket.Substring(2);//methode qui enleve les 2 derniers caracteres

                MessageBox.Show("Vous avez bien ajouté la famille");


            }
            catch (WebException exc)
            {
                if (exc.Response is HttpWebResponse)
                    MessageBox.Show(((HttpWebResponse)exc.Response).StatusCode.ToString());
            }
=======
                NameValueCollection parametres = new NameValueCollection();
                parametres.Add("ticket", this.laSecretaire.getHashTicketMdp());
                parametres.Add("idFamille", this.txtId.Text);
                parametres.Add("libelle", this.txtLibelle.Text);
                byte[] tabByte = wb.UploadValues(url, parametres); // envoie des donnés en post 
                string ticket = UnicodeEncoding.UTF8.GetString(tabByte);
                this.laSecretaire.ticket = ticket.Substring(2);// anti slash n 
                MessageBox.Show("Ajout effectué");

            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                    MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());
            }
         

>>>>>>> Kaira
        }
    }
}


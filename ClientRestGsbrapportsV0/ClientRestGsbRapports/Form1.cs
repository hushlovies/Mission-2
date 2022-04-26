using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net; // pour WbClient
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mdlGsbRapportsVisite;
using Newtonsoft.Json;          // pour la gestion du format Json
using System.Security.Cryptography;     // pour SHA1

namespace ClientRestGsbRapports
{
    public partial class Form1 : Form
    {
        private string site;
        private WebClient wb;
        private string ticket;
        public Secretaire secretaire {get;set;}
        
        public Form1()
        {
            InitializeComponent();
            this.wb = new WebClient();
            this.site = "http://localhost/restGSBSecu/";
           this.menuStrip1.Visible = false;
           
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string mdp = this.txtMdp.Text;
            string login = this.txtLogin.Text;
            string reponse; // la réponse retournée  par le serveur
            /* Création de la requête*/
            string url = this.site + "login?login=" + login;
            /*Appel à l'objet wb pour récupérer le résultat de la requête*/
            reponse = this.wb.DownloadString(url);
            /* récupération, après désérialisation et conversion*/
             this.ticket = (string)JsonConvert.DeserializeObject(reponse);
             if (this.ticket == null)
                MessageBox.Show("erreur de Login");
            else
            {
                byte[] data = new byte[160];
                /*Déclaration et construction d'un objet de hashage*/
                SHA1 sha = new SHA1CryptoServiceProvider();
                byte[] result;
                /* On ne peut hasher que des tableaux de byte, on demande donc à convertir le ticket + le mdp en tableau de byte*/
                data = System.Text.Encoding.ASCII.GetBytes(this.ticket + mdp);
                /* Le résultat du hash est récupéré dans un tableau de byte*/
                result = sha.ComputeHash(data);
                /*Enfin, on convertit le hash en string !!*/
                string hash = BitConverter.ToString(result).Replace("-", "").ToLowerInvariant();
                /*On crée la requête*/
                url = this.site + "connexion?login=" + login + "&mdp=" + hash;
                /* On récupère la réponse du serveur de type json */
                reponse = this.wb.DownloadString(url);
                /*On transforme la réponse json en objet Secrétaire!!*/
                this.secretaire  = JsonConvert.DeserializeObject<Secretaire>(reponse);

                if (this.secretaire == null)
                    MessageBox.Show("erreur de mot de passe!!");
                else
                {
                    this.lblNom.Text = "Bonjour " + this.secretaire.prenom + " " + this.secretaire.nom;
                    this.menuStrip1.Visible = true;
                }
            }
          
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

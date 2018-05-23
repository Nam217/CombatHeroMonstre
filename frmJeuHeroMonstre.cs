using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatHeroMonstre_WF
{
    public partial class frmJeuHeroMonstre : Form
    {
        public frmJeuHeroMonstre()
        {
            InitializeComponent();
            lblInfo.Text = "Le monstre attend une attaque de notre héro";
        }
        Hero hero = new Hero(50);
        int nombreMonstreTue = 0;

        private void btnCombatAuto_Click(object sender, EventArgs e)
        {
            btnHero.Enabled = false;
            lblInfo.Visible = false;
            btnCombatManuel.Enabled = false;
            btnCombatAuto.Enabled = false;
            while (hero.EstVivant)
            {
                Monstre monstre = new Monstre();
                while (monstre.EstVivant && hero.EstVivant)
                {
                    hero.AttaquerMonstre(monstre);
                    if (monstre.EstVivant)
                        monstre.AttaquerHero(hero);
                }

                if (hero.EstVivant)
                {
                    nombreMonstreTue++;
                }
            }
            
            for (int i = 0; i <= 4; i += 1)
            {
                pnlHeart.Controls[i].Visible = false;
            }   
            pnlHeart.Refresh();
            lblNbrMonstre.Text = "Notre héro a tué " + nombreMonstreTue.ToString() + " monstre(s) avant de mourir";
        }

        private void btnHero_Click(object sender, EventArgs e)
        {
            if (hero.EstVivant)
            {
                Monstre monstre = new Monstre();
                hero.AttaquerMonstre(monstre);
                if (monstre.EstVivant)
                {
                    lblInfo.Text = "Notre héro a raté le coup, le monstre contre-attaque \n\n";
                    if (monstre.AttaquerHero(hero))
                    {
                        lblInfo.Text = lblInfo.Text + "Notre héro est touché, il vient de perdre un point de vie";
                    }
                    else
                    {
                        lblInfo.Text = lblInfo.Text + "Notre héro a pu résister, il perd pas de point de vie";
                    }
                }
                else
                {
                    nombreMonstreTue++;
                    lblInfo.Text = "Le monstre est mort, un autre va venir défier notre héro";
                }
                if (hero.pointdeVies < 50)
                {
                    for (int i = 1; i <= (50 - hero.pointdeVies) / 10; i += 1)
                    {
                        pnlHeart.Controls[i - 1].Visible = false;
                    }
                    pnlHeart.Refresh();
                }
            }
            lblNbrMonstre.Text = "Notre héro a tué " + nombreMonstreTue.ToString() + " monstre(s)";
            if (hero.pointdeVies == 0)
            {
                lblNbrMonstre.Text = lblNbrMonstre.Text + " avant de mourir";
                lblInfo.Visible = false;
                btnHero.Enabled = false;
            }
                
        }

        private void btnCombatManuel_Click(object sender, EventArgs e)
        {
            btnCombatAuto.Enabled = false;
            btnCombatManuel.Enabled = false;
            btnHero.Enabled = true;
            lblInfo.Visible = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnCombatManuel.Enabled = true;
            btnCombatAuto.Enabled = true;
            for (int i = 0; i <= 4; i += 1)
            {
                pnlHeart.Controls[i].Visible = true;
            }
            hero.pointdeVies = 50;
            lblNbrMonstre.Text = "Nombre de monstres tués : 0";
            lblInfo.Text = "Le monstre attend une attaque de notre héro";
            nombreMonstreTue = 0;
        }

    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatHeroMonstre_WF
{
    class De
    {
        private Random random;

        public De()
        {
            random = new Random();
        }

        public int LancerDe()
        {
            return random.Next(1, 7);
        }
    }

    class Hero
    {
        private De de;
        public int pointdeVies { get; set; }
        public bool EstVivant
        {
            get
            {
                return pointdeVies > 0;
            }
        }

        public Hero(int pointsdeVieInitial)
        {
            pointdeVies = pointsdeVieInitial;
            de = new De();
        }

        public bool AttaquerMonstre(Monstre monstre)
        {
            if (monstre != null)
            {
                int lanceHero = LancerDe();
                int lanceMonstre = monstre.LancerDe();
                if (lanceHero >= lanceMonstre)
                {
                    monstre.EstTué();
                    return true;
                }
            }
            return false;
        }

        public int LancerDe()
        {
            return de.LancerDe();
        }

        public void SubitDegats(int degats)
        {
          pointdeVies = pointdeVies - degats;
        }

    }

    class Monstre
    {
        private const int degats = 10;
        private De de;
        public bool EstVivant { get; set; }

        public Monstre()
        {
            de = new De();
            EstVivant = true;
        }

        public void EstTué()
        {
            EstVivant = false;
        }

        public int LancerDe()
        {
            return de.LancerDe();
        }

        public bool AttaquerHero(Hero hero)
        {
            if (hero != null)
            {
                int lanceMonstre = LancerDe();
                int lanceJoueur = hero.LancerDe();
                if (lanceMonstre > lanceJoueur)
                {
                    hero.SubitDegats(degats);
                    return true;
                }
            }
            return false;
        }
    }
}

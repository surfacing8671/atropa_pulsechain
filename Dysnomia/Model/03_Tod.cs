﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Dysnomia.Domain;

namespace Dysnomia
{
    public class Tod
    {
        public ညြ Mu;
        public ညြ Psi;
        public List<ည> Nu;
        public Fa Upsilon;
        public Fa Tau;
        public Faung Theta;
        public int Gamma = 1;

        public Tod()
        {
            Mu = new ညြ(false);
            Psi = new ညြ(true);
            Nu = [Mu.Mu, Mu.Theta, Psi.Mu, Psi.Theta];
            Upsilon = Mu.Pi(Mu.Mu.Psi.Omicron);
            Tau = Psi.Pi(Psi.Theta.Mu.Omega);

            Theta = new Faung(ref Mu.Theta.Rho, ref Psi.Theta.Rho);
        }

        /*
        public Tod(ref ညြ Beta, ref Fa Omicron, ref ည Iota)
        {
            Beta.Gamma++;
            Omicron.Gamma++;
            Mu = Beta;
            Psi = new ညြ(ref Mu.Theta, ref Iota, ref Mu.Mu);
            Upsilon = Mu.Pi(Mu.Theta.Mu.Cone.Coordinate);
            Tau = Omicron;
        }
        */ 

        /*
        vector<Faung*> Affinities()
        {
            vector<Faung*> Alpha(Mu.Affinities());
            vector<Faung*> Beta = Psi.Affinities();
            Alpha.insert(Alpha.end(), Beta.begin(), Beta.end());
            return Alpha;
        }

        ~Tod()
        {
            if (Mu.Gamma == 1) delete Mu; else Mu.Gamma--;
            if (Psi.Gamma == 1) delete Psi; else Psi.Gamma--;
            if (Upsilon.Gamma == 1) delete Upsilon; else Upsilon.Gamma--;
            if (Tau.Gamma == 1) delete Tau; else Tau.Gamma--;
        }
        */
    }
}

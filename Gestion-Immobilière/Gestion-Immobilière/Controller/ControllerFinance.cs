using System;
using System.Collections.Generic;
using System.Text;
using Gestion_Immobilière.Data.DAL;
using Gestion_Immobilière.Data.Models;

namespace Gestion_Immobilière.Controller
{
    public class ControllerFinance
    {
        public double calculerRentabiliteNetMensuelGlobale()
        {
            Context ctx = new Context();
            List<Bien> biens = ctx.Biens.ToList();

            double revenuGlobal = 0;

            foreach (Bien bien in biens)
            {
                revenuGlobal = revenuGlobal + bien.calculerRentabiliteNetMensuel();
            }

            return revenuGlobal;
        }
    }
}

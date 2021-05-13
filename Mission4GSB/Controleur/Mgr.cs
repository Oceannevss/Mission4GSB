using Mission4GSB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4GSB.Controleur
{
    public class Mgr
    {
        ficheFraisDao f = new ficheFraisDao();

        public void updateCL(GestionDate d)
        {
            f.updateCL(d);
        }

        public void updateRB(GestionDate d)
        {
            f.updateRB(d);
        }
    }
}

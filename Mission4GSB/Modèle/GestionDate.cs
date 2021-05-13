using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4GSB
{
   public class GestionDate
    {
         DateTime aujourdhui = DateTime.Now;

        /// <summary>
        /// Fonction recupère la date actuelle
        /// </summary>
        /// <returns> date du jour dans le format yyyyMM </returns>
        public String dateJour()
        {
            String ajd = aujourdhui.ToString("yyyyMM");
          
            return ajd;
        }

       /// <summary>
       /// Fonction recupère la date du mois precedent de la date actuelle
       /// </summary>
       /// <returns>mois precedent dans le format yyyyMM </returns>
        public String dateMoisPrecedent()
        {
            String moisPrecedent = aujourdhui.AddMonths(-1).ToString("yyyyMM");
            

            return moisPrecedent;
        }

        /// <summary>
        /// Fonction recupère la date du mois suivant de la date actuelle
        /// </summary>
        /// <returns> mois suivant dans le format yyyyMM </returns>
        public String dateMoisSuivant()
        {
            String moisSuivant = aujourdhui.AddMonths(1).ToString("yyyyMM");

            return moisSuivant;
        }
       
    }

   
}

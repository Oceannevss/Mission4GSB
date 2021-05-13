using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4GSB.DAL
{
    class ficheFraisDao
    {
        private ConnexionSql maConnexionSql;

        private MySqlCommand myConn;

     

        public void updateCL(GestionDate date)
        {
            try
            {
                maConnexionSql = ConnexionSql.GetInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql,
                    Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                myConn = maConnexionSql.reqExec("Update fichefrais set idEtat = 'CL' where mois = " 
                    + date.dateMoisPrecedent()
                    + " and idEtat = 'CR'");

                myConn.ExecuteNonQuery();
            }
            catch (Exception emp)
            {

                throw (emp);
            }


        }

        public void updateRB(GestionDate date)
        {
            try
            {
                maConnexionSql = ConnexionSql.GetInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql
                    , Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                myConn = maConnexionSql.reqExec("Update fichefrais set idEtat = 'RB' where mois = " 
                            + date.dateMoisPrecedent()
                            + " and idEtat = 'VA'");

                myConn.ExecuteNonQuery();

            }
            catch (Exception emp)
            {

                throw (emp);
            }

        }

    }
}

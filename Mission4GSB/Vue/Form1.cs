using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mission4GSB.Controleur;

namespace Mission4GSB
{
    public partial class Form1 : Form
    {
        private ConnexionSql myConnexion;
        private MySqlCommand myConn;
        private DataTable dt;
        GestionDate date = new GestionDate();
        Mgr monManager = new Mgr();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                myConnexion = (ConnexionSql)ConnexionSql.GetInstance("localhost", "gsb_frais", "root", "");
                myConnexion.openConnection();

                myConn = myConnexion.reqExec("Select * from fichefrais where mois = "+ date.dateMoisPrecedent());

                dt = new DataTable();

                MySqlDataReader reader = myConn.ExecuteReader();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dt.Columns.Add(reader.GetName(i));
                }
                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    for (int y = 0; y < reader.FieldCount; y++)
                    {
                        dr[y] = reader.GetValue(y);
                    }
                    dt.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt;
                reader.Close();

                textBox1.Text = date.dateJour();
                textBox2.Text = date.dateMoisPrecedent();
                textBox3.Text = date.dateMoisSuivant();
            
                myConnexion.closeConnection();
            
            }catch(Exception emp)

            {
                throw (emp);
            }
           



           
        }

        /// <summary>
        /// Initialise le timer
        /// </summary>
        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.
            //86400000 = 24h
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Enable timer.  
            timer1.Enabled = true;

          
        }

        /// <summary>
        /// changement de l'etat des fiches frais en fonction de la date à chaque fois que l'intervalle du timer est passé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                myConnexion = (ConnexionSql)ConnexionSql.GetInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);
                myConnexion.openConnection();
                
                int jour = Int32.Parse(DateTime.Now.ToString("dd"));
                

                if(jour <= 10)
                {
                    monManager.updateCL(date);
                }

                if(jour >= 20)
                {
                    monManager.updateRB(date);
                }

                myConnexion.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
         }

        
    }
}

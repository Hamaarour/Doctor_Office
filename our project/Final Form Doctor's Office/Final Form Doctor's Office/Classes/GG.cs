using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Form_Doctor_s_Office.Classes
{
    public static class GG
    {
        //connection
        public static OleDbConnection cnx = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\My Projet\C# projet\Gestion cabinet\Gestion Cabinet v1.9\our project\base de donee\Database_cabinet.accdb");
        public static Data.gestion_cabinet ds = new Data.gestion_cabinet();

        // table login 
        public static OleDbDataAdapter d_log = new OleDbDataAdapter("select * from LOGIN", cnx);
        public static OleDbCommandBuilder cmd_log = new OleDbCommandBuilder(d_log);

        // table Patient 
        public static OleDbDataAdapter d_patient = new OleDbDataAdapter("select * from Patient", cnx);
        public static OleDbCommandBuilder cmd_patient = new OleDbCommandBuilder(d_patient);

        // table Medicament 
        public static OleDbDataAdapter d_medicament = new OleDbDataAdapter("select * from Medicaments", cnx);
        public static OleDbCommandBuilder cmd_medicament = new OleDbCommandBuilder(d_medicament);

        // table Ordonnance 
        public static OleDbDataAdapter d_ordonnance = new OleDbDataAdapter("select * from Ordonnance", cnx);
        public static OleDbCommandBuilder cmd_ordonnance = new OleDbCommandBuilder(d_ordonnance);

        // table Visite 
        public static OleDbDataAdapter d_visite = new OleDbDataAdapter("select * from Visite", cnx);
        public static OleDbCommandBuilder cmd_visite = new OleDbCommandBuilder(d_visite);

        // table Medicament_Patient 
        public static OleDbDataAdapter d_MO = new OleDbDataAdapter("select * from Medicament_Patient", cnx);
        public static OleDbCommandBuilder cmd_MO = new OleDbCommandBuilder(d_MO);

        // table Medicament_Patient 
        public static OleDbDataAdapter d_ville = new OleDbDataAdapter("select * from Villes", cnx);
        public static OleDbCommandBuilder cmd_ville = new OleDbCommandBuilder(d_ville);

        public static void charge() // fill des tables 
        {
            Classes.GG.ds.Visite.Clear();
            Classes.GG.ds.Patient.Clear();
            Classes.GG.ds.Medicaments.Clear();
            Classes.GG.ds.Ordonnance.Clear();
            Classes.GG.ds.Medicament_Patient.Clear();
            Classes.GG.ds.Villes.Clear();
            Classes.GG.ds.LOGIN.Clear();

            GG.d_medicament.Fill(GG.ds.Medicaments);
            GG.d_visite.Fill(GG.ds.Visite);
            GG.d_ordonnance.Fill(GG.ds.Ordonnance);
            GG.d_patient.Fill(GG.ds.Patient);
            GG.d_log.Fill(GG.ds.LOGIN);
            GG.d_MO.Fill(GG.ds.Medicament_Patient);
            GG.d_ville.Fill(GG.ds.Villes);

        }
        // id des primary key des tables
        public static string Patientid;
        public static int Visiteid;
        public static int Ordonnanceid;
        public static int Medicamentid;
        public static int Medicament_Ordonnance_id;

    }
}

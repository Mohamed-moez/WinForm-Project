using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProjet
{
    class SelectData
    {
        public static int x = 0;
        public static int ide;
        public static int idt;
        public static Widget w = new Widget();
        public static int admin=0;
        public static void Fill_Taches(GridControl GC, GridView GV)
        {
            try
            {
                MyPFAEntities dBT = new MyPFAEntities();
                var tache = (from c in dBT.Tache  select c).ToList();
                GC.DataSource = tache;
                dBT.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                //LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static void Fill_Emp(GridControl GC, GridView GV)
        {
            try
            {
                MyPFAEntities dBE = new MyPFAEntities();
                var emp = (from c in dBE.Employe  select c).ToList();
                GC.DataSource = emp;
                dBE.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                //LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static void Fill_Projets(GridControl GC, GridView GV)
        {
            try
            {
                MyPFAEntities dBP = new MyPFAEntities();
                var p = (from c in dBP.Projets  select c).ToList();
                GC.DataSource = p;
                dBP.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                //LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static void select_tache_emp(GridControl GC, GridView GV,int id)
        {


            MyPFAEntities dBT = new MyPFAEntities();

                var p = (from c in dBT.Tache where c.idEmp==id select c).ToList();
                        GC.DataSource = p;
                        dBT.Database.Connection.Close();

        }
        public static String mail(String ida)
        {
            String mail;
            MyPFAEntities dBT = new MyPFAEntities();
            return mail = (from c in dBT.Employe where c.code == ida select c.mail).FirstOrDefault();
        }

        public static void Fill_P(GridControl GC, GridView GV ,int id)
        {
            try
            {
                MyPFAEntities dBP = new MyPFAEntities();
                var p = (from t in dBP.Pointage join e in dBP.Employe on t.idEmp equals e.IdEmp where t.idEmp == id select t).ToList();
                GC.DataSource = p;
                dBP.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                //LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static String nom_tache (int ida)
        {
            String nom;
            MyPFAEntities dBT = new MyPFAEntities();
           return  nom = (from c in dBT.Tache where c.IdTache ==ida select c.nomTache).FirstOrDefault();
        }
        

    }


}

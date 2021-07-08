using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProjet
{
    class UpdateData
    {


        public static void updateEmp(int id,int admin, String code, String nom, String prenom, String mdp,String mail)
        {
            try
            {
                MyPFAEntities db = new MyPFAEntities();
                var op = (from c in db.Employe where c.IdEmp == id select c).FirstOrDefault();
                op.nom = nom;
                op.prenom = prenom;
                op.admin = admin;
                op.mail = mail;
                db.SaveChanges();
                db.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static void updateTache(int id, int idEmp, int idP, String nom, String desc,String type,String statue,String prio,Int16  ave,String dateD,String dateF)
        {
            try
            {
                MyPFAEntities db = new MyPFAEntities();
                var op = (from c in db.Tache where c.IdTache == id select c).FirstOrDefault();
                op.nomTache = nom;
                op.descTache = desc;
                op.idEmp = idEmp;
                op.idProjet = idP;
                op.type = type;
                op.status = statue;
                op.priorite = prio;
                op.proggre = ave;
                op.dateD = dateD;
                op.dateF = dateF;
                db.SaveChanges();
                db.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static void updateProjet( int code, String nom, String desc)
        {
            try
            {
                MyPFAEntities db = new MyPFAEntities();
                var op = (from c in db.Projets where c.IdProjet == code select c).FirstOrDefault();
                op.nomProjet = nom;
                op.descProjet = desc;
            
                db.SaveChanges();
                db.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }



        }

    }
}
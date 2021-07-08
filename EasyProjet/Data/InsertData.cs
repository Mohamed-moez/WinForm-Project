using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProjet
{
    class InsertData
    {
        public static void InsertEmp(String nom, String prenom,String code ,String mdp, int admin,String mail)
        {

            try
            {
                MyPFAEntities db = new MyPFAEntities();
                Employe emp = new Employe();
                
                    emp.nom = nom;
                    emp.prenom = prenom;
                    emp.code = code;
                    emp.mdp = mdp;
                    emp.admin = admin;
                    emp.mail = mail;
                    db.Employe.Add(emp);
                    db.SaveChanges();
                    db.Database.Connection.Close();
                
            }
            catch (Exception ex)
            {
               // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static void InsertTache(String nom, String desc, int idEmp, int idP,String type, String statue, String prio, int ave, String dateD, String dateF)
        {
            try
            {
                MyPFAEntities db = new MyPFAEntities();
                 Tache Tache = new Tache();
                
                
                Tache.nomTache = nom;
                Tache.descTache = desc;
                Tache.idEmp = idEmp;
                Tache.idProjet = idP;
                Tache.type = type;
                Tache.status = statue;
                Tache.priorite = prio;
                Tache.proggre = ave;
                Tache.dateD = dateD;
                Tache.dateF = dateF;
                db.Tache.Add(Tache);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }


        public static void InsertProjet(String nom, String desc )
        {
            try
            {
                MyPFAEntities db = new MyPFAEntities();
                Projets projet = new Projets();
                projet.descProjet = desc;
                projet.nomProjet = nom;

                
                db.Projets.Add(projet);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static void Insert_Hist_Session(String ov, int id)
        {
            try
            {
                MyPFAEntities db = new MyPFAEntities();
                Pointage po = new Pointage();
                po.ouverture_Session = ov;
                po.idEmp = id;
                db.Pointage.Add(po);
                db.SaveChanges();
                db.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

       public static void Insert_Hist_tache(String ot,int idh,int idt)
        {
            try
            {
                MyPFAEntities db = new MyPFAEntities();
                var po = (from c in db.Pointage where c.IdPointage == idh select c).FirstOrDefault();               
                    po.lance_tache = ot;
                po.tache = idt;
                    db.SaveChanges();
                    db.Database.Connection.Close();
                
            }
            catch (Exception ex) 
            {
                // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static void Insert_Hist_fTache(String ot, int id,int tmp)
        {
            try
            {
                MyPFAEntities db = new MyPFAEntities();
                var po = (from c in db.Pointage where c.IdPointage== id select c).FirstOrDefault();
                
                po.ferme_tache = ot;
                po.tempTache = tmp;

                db.SaveChanges();
                db.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
              // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static void Insert_Hist_fSession(String ot, int id)
        {
            try
            {
                MyPFAEntities db = new MyPFAEntities();
                var po = (from c in db.Pointage where c.IdPointage == id select c).FirstOrDefault();
                po.fermeture_session = ot;

                db.SaveChanges();
                db.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        public static void Insert_temp_tache(int idh, int idt)
        {
            int? somme = 0;
            try
            {
                MyPFAEntities db = new MyPFAEntities();
                var p = (from c in db.Pointage where c.tache == idh select c.tempTache).ToList();
                 somme = p.Sum();
                var pt = (from c in db.Tache where c.IdTache == idt select c).FirstOrDefault();
                pt.temp = somme;
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

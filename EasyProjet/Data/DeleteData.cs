using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProjet
{
    class DeleteData
    {
        public static void DeleteTache(int id)
        {

            MyPFAEntities dl = new MyPFAEntities();
                try
                {
                    var ech = (from c in dl.Tache where c.IdTache == id select c).FirstOrDefault();
                    if (ech != null)
                    {
                        dl.Tache.Remove(ech);
                        dl.SaveChanges();
                    }
                    dl.Database.Connection.Close();
                }
                catch (Exception ex)
                {
                  //  LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
                }
            
        }

        public static void DeleteEmp(int id)
        {

            MyPFAEntities dl = new MyPFAEntities();
            try
            {
                var ech = (from c in dl.Employe where c.IdEmp == id select c).FirstOrDefault();
                if (ech != null)
                {
                    dl.Employe.Remove(ech);
                    dl.SaveChanges();
                }
                dl.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                //  LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }

        }

        public static void DeleteProjet(int id)
        {

            MyPFAEntities dl = new MyPFAEntities();
            try
            {
                var ech = (from c in dl.Projets where c.IdProjet == id select c).FirstOrDefault();
                if (ech != null)
                {
                    dl.Projets.Remove(ech);
                    dl.SaveChanges();
                }
                dl.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                //  LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }

        }
    }
}

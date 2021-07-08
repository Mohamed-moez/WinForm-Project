using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;

namespace EasyProjet
{
    public partial class ModifTache : DevExpress.XtraEditors.XtraForm
    {
        private int _cbMarq;
        
        public ModifTache( int cbmarq )
        {
            InitializeComponent();
            _cbMarq = cbmarq;
            

        }

        private void valModif_Click(object sender, EventArgs e)
        {
            UpdateData.updateTache(_cbMarq, int.Parse(text_id_emp.Text), int.Parse(text_id_Projet.Text),text_Nom_Tache.Text,textDesc.Text,type.Text,statue.Text,Prio.Text, Convert.ToInt16(avancement.Text),dateD.Text.ToString(),dateF.Text.ToString());
            XtraMessageBox.Show("Modification validé !");
            this.Hide();
        }

        private void ModifTache_Load(object sender, EventArgs e)
        {
            String user = ConfigurationManager.AppSettings["user"];
            MyPFAEntities db = new MyPFAEntities();
            //int id = (from c in db.Employe where c.Code == user select c.admin).FirstOrDefault();
            
            if (SelectData.admin==1)
            {
                text_id_emp.Enabled = false;
                text_id_Projet.Enabled = false;
                text_Nom_Tache.Enabled = false;
                textDesc.Enabled = false;
                Prio.Enabled = false;
                statue.Enabled = false;
                type.Enabled = false;
                dateD.Enabled = false;
                dateF.Enabled = false;
            }
            LoadData();

        }
        private void LoadData()
        {
            MyPFAEntities dbStr = new MyPFAEntities();

            try
            {
                if (_cbMarq > 0)
                {

                    var emp = dbStr.Tache.FirstOrDefault(d => d.IdTache == _cbMarq);

                    text_Nom_Tache.Text = emp.nomTache;
                    textDesc.Text = emp.descTache;
                    Fill_Cmb_Projet(text_id_Projet);
                    Fill_Cmb_Emp(text_id_emp);
                    text_id_emp.Text = emp.idEmp.ToString();
                    text_id_Projet.Text = emp.idProjet.ToString();
                    type.Text = emp.type;
                    statue.Text = emp.status;
                    Prio.Text = emp.priorite;
                    avancement.Text = emp.proggre.ToString();
                }

                dbStr.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                //LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
                //dbStr.Database.Connection.Close();

            }
        }


        private void Fill_Cmb_Emp(ComboBoxEdit cmb)
        {
            try
            {
                MyPFAEntities db_MyEasyERP = new MyPFAEntities();
                var grid = from c in db_MyEasyERP.Employe select c;
                List<Employe> lstProjet = grid.ToList();
                cmb.Properties.Items.Clear();
                foreach (var qual in lstProjet)
                {
                    cmb.Properties.Items.Add(qual.code);
                }
                db_MyEasyERP.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }
        private void Fill_Cmb_Projet(ComboBoxEdit cmb)
        {

            MyPFAEntities db_MyEasyERP = new MyPFAEntities();
            var grid = from c in db_MyEasyERP.Projets select c;
            List<Projets> lstProjet = grid.ToList();
            cmb.Properties.Items.Clear();
            foreach (var qual in lstProjet)
            {
                cmb.Properties.Items.Add(qual.nomProjet);
            }
            db_MyEasyERP.Database.Connection.Close();
        }

        private void annModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
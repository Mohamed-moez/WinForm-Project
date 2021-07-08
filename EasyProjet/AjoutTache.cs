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

namespace EasyProjet
{
    public partial class AjoutTache : DevExpress.XtraEditors.XtraForm
    {
        
        private int _cbMarq;
        public AjoutTache(int cbMarq)
        {
            InitializeComponent();
            _cbMarq = cbMarq;
        }

      
        private void Fill_Cmb_Emp(ComboBoxEdit cmb )
        {

            MyPFAEntities db_MyEasyERP = new MyPFAEntities();
                var grid = from c in db_MyEasyERP.Employe where c.admin == 1 select c;
                List<Employe> lstProjet = grid.ToList();
                cmb.Properties.Items.Clear();
                foreach (var qual in lstProjet)
                {
                    cmb.Properties.Items.Add(qual.IdEmp);
                }
                db_MyEasyERP.Database.Connection.Close();
            }

        private void Fill_Cmb_Projet(ComboBoxEdit cmb)
        {

            MyPFAEntities db_MyEasyERP = new MyPFAEntities();
            var grid = from c in db_MyEasyERP.Projets  select c;
            List<Projets> lstProjet = grid.ToList();
            cmb.Properties.Items.Clear();
            foreach (var qual in lstProjet)
            {
                cmb.Properties.Items.Add(qual.IdProjet);
            }
            db_MyEasyERP.Database.Connection.Close();
        }

        private void valAj_Click(object sender, EventArgs e)
        {
            
            if (_cbMarq == 0)
            {
                int idEmp, idP, a;
                int.TryParse(text_id_emp.Text, out idEmp);
                int.TryParse(text_id_projet.Text, out idP);
                int.TryParse(ave.Text, out a);
                InsertData.InsertTache(text_nom_tache.Text, text_desc.Text, Convert.ToInt16(text_id_emp.Text), Convert.ToInt16(text_id_projet.Text), type.Text, statue.Text, prio.Text, Convert.ToInt16(ave.Text), dateD.Text, dateF.Text);
                XtraMessageBox.Show("ajout validé !");
               

            }
           
          
        }

        private void AjoutTache_Load_1(object sender, EventArgs e)
        {
            Fill_Cmb_Emp(text_id_emp);
            Fill_Cmb_Projet(text_id_projet);
            text_id_emp.SelectedIndex = 0;
            text_id_projet.SelectedIndex = 0;
            if (_cbMarq > 0)
            {
            //Load

            }
           
        }

        private void annAj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
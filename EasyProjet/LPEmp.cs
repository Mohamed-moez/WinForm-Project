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
    public partial class LPEmp : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public LPEmp()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmb_user.Text);
            Historique h = new Historique(id);
            h.Show();
        }

        private void LPEmp_Load(object sender, EventArgs e)
        {
            Fill_Cmb_ProtUsers(cmb_user);
            cmb_user.SelectedIndex = 0;
        }

        private void Fill_Cmb_ProtUsers(ComboBoxEdit cmb)
        {
            try
            {
                MyPFAEntities db_MyEasyERP = new MyPFAEntities();
                var grid = from c in db_MyEasyERP.Employe where c.admin==1 select c;
                List<Employe> lstProjet = grid.ToList();
                cmb.Properties.Items.Clear();
                foreach (var qual in lstProjet)
                {
                    cmb.Properties.Items.Add(qual.IdEmp);
                }
                db_MyEasyERP.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
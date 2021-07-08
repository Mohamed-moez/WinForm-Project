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
    public partial class ModifEmp : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _cbMarq;
        public ModifEmp(int cbMarq)
        {
            InitializeComponent();
            _cbMarq = cbMarq;
        }

        private void LoadData()
        {
            MyPFAEntities dbStr = new MyPFAEntities();

            try
            {
                if (_cbMarq > 0)
                {

                    var emp = dbStr.Employe.FirstOrDefault(d => d.IdEmp == _cbMarq);

                    text_nom.Text = emp.nom;
                    text_prenom.Text = emp.prenom;
                    txtName.Text = emp.mail;
                    text_mdp.Text = emp.mdp;
                    text_code.Text = emp.code;





                }

                dbStr.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                //LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
                //dbStr.Database.Connection.Close();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UpdateData.updateEmp(_cbMarq, Convert.ToInt16(radioGroup1.SelectedIndex), text_code.Text, text_nom.Text, text_prenom.Text, text_mdp.Text,txtName.Text);
            XtraMessageBox.Show("Modification validé !");
            this.Hide();
            ListeEmp emp = new ListeEmp();
            emp.LoadData();
        }

        private void ModifEmp_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
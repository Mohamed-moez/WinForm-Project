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
    public partial class ModifProjet : DevExpress.XtraEditors.XtraForm
    {
        private int _cbMarq;
        public ModifProjet(int cbMarq)
        {
            InitializeComponent();
            _cbMarq = cbMarq;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            UpdateData.updateProjet(_cbMarq,text_nom.Text,text_desc.Text);
            XtraMessageBox.Show("Modification validé !");
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadData()
        {
            MyPFAEntities dbStr = new MyPFAEntities();

            try
            {
                if (_cbMarq > 0)
                {

                    var emp = dbStr.Projets.FirstOrDefault(d => d.IdProjet == _cbMarq);

                    text_nom.Text = emp.nomProjet;
                    text_desc.Text = emp.descProjet;
                   
                }

                dbStr.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                //LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
                //dbStr.Database.Connection.Close();

            }
        }
        private void ModifProjet_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
    
}
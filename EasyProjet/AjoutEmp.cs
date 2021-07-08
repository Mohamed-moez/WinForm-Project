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
    public partial class AjoutEmp : DevExpress.XtraEditors.XtraForm
    {

        public AjoutEmp()
        {
            InitializeComponent();
        }

      

        private void valAjout_Click(object sender, EventArgs e)
        {                   
            InsertData.InsertEmp(nom.Text, prenom.Text,code.Text, mdp.Text, Convert.ToInt16(radioGroup1.SelectedIndex),txtMail.Text);
            
            XtraMessageBox.Show("ajout validé !");
        }

        private void AjoutEmp_Load(object sender, EventArgs e)
        {
            
        }

       

        private void nom_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void annAjout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
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
    public partial class AjoutProjet : DevExpress.XtraEditors.XtraForm
    {
        public AjoutProjet()
        {
            InitializeComponent();
        }

        private void btn_aj_Click(object sender, EventArgs e)
        {

            InsertData.InsertProjet(nomP.Text, desc.Text);
            XtraMessageBox.Show("ajout validé !");
        }

    }
}
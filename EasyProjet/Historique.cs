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
    public partial class Historique : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public Historique(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Historique_Load(object sender, EventArgs e)
        {
            SelectData.Fill_P(GC_H, GV_H, id);
        }

        private void GC_H_Click(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class ListeProjet : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListeProjet()
        {
            InitializeComponent();
        }

        private void GC_P_Click(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            SelectData.Fill_Projets(GC_P, GV_P);
        }
        private void ListeProjet_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = (int)GV_P.GetRowCellValue(GV_P.FocusedRowHandle, "IdProjet");
            DeleteData.DeleteProjet(id);
            LoadData();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = (int)GV_P.GetRowCellValue(GV_P.FocusedRowHandle, "IdProjet");
            ModifProjet mp = new ModifProjet(id);
            mp.ShowDialog();
            LoadData();

        }

        private void GV_P_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)GV_P.GetRowCellValue(GV_P.FocusedRowHandle, "IdProjet");
            ModifProjet mp = new ModifProjet(id);
            mp.ShowDialog();
            LoadData();
        }
    }
}
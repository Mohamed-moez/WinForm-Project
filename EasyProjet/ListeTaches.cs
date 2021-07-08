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
using DevExpress.XtraEditors.Repository;

namespace EasyProjet
{
    public partial class ListeTaches : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListeTaches()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
           
        }
        public void LoadData()
        {
            SelectData.Fill_Taches(GC_taches, GV_taches);
            RepositoryItemProgressBar ritem = new RepositoryItemProgressBar();
            ritem.Minimum = 0;
            ritem.Maximum = 100;
            GV_taches.Columns["proggre"].ColumnEdit = ritem;
            ritem.LookAndFeel.UseDefaultLookAndFeel = false;

            ritem.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            ritem.StartColor = Color.DarkCyan;
            ritem.EndColor = Color.LightCyan;
            ritem.PercentView = true;
        }
        private void ListeTaches_Load(object sender, EventArgs e)
        {

            LoadData();



        }

      

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int id = (int)GV_taches.GetRowCellValue(GV_taches.FocusedRowHandle, "IdTache");
            DeleteData.DeleteTache(id);
            LoadData();



        }

        private void GV_taches_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)GV_taches.GetRowCellValue(GV_taches.FocusedRowHandle, "IdTache");

            ModifTache mt = new ModifTache(id);

            mt.Show();
            LoadData();
        }
    }
}
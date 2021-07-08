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
    public partial class ListeEmp : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public ListeEmp()
        {
            InitializeComponent();
            
        }

        private void GC_emp_Click(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            SelectData.Fill_Emp(GC_emp, GV_emp);
        }
        private void ListeEmp_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = (int)GV_emp.GetRowCellValue(GV_emp.FocusedRowHandle, "IdEmp");
            DeleteData.DeleteEmp(id);
            LoadData();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = (int)GV_emp.GetRowCellValue(GV_emp.FocusedRowHandle, "IdEmp");
            ModifEmp me = new ModifEmp(id);
            me.ShowDialog();
            LoadData();
        }

        private void GV_emp_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)GV_emp.GetRowCellValue(GV_emp.FocusedRowHandle, "IdEmp");
            ModifEmp me = new ModifEmp(id);
            me.ShowDialog();
            LoadData();
        }
    }
}
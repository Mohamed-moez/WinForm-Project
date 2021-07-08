using System;
using System.Drawing;
using System.Configuration;
using DevExpress.XtraEditors.Repository;

namespace EasyProjet
{
    public partial class IntEmp : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public int i = 0;
        public static IntEmp ie = new IntEmp();
        private int idTache;
        
        public int val1=0 ;
        public static Widget w = new Widget();
        public IntEmp(int cbmarq)
        {
            InitializeComponent();
          this.idTache = cbmarq;
                

        }
        public IntEmp()
        {
            InitializeComponent();
            
        }


        private void GC_intEmp_Click(object sender, EventArgs e)
        {   
        }

        public void LoadData()
        {
            SelectData.select_tache_emp(GC_intEmp, GV_intEmp, idTache);
            RepositoryItemProgressBar ritem = new RepositoryItemProgressBar();           
            ritem.Minimum = 0;
            ritem.Maximum = 100;
            GV_intEmp.Columns["proggre"].ColumnEdit = ritem;
            ritem.LookAndFeel.UseDefaultLookAndFeel = false;

            ritem.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            ritem.StartColor = Color.DarkCyan;
            ritem.EndColor = Color.LightCyan;
            ritem.PercentView = true;
        }
        private void IntEmp_Load(object sender, EventArgs e)
        {
            LoadData();
        }

     
        
        private void barStaticItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(@"EasyProjet.exe");
            config.AppSettings.Settings.Remove("user");
            config.AppSettings.Settings.Remove("pwd");

            config.AppSettings.Settings.Add("user", "");
            config.AppSettings.Settings.Add("pwd", "");

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            Cnx c = new Cnx(ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["pwd"]);
            c.val = 1;
            c.Show();
            this.Hide();
        }

       

       

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int val = int.Parse(sec.Text) + 1;
            sec.Text = val.ToString();
            if (val == 60)
            {
                sec.Text = "0";
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int val = int.Parse(min.Text) + 1;
            min.Text = val.ToString();
            if (val == 60)
            {
                min.Text = "0";
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int val = int.Parse(hh.Text) + 1;
            hh.Text = val.ToString();
        }

        private void GV_intEmp_Click(object sender, EventArgs e)
        {
           
        }

       

       

        private void toggleSwitch1_EditValueChanged(object sender, EventArgs e)
        {
        if(Convert.ToBoolean(toggleSwitch1.EditValue) == true)
            {
                timer6.Start();
                timer5.Start();
                timer4.Start();
                timer7.Stop();
                timer7.Start();
                sec.Text = "0";
                min.Text = "0";
                hh.Text = "0";
                SelectData.idt = (int)GV_intEmp.GetRowCellValue(GV_intEmp.FocusedRowHandle, "IdTache");

               InsertData.Insert_Hist_tache(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"), SelectData.ide, SelectData.idt);

                 nom.Text = SelectData.nom_tache(SelectData.idt);
            }
            else
            {
                timer5.Stop();
                timer4.Stop();
                timer6.Stop();
                timer7.Stop();
                sec.Text = "0";
                min.Text = "0";
                hh.Text = "0";
                InsertData.Insert_Hist_fTache(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"), SelectData.ide, i / 60);
                InsertData.Insert_temp_tache(SelectData.idt, SelectData.idt);
                LoadData();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            i++;
        }

        private void GV_intEmp_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)GV_intEmp.GetRowCellValue(GV_intEmp.FocusedRowHandle, "IdTache");
            ModifTache mt = new ModifTache(id);
            mt.ShowDialog();
            LoadData();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(@"EasyProjet.exe");
            config.AppSettings.Settings.Remove("user");
            config.AppSettings.Settings.Remove("pwd");

            config.AppSettings.Settings.Add("user", "");
            config.AppSettings.Settings.Add("pwd", "");

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            Cnx c = new Cnx(ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["pwd"]);
            c.val = 1;
            c.Show();
            this.Hide();
           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Mails lpem = new Mails();
           
            lpem.Show();
        }
    }
}
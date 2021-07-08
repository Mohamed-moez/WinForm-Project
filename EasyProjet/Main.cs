using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Configuration;

namespace EasyProjet
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public Main()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListeTaches lst = new ListeTaches();
                lst.MdiParent = this;
           
            lst.Show();
            lst.BringToFront();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            MyPFAEntities dBT = new MyPFAEntities();
            var emp = (from c in dBT.Employe select c.code).ToList();

            foreach (string ep in emp)
            {
                BarListItem tb = new BarListItem();
                tb.Caption = ep;
                



            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
           /* ModifTache mod = new ModifTache() { MdiParent = M };
            mod.Show();
            mod.BringToFront();*/
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            AjoutTache aj = new AjoutTache(0);
            aj.MdiParent = this;
            aj.Show();
            aj.BringToFront();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            AjoutEmp aj = new AjoutEmp();
            aj.MdiParent = this;
            aj.Show();
            aj.BringToFront();
        }

        private void barButtonItem1_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            ListeEmp le = new ListeEmp();
            le.MdiParent = this;
            le.Show();

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListeProjet lp = new ListeProjet();
            lp.MdiParent = this;
            lp.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            AjoutProjet ap = new AjoutProjet();
            ap.MdiParent = this;
            ap.Show();
        }

      

       

       

        private void barStaticItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            LPEmp lpem = new LPEmp();
            lpem.MdiParent = this;
            lpem.Show();
            
        }

       

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Cnx c = new Cnx(ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["pwd"]);
        //    c.Show();
        //    this.Hide();
        //}

        private void barStaticItem3_ItemClick_1(object sender, ItemClickEventArgs e)

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

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Mails lpem = new Mails();
            
            lpem.Show();
        }
    }
}
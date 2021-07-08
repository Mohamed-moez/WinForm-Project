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
using System.Configuration;
using System.Threading;

namespace EasyProjet
{
    public partial class Widget : DevExpress.XtraEditors.XtraForm
    {
        int x=0;
        String user = ConfigurationManager.AppSettings["user"];
        
        //public static object Widget
        String ov;
        public static Widget ww = new Widget();
        int i = 0;
        public static int val = 0;
        public static int val1 = 0;
        public static int val2 = 0;
        

        
        public Widget()
        {
            InitializeComponent();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(@"EasyProjet.exe");
            Cnx c = new Cnx(ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["pwd"]);
            c.Show();
            


          
        


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int ch = int.Parse(sec.Text) + 1;
            sec.Text = ch.ToString();
            if (ch == 60)
            {
                sec.Text = "0";

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int ch = int.Parse(min.Text) + 1;
            min.Text = ch.ToString();
            if (ch == 60)
            {
                min.Text = "0";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int ch = int.Parse(lay_h.Text) + 1;
            //lay_h.Text = ch.ToString();

        }
        public void LoadData()
        {
            //SelectData.w = 
            String user = ConfigurationManager.AppSettings["user"];
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width - 5,
                                      workingArea.Bottom - Size.Height - 5);

            if (user != "")
            {
                MyPFAEntities db = new MyPFAEntities();
                Pointage po = new Pointage();
                int id = (from c in db.Employe where c.code == user select c.IdEmp).FirstOrDefault();
                po.ouverture_Session = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
                //ov = po.ouverture_Session;
                db.Pointage.Add(po);
                po.idEmp = id;
                db.SaveChanges();
                db.Database.Connection.Close();
                SelectData.ide = po.IdPointage;
                MyPFAEntities dBE = new MyPFAEntities();
                String nom = (from c in dBE.Employe where c.code == user select c.nom).FirstOrDefault();
                String prenom = (from c in dBE.Employe where c.code == user select c.prenom).FirstOrDefault();

                pre.Text = prenom;
                nome.Text = nom;

               


            }
        }

        
        private void Widget_Load(object sender, EventArgs e)
        {
           
            LoadData();
           

        }

      

       

      

        private void Widget_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (user != "")
            {
                //fermeture session
                MyPFAEntities db = new MyPFAEntities();
                var po = (from c in db.Pointage where c.IdPointage == SelectData.ide select c).FirstOrDefault();
                po.fermeture_session = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");

                db.SaveChanges();
                db.Database.Connection.Close();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            

            i++;

            

        }

        private void Widget_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {


            //String pos = Convert.ToString(Cursor.Position);
            //Thread.Sleep(1000);

            //if (pos == Convert.ToString(Cursor.Position))
            //{
            //    //MessageBox.Show(pos);
            //    // MessageBox.Show(Convert.ToString(Cursor.Position));
            //    x++;

            //}
            //else
            //{
            //    x = 0;


            //}
            //if (x == 10)
            //{
            //    x = 0; MessageBox.Show("barra e5dem");

            //}


        }
    }
}
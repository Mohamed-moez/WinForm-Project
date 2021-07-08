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
using EasyProjet.Data;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;


namespace EasyProjet
{
    public partial class Cnx : DevExpress.XtraEditors.XtraForm
    {
       

        private String user,pass;
        public int val = 0;
       
        public Cnx(String user,String pass)
        {
            InitializeComponent();
            this.user = user;
            this.pass = pass;
        }
       



        private void Cnx_Load(object sender, EventArgs e)
        {
            try
            {
               
                Fill_Cmb_ProtUsers(Cmb_user);
                Cmb_user.SelectedIndex = 0;
                Cmb_user.Text = user;
                pwd.Text = pass;
                
                if (user != "")
                {
                    if (VerifyLogin(Cmb_user.Text, pwd.Text))
                    {
                        if (VerifyAdmin(Cmb_user.Text) == 0)
                        {
                            if (val == 0)
                            {

                                if (checkEdit.Checked)
                            {

                                Configuration config = ConfigurationManager.OpenExeConfiguration(@"EasyProjet.exe");

                                config.AppSettings.Settings.Remove("user");
                                config.AppSettings.Settings.Remove("pwd");

                                config.AppSettings.Settings.Add("user", Cmb_user.Text);
                                config.AppSettings.Settings.Add("pwd", pwd.Text);

                                config.Save(ConfigurationSaveMode.Modified);
                                ConfigurationManager.RefreshSection("appSettings");
                                XtraMessageBox.Show(ConfigurationManager.AppSettings["user"] + "," + ConfigurationManager.AppSettings["pwd"]);


                            }

                            this.Close();
                            Main m = new Main();
                            m.Show();
                                
                                

                        }
                        }
                        else
                        {
                            if (val == 0)
                            {
                                if (checkEdit.Checked)
                                {
                                    Configuration config = ConfigurationManager.OpenExeConfiguration(@"EasyProjet.exe");

                                    config.AppSettings.Settings.Remove("user");
                                    config.AppSettings.Settings.Remove("pwd");

                                    config.AppSettings.Settings.Add("user", Cmb_user.Text);
                                    config.AppSettings.Settings.Add("pwd", pwd.Text);

                                    config.Save(ConfigurationSaveMode.Modified);
                                    ConfigurationManager.RefreshSection("appSettings");
                                    //XtraMessageBox.Show(ConfigurationManager.AppSettings["user"] + "," + ConfigurationManager.AppSettings["pwd"]);


                                }

                                MyPFAEntities dBE = new MyPFAEntities();
                                 int id = (from c in dBE.Employe where c.code == Cmb_user.Text select c.IdEmp).FirstOrDefault();

                                this.Close();
                                IntEmp m = new IntEmp(id);
                                m.Show();
                                



                            }
                        }
                    }

                }
                
            }
            catch (Exception ex)
            {
                //LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
                // return false;
            }
        }

        private void Fill_Cmb_ProtUsers(ComboBoxEdit cmb)
        {
            try
            {
                MyPFAEntities db_MyEasyERP = new MyPFAEntities();
                var grid = from c in db_MyEasyERP.Employe select c;
                List<Employe > lstProjet = grid.ToList();
                cmb.Properties.Items.Clear();
                foreach (var qual in lstProjet)
                {
                    cmb.Properties.Items.Add(qual.code);
                }
                db_MyEasyERP.Database.Connection.Close();
            }
            catch (Exception ex)
            {
               // LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }
        private void connecter()
        {
            String mail = SelectData.mail(Cmb_user.Text);

            MyPFAEntities dBE = new MyPFAEntities();
            if (VerifyLogin(Cmb_user.Text, pwd.Text))
            {
                if (VerifyAdmin(Cmb_user.Text) == 0)
                {
                    if (checkEdit.Checked)
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(@"EasyProjet.exe");

                        config.AppSettings.Settings.Remove("user");
                        config.AppSettings.Settings.Remove("pwd");
                        config.AppSettings.Settings.Remove("mail");

                        config.AppSettings.Settings.Add("user", Cmb_user.Text);
                        config.AppSettings.Settings.Add("pwd", pwd.Text);
                        config.AppSettings.Settings.Add("mail", mail);

                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                        //XtraMessageBox.Show(ConfigurationManager.AppSettings["user"] + "," + ConfigurationManager.AppSettings["pwd"]);


                    }
                    this.Hide();
                    Main m = new Main();
                    m.Show();
                }
                else
                {
                    if (checkEdit.Checked)
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(@"EasyProjet.exe");

                        config.AppSettings.Settings.Remove("user");
                        config.AppSettings.Settings.Remove("pwd");
                        config.AppSettings.Settings.Remove("mail");

                        config.AppSettings.Settings.Add("user", Cmb_user.Text);
                        config.AppSettings.Settings.Add("pwd", pwd.Text);
                        config.AppSettings.Settings.Add("mail", mail);

                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                        //XtraMessageBox.Show(ConfigurationManager.AppSettings["user"] + "," + ConfigurationManager.AppSettings["pwd"]);


                    }


                    int id = (from c in dBE.Employe where c.code == Cmb_user.Text select c.IdEmp).FirstOrDefault();

                    String nom = (from c in dBE.Employe where c.code == Cmb_user.Text select c.nom).FirstOrDefault();


                    this.Hide();
                    IntEmp m = new IntEmp(id);
                    m.Show();
                   
                }

            }

            int administrateur = Convert.ToInt16((from c in dBE.Employe where c.code == Cmb_user.Text select c.admin).FirstOrDefault());
            SelectData.admin = administrateur;

        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            connecter();
        }
        public static bool VerifyLogin(string login, string pwd)
        {
            MyPFAEntities db_MyEasyERP = new MyPFAEntities();
            try
            {
                Boolean resultat = false;
                int c = Convert.ToInt32((from d in db_MyEasyERP.Employe where d.code == login select d.IdEmp).Count());
                if (c == 0)
                {
                    XtraMessageBox.Show("vérifiez Login!!");
                    resultat = false;
                }
                var log = (from d in db_MyEasyERP.Employe where d.code == login select d).FirstOrDefault();                                           
                    if (log.mdp != pwd)
                    {
                        resultat = false;
                    XtraMessageBox.Show("vérifiez Login!!");

                }
                    else
                    {
                        resultat = true;
                    }

                
                return resultat;
            }
            catch (Exception ex)
            {
                //LogsEvents.CreateEventError(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
                return false;
            }
        }

        public static int? VerifyAdmin(string login)
        {
            MyPFAEntities db_MyEasyERP = new MyPFAEntities();
           
                
                int? c = (from d in db_MyEasyERP.Employe where d.code == login select d.admin).FirstOrDefault();

            return c;
               

               
           
        }

        private void pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                connecter();
            }
        }

        
    }
}



    

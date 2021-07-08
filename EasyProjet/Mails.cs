using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace EasyProjet
{
    public partial class Mails : DevExpress.XtraEditors.XtraForm
    {
        public Mails()
        {
            InitializeComponent();
        }

        private void users_Click(object sender, EventArgs e)
        {

        }

       

        private void Mails_Load(object sender, EventArgs e)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(@"EasyProjet.exe");
            textEdit1.Text= ConfigurationManager.AppSettings["mail"];
            MyPFAEntities dBT = new MyPFAEntities();
            var emp= (from c in dBT.Employe select c.code).ToList();

            foreach (  string ep in emp)
            {
                TextBox tb = new TextBox();
                tb.Text = ep;
                users.DropDownItems.Add(ep);
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress(textEdit1.Text);
                Msg.To.Add(new MailAddress("moez.mohamed33@gmail.com"));
                Msg.Subject = textEdit3.Text;
                Msg.Body = textEdit4.Text;
                if (txtFilePath.Text != " ")
                {
                    Attachment pj = new Attachment(txtFilePath.Text);
                    Msg.Attachments.Add(pj); }
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                NetworkCredential cred = new NetworkCredential("moez.mohamed33@gmail.com", "admin95894328");
               
                client.Credentials = cred;
                client.EnableSsl = true;

                client.Send(Msg);
            }
            catch (Exception ex)  
    {
        MessageBox.Show(ex.ToString());
    }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                String fileP = openFileDialog1.FileName;
                txtFilePath.Text = fileP;
            }
        }
    }
}

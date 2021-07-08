using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyProjet
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //this.login.Text = "Loading";

            if (string.IsNullOrEmpty(this.nom.Text) || string.IsNullOrEmpty(this.mdp.Text)|| (admin.Checked == false && emp.Checked == false))
            {
                MessageBox.Show("un champ vide !");
            }
            else
            {


                this.Hide();
                ListeTaches lst = new ListeTaches();
                lst.ShowDialog();
                

                
            }

           
        }
    }
}
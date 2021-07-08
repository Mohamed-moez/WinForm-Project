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
    public partial class LancementTache : DevExpress.XtraEditors.XtraForm
    {
        public LancementTache()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /*int ch = int.Parse(sec.Text)+1;
            sec.Text = ch.ToString();
            if (ch == 60)
            {
                sec.Text = "0";

            }*/
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

        private void timer3_Tick(object sender, EventArgs e)
        {
            int ch = int.Parse(h.Text) + 1;
            h.Text = ch.ToString();
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //InsertData.Insert_Hist_fTache(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), 2);Close();
        }
    }
}
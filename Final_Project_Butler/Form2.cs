using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Butler
{
    public partial class fmCreateFighter : Form
    {
        public fmCreateFighter()
        {
            InitializeComponent();
        }

        private void selectFighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
        }

        private void fileShowHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmHistory fm = new fmHistory();
            fm.Show();
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(rbAbe.Checked==false && rbDoomsday.Checked == false && rbYoda.Checked == false)
            {
                lblStatus.Text = "Please Select a Charater";
            }
            else if (tbFighterName.Text=="")
            {
                lblStatus.Text = "Please Enter a name";
            }
        }
    }
}

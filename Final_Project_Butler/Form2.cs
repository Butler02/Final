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
        private FighterSetTableAdapters.FightersTableAdapter adapter;
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
            if (rbAbe.Checked == false && rbDoomsday.Checked == false && rbYoda.Checked == false)
            {
                lblStatus.Text = "Please Select a Charater";
            }
            else if (tbFighterName.Text == "")
            {
                lblStatus.Text = "Please Enter a name";
            }
            else if (comboxElement.Text == "")
            {
                lblStatus.Text = "Choose an element";
            }
            else
            {
                
                try
                {
                    string name = tbFighterName.Text;
                    int charater = 0;

                    if (rbAbe.Checked == true)
                    {
                        charater = 1;
                    }
                    else if (rbDoomsday.Checked == true)
                    {
                        charater = 6;
                    }
                    else if (rbYoda.Checked== true)
                    {
                        charater = 5;
                    }
                    adapter.Insert()
                }
            }
        }

        private void fmCreateFighter_Load(object sender, EventArgs e)
        {
            adapter = new FighterSetTableAdapters.FightersTableAdapter();
        }
    }
}

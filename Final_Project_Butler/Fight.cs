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
    public partial class Fight : Form
    {
        public Fight()
        {
            InitializeComponent();
        }

        private void fightHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmHistory fm = new fmHistory();
            fm.Show();
        }

        private void selectFighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main fm = new Main();
            fm.Show();
        }

        private void createFighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmCreateFighter fm = new fmCreateFighter();
            fm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int pic = rand.Next(1, 6);
            int compic = rand.Next(1, 3);
            
            if (pic == 1)
            {
                pbAbe.Visible = true;
                pbBlueGloves.Visible = false;
                pbGirl.Visible = false;
                pbGuy.Visible = false;
                pbYoda.Visible = false;
                pbDoomsday.Visible = false;
            }
            if (pic == 2)
            {
                pbAbe.Visible = false;
                pbBlueGloves.Visible = true;
                pbGirl.Visible = false;
                pbGuy.Visible = false;
                pbYoda.Visible = false;
                pbDoomsday.Visible = false;
            }
            if (pic == 3)
            {
                pbAbe.Visible = false;
                pbBlueGloves.Visible = false;
                pbGirl.Visible = true;
                pbGuy.Visible = false;
                pbYoda.Visible = false;
                pbDoomsday.Visible = false;
            }
            if (pic == 4)
            {
                pbAbe.Visible = false;
                pbBlueGloves.Visible = false;
                pbGirl.Visible = false;
                pbGuy.Visible = true;
                pbYoda.Visible = false;
                pbDoomsday.Visible = false;
            }
            if (pic == 5)
            {
                pbAbe.Visible = false;
                pbBlueGloves.Visible = false;
                pbGirl.Visible = false;
                pbGuy.Visible = false;
                pbYoda.Visible = true;
                pbDoomsday.Visible = false;
            }
            if (pic == 6)
            {
                pbAbe.Visible = false;
                pbBlueGloves.Visible = false;
                pbGirl.Visible = false;
                pbGuy.Visible = false;
                pbYoda.Visible = false;
                pbDoomsday.Visible = true;
            }
            if (compic == 1)
            {
                pbHillary.Visible = true;
                pbTrump.Visible = false;
                pbVlad.Visible = false;
            }
            if (compic == 2)
            {
                pbHillary.Visible = false;
                pbTrump.Visible = true;
                pbVlad.Visible = false;
            }
            if (compic == 3)
            {
                pbHillary.Visible = false;
                pbTrump.Visible = false;
                pbVlad.Visible = true;
            }
        }
    }
}

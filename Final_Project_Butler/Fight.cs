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
        double playerhp = 1000000;
        double comphp = 1000000;
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
            // TODO: This line of code loads data into the 'fighterSet.Fighters' table. You can move, or remove it, as needed.
            this.fightersTableAdapter.Fill(this.fighterSet.Fighters);
            lblPlayerHealth.Text = playerhp.ToString();
            lblComputerhealth.Text = comphp.ToString();
            Random rand = new Random();
            int pic=0;
            int compic = rand.Next(1, 4);
            pic = Main.fighter;
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
                int fighterid = 1;
                lblPlayerFighter.Text = fightersTableAdapter.Getname(fighterid);
            }
            if (pic == 3)
            {
                pbAbe.Visible = false;
                pbBlueGloves.Visible = false;
                pbGirl.Visible = true;
                pbGuy.Visible = false;
                pbYoda.Visible = false;
                pbDoomsday.Visible = false;
                int fighterid = 2;
                lblPlayerFighter.Text = fightersTableAdapter.Getname(fighterid);
            }
            if (pic == 4)
            {
                pbAbe.Visible = false;
                pbBlueGloves.Visible = false;
                pbGirl.Visible = false;
                pbGuy.Visible = true;
                pbYoda.Visible = false;
                pbDoomsday.Visible = false;
                int fighterid = 3;
                lblPlayerFighter.Text = fightersTableAdapter.Getname(fighterid);
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
                int fighterid = 4;
                lblComputerfighter.Text = fightersTableAdapter.Getname(fighterid);
            }
            if (compic == 2)
            {
                pbHillary.Visible = false;
                pbTrump.Visible = true;
                pbVlad.Visible = false;
                int fighterid = 5;
                lblComputerfighter .Text = fightersTableAdapter.Getname(fighterid);
            }
            if (compic == 3)
            {
                pbHillary.Visible = false;
                pbTrump.Visible = false;
                pbVlad.Visible = true;
                int fighterid = 6;
                lblComputerfighter.Text = fightersTableAdapter.Getname(fighterid);
            }
        }

        private void rbPunch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
           
                if (rbKick.Checked == false && rbPunch.Checked == false)
                {
                    lblStatus.Text = "Please select if you would like to punch or kick";
                }
                else if (rbPunch.Checked == true)
                {
                    Random ran = new Random();
                    double attack = ran.Next(20000, 100000);
                    double newhealth = comphp - attack;
                    comphp = newhealth;
                    if (comphp <= 0)
                    {
                        lblStatus.Text = "You won!";
                        lblComputerhealth.Text = "Dead";

                    }
                    else
                    {
                        lblComputerhealth.Text = comphp.ToString();
                    }
                   
                }
            }
        }
    }


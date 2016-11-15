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
    
    public partial class Main : Form
    {
        public static int fighter = 0;
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fighterSet.Fighters' table. You can move, or remove it, as needed.
            this.fightersTableAdapter.Fill(this.fighterSet.Fighters);

        }

        private void createFighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmCreateFighter fm = new fmCreateFighter();
            fm.Show();
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmHistory fm = new fmHistory();
            fm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                       
            if (rbBluegloves.Checked == true)
            {
               fighter = 2;
                Fight f = new Fight();
                f.Show();

                
            }
            if (rbGirl.Checked == true)
            {
                fighter = 3;
                Fight f = new Fight();
                f.Show();
            }
            if (rbGuy.Checked == true)
            {
                fighter = 4;
                Fight f = new Fight();
                f.Show();
            }
          
        }

        private void btnCreateFighter_Click(object sender, EventArgs e)
        {
            fmCreateFighter fm = new fmCreateFighter();
            fm.Show();
        }
    }
}

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
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

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
            Fight fm = new Fight();
            fm.Show();
        }

        private void btnCreateFighter_Click(object sender, EventArgs e)
        {
            fmCreateFighter fm = new fmCreateFighter();
            fm.Show();
        }
    }
}

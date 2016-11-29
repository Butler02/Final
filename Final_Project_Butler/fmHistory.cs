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
    
    public partial class fmHistory : Form
    {
        
        public fmHistory()
        {
            InitializeComponent();
        }

        private void createFighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmCreateFighter fm = new fmCreateFighter();
            fm.Show();
        }

        private void selectFighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main fm = new Main();
            fm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fmHistory_Load(object sender, EventArgs e)
        {
            
            List<string> hist = Fight.History;
            lstHistory.Text = hist.ToString();
        }
    }
}

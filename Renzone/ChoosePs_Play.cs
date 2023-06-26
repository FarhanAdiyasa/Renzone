using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renzone
{
    public partial class ChoosePs_Play : Form
    {
        public ChoosePs_Play()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ChoosePackage_Play choosePackage_Play = new ChoosePackage_Play();
            choosePackage_Play.ShowDialog();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            /*Dashboard_Trans dashboard_Trans = new Dashboard_Trans();
            dashboard_Trans.ShowDialog();*/
        }
    }
}

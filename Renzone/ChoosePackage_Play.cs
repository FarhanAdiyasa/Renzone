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
    public partial class ChoosePackage_Play : Form
    {
        public ChoosePackage_Play()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ChoosePs_Play choosePS_Play = new ChoosePs_Play();
            choosePS_Play.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           /* Payment_Play payment_Play = new Payment_Play();
            payment_Play.ShowDialog();*/
        }
    }
}

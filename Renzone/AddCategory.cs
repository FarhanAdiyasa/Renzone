using Guna.UI.WinForms;
using Renzone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenZone_Transaksi
{
    public partial class AddCategory : Form
    {
        private StringBuilder selectedCategories;
        public delegate void CheckboxChangedEventHandler(string text);
        public event CheckboxChangedEventHandler CheckboxChanged;
        public List<string> SelectedCategories { get; private set; }
        public AddCategory()
        {
            InitializeComponent();
            selectedCategories = new StringBuilder();
            dynamicCheck();

        }
        

        private void dynamicCheck()
        {
            //throw new NotImplementedException();
            RenzonEntities context = new RenzonEntities();
            var listItem = context.ms_kategorigame.ToList();
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;

            foreach (var item in listItem)
            {
                GunaCheckBox cb = new GunaCheckBox();
                cb.Width = 80;
                cb.Left = 20;
                cb.Text = item.nama_kategori.ToString();
                cb.ForeColor = Color.FromArgb(27, 19, 80);
                cb.CheckedOnColor = Color.FromArgb(189, 125, 0);
                cb.CheckedChanged += new EventHandler(changeCheck);
                cb.Padding = new Padding(20, 0, 0, 0);
                cb.Font = new Font("SimSun", 10, FontStyle.Regular);
                flowLayoutPanel2.Controls.Add(cb);
            }

        }

        private void changeCheck(object sender, EventArgs e)
        {
            GunaCheckBox cb = sender as GunaCheckBox;
            if (cb.Checked)
            {
                string checkedText = cb.Text;
                selectedCategories.Append(checkedText + ", ");
            }
            else
            {
                string uncheckedText = cb.Text;
                selectedCategories.Replace(uncheckedText + ", ", "");
            }

            
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (selectedCategories.Length == 0)
            {
                // Tampilkan labelInformasi atau pesan peringatan lainnya
                lbValidasi.Visible = true;
            }
            else
            {
                CheckboxChanged?.Invoke(selectedCategories.ToString().TrimEnd(',', ' '));
                this.Close();
            }
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

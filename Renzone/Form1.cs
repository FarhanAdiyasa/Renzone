using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KategoriGame
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private SqlCommand command;
        private SqlDataReader reader;
        private DataTable dt;
        private const string connectionString = "integrated security=false;data source=.;initial catalog=Renzone;user id = sa ; password = polman";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Text = GenerateID();
            // TODO: This line of code loads data into the 'renzoneDataSet.ms_kategorigame' table. You can move, or remove it, as needed.
            this.ms_kategorigameTableAdapter.Fill(this.renzoneDataSet.ms_kategorigame);
            // TODO: This line of code loads data into the 'renzoneDataSet.ms_kategorigame' table. You can move, or remove it, as needed.
            // this.ms_kategorigameTableAdapter.Fill(this.renzoneDataSet.ms_kategorigame);
            // TODO: This line of code loads data into the 'renzoneDataSet.ms_paketlayanan' table. You can move, or remove it, as needed.
            // this.ms_paketlayananTableAdapter.Fill(this.renzoneDataSet.ms_paketlayanan);
            if (bunifuCustomDataGrid1.Rows.Count > 0)
            {
                bunifuCustomDataGrid1.Rows[0].Selected = true;
            }
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();

            /*deleteButtonColumn.Name = "DeleteColumn";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            bunifuCustomDataGrid1.Columns.Add(deleteButtonColumn);*/

            LoadData();
            dt = new DataTable();
            adapter = new SqlDataAdapter("SElECT * FROM ms_kategorigame", connectionString);
            adapter.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "integrated security=false;data source=.;initial catalog=Renzone;user ID=sa;password=polman";
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("sp_Inputkategorigame", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("id_kategori", txtID.Text);
            command.Parameters.AddWithValue("nama_kategori", txtNama.Text);
           

            try
            {
                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data kategori game berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                
                clear();
                txtID.Text = GenerateID();
                // Memperbarui DataGridView

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Primary key violation error code
                {
                    // Data dengan ID yang sama sudah ada, lakukan perbaruan (UPDATE)
                    SqlCommand updateCommand = new SqlCommand("UPDATE ms_kategorigame SET nama_kategori = @nama_kategori WHERE id_kategori = @id_kategori", con);
                    updateCommand.Parameters.AddWithValue("id_kategori", txtID.Text);
                    updateCommand.Parameters.AddWithValue("nama_kategori", txtNama.Text);


                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Data Kategori game berhasil diperbarui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    
                    clear();
                    txtID.Text = GenerateID();

                }
                else
                {
                    MessageBox.Show("Unable to save: " + ex.Message);
                }
            }
            finally
            {
                con.Close();
            }
            dt.Clear();
            adapter.Fill(dt);
        }
        private void clear()
        {
            txtID.Text = string.Empty;
            txtNama.Text = string.Empty;
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == bunifuCustomDataGrid1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "integrated security=false;data source=.;initial catalog=Renzone;user ID=sa;password=polman";
                    string idKategori = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells["id_kategori"].Value.ToString();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand("sp_DeleteKategorigame", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_kategori", idKategori);

                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh DataGridView untuk memperbarui tampilan data
                                LoadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    dt.Clear();
                    adapter.Fill(dt);
                   
                }
            }


        }
        private void LoadData()
        {
            string connectionString = "integrated security=false;data source=.;initial catalog=Renzone;user ID=sa;password=polman";
            string query = "SELECT  id_kategori, nama_kategori FROM ms_kategorigame";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        bunifuCustomDataGrid1.DataSource = dataTable;
                    }
                }
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Integrated Security=False; data source=.; initial catalog=Renzone; User ID=sa;Password=polman";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dt = new DataTable();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM ms_kategorigame WHERE nama_kategori=@nama_kategori", connection);
                    cmd.Parameters.AddWithValue("@nama_kategori", gunaButton1.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        bunifuCustomDataGrid1.DataSource = dt; // Set DataTable sebagai sumber data DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Maaf, data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bunifuCustomDataGrid1.DataSource = null; // Hapus sumber data DataGridView jika tidak ada data yang ditemukan
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < bunifuCustomDataGrid1.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[rowIndex];
                txtID.Text = selectedRow.Cells["id_kategori"].Value.ToString();
                txtNama.Text = selectedRow.Cells["nama_kategori"].Value.ToString();

                // Ganti dengan nama kolom yang sesuai di tabel Anda
            }
        }

        private void gunaButton3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void bersih(object sender, EventArgs e)
        {
            clear();
        }

        private string GenerateID()
        {
            string newID = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM ms_kategorigame", connection))
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar() + 1;
                    newID = "KG-" + count.ToString("D4");
                }
            }
            return newID;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gunaLineTextBox3_TextChanged(object sender, EventArgs e)
        {
            string searchText =  gunaLineTextBox3.Text;
            string query = "SELECT * FROM ms_kategorigame WHERE id_kategori LIKE @searchText OR nama_kategori LIKE @searchText";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                adapter = new SqlDataAdapter(cmd);
                dt.Clear();
                adapter.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}

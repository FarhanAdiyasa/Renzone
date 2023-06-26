using RenZone_Transaksi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renzone
{
    public partial class CRUDGame_Kary : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dt;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        string connectionString = "integrated security = false; data source =FARHAN_ADIYASA\\MSSQLSERVER02; initial catalog = Renzone;User ID=sa;Password=polman;";
        string id, nm, des, kat;
        private BindingSource bindingSource = new BindingSource();
        public CRUDGame_Kary()
        {
            InitializeComponent();
        }

        private void CRUDGame_Kary_Load(object sender, EventArgs e)
        {
            
        }
        private string GenerateID()
        {
            string newID = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM ms_game", connection))
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar() + 1;
                    newID = "GMS" + count.ToString("D3");
                }
            }
            return newID;
        }

        private void clean()
        {
            tbIDG.Text = null;
            tbNamaG.Text = null;
            tbDeskG.Text = null;
            tbCategoryG.Text = null;
            tbTanggalG.Text = "";
        }
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            OpenAddCategoryForm();
        }
        private void OpenAddCategoryForm()
        {
            AddCategory addCategory = new AddCategory();
            addCategory.CheckboxChanged += AddCategory_CheckboxChanged;
            addCategory.ShowDialog();
        }

        private void AddCategory_CheckboxChanged(string text)
        {
            tbCategoryG.Text = text;
        }
        private DataTable GetGameKategoriData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                // Membuat objek SqlCommand untuk menjalankan query SELECT dari view vw_game_kategori
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_game", con);

                // Membaca data menggunakan SqlDataReader
                SqlDataReader reader = cmd.ExecuteReader();

                // Mengisi struktur kolom DataTable berdasarkan metadata dari SqlDataReader
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dataTable.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                }

                // Mengisi data ke dalam DataTable
                while (reader.Read())
                {
                    DataRow row = dataTable.NewRow();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader.GetValue(i);
                    }

                    dataTable.Rows.Add(row);
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            return dataTable;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelMenu.Top = btnDashboard.Top;
            panelMenu.Height = btnDashboard.Height;
        }

        private void btnMenuGame_Click(object sender, EventArgs e)
        {
            panelMenu.Top = btnMenuGame.Top;
            panelMenu.Height = btnMenuGame.Height;
        }

        private void btnMenuCategory_Click(object sender, EventArgs e)
        {
            panelMenu.Top = btnMenuCategory.Top;
            panelMenu.Height = btnMenuCategory.Height;
        }

        private void btnMenuTable_Click(object sender, EventArgs e)
        {
            panelMenu.Top = btnMenuTable.Top;
            panelMenu.Height = btnMenuTable.Height;
        }

        private void btnMenuPackage_Click(object sender, EventArgs e)
        {
            panelMenu.Top = btnMenuPackage.Top;
            panelMenu.Height = btnMenuPackage.Height;
        }

        private void btnMenuMember_Click(object sender, EventArgs e)
        {
            panelMenu.Top = btnMenuMember.Top;
            panelMenu.Height = btnMenuMember.Height;
        }

        private void btnMenuPS_Click(object sender, EventArgs e)
        {
            panelMenu.Top = btnMenuPS.Top;
            panelMenu.Height = btnMenuPS.Height;
        }

        private void btnMenuAcc_Click(object sender, EventArgs e)
        {
            panelMenu.Top = btnMenuAcc.Top;
            panelMenu.Height = btnMenuAcc.Height;
        }

        private void tbTanggalG_TextChanged(object sender, EventArgs e)
        {
            tbTanggalG.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void dgvGame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvGame.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string idGame = dgvGame.Rows[e.RowIndex].Cells["id_game"].Value.ToString();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand commandDtlKategori = new SqlCommand("sp_DeleteDtlKategori", connection))
                        {
                            using (SqlCommand commandDeleteGame = new SqlCommand("sp_DeleteGame", connection))
                            {
                                commandDtlKategori.CommandType = CommandType.StoredProcedure;
                                commandDtlKategori.Parameters.AddWithValue("@id_game", idGame);

                                commandDeleteGame.CommandType = CommandType.StoredProcedure;
                                commandDeleteGame.Parameters.AddWithValue("@id_game", idGame);

                                try
                                {
                                    connection.Open();
                                    commandDtlKategori.ExecuteNonQuery();
                                    commandDeleteGame.ExecuteNonQuery();
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
                    }
                }
            }
            else if (e.ColumnIndex == dgvGame.Columns["Update"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0 && rowIndex < dgvGame.Rows.Count - 1)
                {
                    DataGridViewRow selectedRow = dgvGame.Rows[rowIndex];
                    tbIDG.Text = selectedRow.Cells["id_game"].Value.ToString();
                    tbNamaG.Text = selectedRow.Cells["nama_game"].Value.ToString();
                    tbDeskG.Text = selectedRow.Cells["deskripsi_game"].Value.ToString();
                    tbTanggalG.Value = (DateTime)selectedRow.Cells["tanggal_rilis"].Value;
                    tbCategoryG.Text = selectedRow.Cells["nama_Kategori"].Value.ToString();

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = tbIDG.Text;
            nm = tbNamaG.Text;
            des = tbDeskG.Text;
            kat = tbCategoryG.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nm) || string.IsNullOrEmpty(des) || tbTanggalG.Text == null || string.IsNullOrEmpty(kat))
            {
                MessageBox.Show("Data harus terisi semua!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> categoryList = new List<string>(kat.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries));
            List<string> categoryIds = GetCategoryIds(categoryList);

            string tgl = tbTanggalG.Text;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand("sp_SaveGame", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_game", id);
                        command.Parameters.AddWithValue("@nama_game", nm);
                        command.Parameters.AddWithValue("@deskripsi_game", des);
                        command.Parameters.AddWithValue("@tanggal_rilis", tgl);

                        command.ExecuteNonQuery();
                    }

                    // Delete existing category associations
                    using (SqlCommand deleteDetailCommand = new SqlCommand("sp_DeleteKategorigame", con))
                    {
                        deleteDetailCommand.CommandType = CommandType.StoredProcedure;
                        deleteDetailCommand.Parameters.AddWithValue("@id_game", id);

                        deleteDetailCommand.ExecuteNonQuery();
                    }

                    // Insert data into dtl_game table
                    using (SqlCommand insertDetailCommand = new SqlCommand("sp_Inputkategorigame", con))
                    {
                        insertDetailCommand.CommandType = CommandType.StoredProcedure;

                        foreach (string categoryId in categoryIds)
                        {
                            insertDetailCommand.Parameters.Clear();
                            insertDetailCommand.Parameters.AddWithValue("@id_game", id);
                            insertDetailCommand.Parameters.AddWithValue("@id_kategori", categoryId);

                            insertDetailCommand.ExecuteNonQuery();
                        }
                    }

                    LoadData();
                }

                MessageBox.Show("Berhasil disimpan!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();
                tbIDG.Text = GenerateID();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            id = tbIDG.Text;
            nm = tbNamaG.Text;
            des = tbDeskG.Text;
            kat = tbCategoryG.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nm) || string.IsNullOrEmpty(des) || tbTanggalG.Text == null || string.IsNullOrEmpty(kat))
            {
                lbValidasi.Visible = true;
                return;
            }

            List<string> categoryList = new List<string>(kat.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries));
            List<string> categoryIds = GetCategoryIds(categoryList);

            string tgl = tbTanggalG.Text;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand("sp_SaveGame", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@nama", nm);
                        command.Parameters.AddWithValue("@deskripsi", des);
                        command.Parameters.AddWithValue("@tanggal", tgl);

                        command.ExecuteNonQuery();
                    }

                    // Delete existing category associations
                    using (SqlCommand deleteDetailCommand = new SqlCommand("sp_DeleteKategorigame", con))
                    {
                        deleteDetailCommand.CommandType = CommandType.StoredProcedure;
                        deleteDetailCommand.Parameters.AddWithValue("@id_kategori", id);

                        deleteDetailCommand.ExecuteNonQuery();
                    }

                    // Insert data into dtl_game table
                    using (SqlCommand insertDetailCommand = new SqlCommand("sp_InputDtlKategori", con))
                    {
                        insertDetailCommand.CommandType = CommandType.StoredProcedure;

                        foreach (string categoryId in categoryIds)
                        {
                            MessageBox.Show(categoryId);
                            insertDetailCommand.Parameters.Clear();
                            insertDetailCommand.Parameters.AddWithValue("@id_game", id);
                            insertDetailCommand.Parameters.AddWithValue("@id_kategori", categoryId);

                            insertDetailCommand.ExecuteNonQuery();
                        }
                    }

                    LoadData();
                }

                MessageBox.Show("Berhasil disimpan!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dgvGame.Rows.Add();
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dt = new DataTable();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM vw_game WHERE nama_game LIKE '%'+@searchText+'%' OR deskripsi_game LIKE '%'+" +
                        "@searchText+'%' OR tanggal_rilis LIKE '%'+@searchText+'%' OR nama_kategori LIKE '%'+" +
                        "@searchText+'%'", connection);
                    cmd.Parameters.AddWithValue("@searchText", tbSearch.Text);

                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvGame.DataSource = dt; // Set DataTable sebagai sumber data DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Maaf, data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clean();
            tbIDG.Text = GenerateID();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text;
            string query = "SELECT * FROM vw_game WHERE id_game LIKE '%'+@searchText+'%' OR nama_game LIKE '%'+@searchText+'%' OR deskripsi_game LIKE '%'+" +
                        "@searchText+'%' OR tanggal_rilis LIKE '%'+@searchText+'%' OR nama_kategori LIKE '%'+" +
                        "@searchText+'%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dt.Clear();
                adapter.Fill(dt);
                dgvGame.DataSource = dt;
            }
        }

        private void CRUDGame_Kary_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'renzonDataSet11.vw_game' table. You can move, or remove it, as needed.
            this.vw_gameTableAdapter.Fill(this.renzonDataSet11.vw_game);
            tbIDG.Text = GenerateID();

        }

        public void LoadData()
        {
            // Update the DataGridView with the latest data
            DataTable gameKategoriData = GetGameKategoriData();
            dgvGame.DataSource = gameKategoriData;
        }

        private void dgvGame_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public List<string> GetCategoryIds(List<string> categories)
        {
            List<string> categoryIds = new List<string>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT id_kategori FROM ms_kategorigame WHERE nama_kategori = @nama_kategori";

                    con.Open();

                    foreach (string category in categories)
                    {
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@nama_kategori", category);

                            using (SqlDataReader resultSet = command.ExecuteReader())
                            {
                                if (resultSet.Read())
                                {
                                    string categoryId = resultSet.GetString(0);
                                    MessageBox.Show(categoryId);
                                    categoryIds.Add(categoryId);
                                }
                                else
                                {
                                    throw new Exception("Kategori tidak ditemukan: " + category);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return categoryIds;
        }

    }
}

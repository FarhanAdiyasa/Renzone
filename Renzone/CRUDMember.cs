using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renzone
{
    public partial class CRUDMember : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dt;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        string connectionString = "integrated security = false; data source =FARHAN_ADIYASA\\MSSQLSERVER02; initial catalog = Renzone;User ID=sa;Password=polman;";
        string id, nm, almt, telp;
        private BindingSource bindingSource = new BindingSource();
        DateTime tglDaftar;
        public CRUDMember()
        {
            InitializeComponent();
        }

        private void CRUDMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'renzonDataSet1.ms_member' table. You can move, or remove it, as needed.
            this.ms_memberTableAdapter.Fill(this.renzonDataSet1.ms_member);
            tbIDM.Text = GenerateID();
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
            tbTanggalM.Text = currentDate;


        }

        private void btSave_Click(object sender, EventArgs e)
        {

            id = tbIDM.Text;
            nm = tbNamaM.Text;
            almt = tbAlamatM.Text;
            telp = tbTelpM.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nm) || string.IsNullOrEmpty(almt) || tbTanggalM.Text == null || string.IsNullOrEmpty(telp))
            {
                MessageBox.Show("Data harus terisi semua!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string tgl = tbTanggalM.Text;
            DateTime tanggal;
            DateTime.TryParseExact(tgl, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tanggal);
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand("sp_Inputmember", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_member", id);
                        command.Parameters.AddWithValue("@nama_member", nm);
                        command.Parameters.AddWithValue("@alamat", almt);
                        command.Parameters.AddWithValue("@no_telp",telp);
                        command.Parameters.AddWithValue("@tgl_daftar", tanggal);
                        command.Parameters.AddWithValue("@status_anggota", "Aktif");

                        command.ExecuteNonQuery();
                    }


                    LoadData();
                }

                MessageBox.Show("Berhasil disimpan!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();
                tbIDM.Text = GenerateID();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadData()
        {
            // Update the DataGridView with the latest data
            DataTable gameKategoriData = GetGameKategoriData();
            dgvMember.DataSource = gameKategoriData;
        }
        private DataTable GetGameKategoriData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                // Membuat objek SqlCommand untuk menjalankan query SELECT dari view vw_game_kategori
                SqlCommand cmd = new SqlCommand("SELECT * FROM ms_member", con);

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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text;
            string query = "SELECT * FROM ms_member WHERE id_member LIKE '%'+@searchText+'%' OR nama_member LIKE '%'+@searchText+'%' OR alamat LIKE '%'+@searchText+'%' OR no_telp LIKE '%'+@searchText+'%' OR tgl_daftar LIKE '%'+@searchText+'%' OR status_anggota LIKE '%'+@searchText+'%'";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dt.Clear();
                adapter.Fill(dt);
                dgvMember.DataSource = dt;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clean();
            tbIDM.Text = GenerateID();
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMember.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string idGame = dgvMember.Rows[e.RowIndex].Cells["id_member"].Value.ToString();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand commandDeleteGame = new SqlCommand("sp_DeleteMember", connection))
                        {

                            commandDeleteGame.CommandType = CommandType.StoredProcedure;
                            commandDeleteGame.Parameters.AddWithValue("@id_member", idGame);

                            try
                            {
                                connection.Open();
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
            else if (e.ColumnIndex == dgvMember.Columns["Update"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0 && rowIndex < dgvMember.Rows.Count - 1)
                {
                    DataGridViewRow selectedRow = dgvMember.Rows[rowIndex];
                    tbIDM.Text = selectedRow.Cells["id_member"].Value.ToString();
                    tbNamaM.Text = selectedRow.Cells["nama_member"].Value.ToString();
                    tbAlamatM.Text = selectedRow.Cells["alamat"].Value.ToString();
                    string tglDaftarString = selectedRow.Cells["tgl_daftar"].Value.ToString();
                    DateTime.TryParse(tglDaftarString, out tglDaftar);
                    string tglDaftarFormatted = tglDaftar.ToString("dd/MM/yyyy");
                    tbTanggalM.Text = tglDaftarFormatted;
                    tbTelpM.Text = selectedRow.Cells["no_telp"].Value.ToString();

                }
            }
        }


        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
        private string GenerateID()
        {
            string newID = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM ms_member", connection))
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar() + 1;
                    newID = "MBR" + count.ToString("D3");
                }
            }
            return newID;
        }
        private void clean()
        {
            tbIDM.Text = null;
            tbNamaM.Text = null;
            tbAlamatM.Text = null;
            tbTanggalM.Text = null;
            tbTelpM.Text = "";
        }
    }
}

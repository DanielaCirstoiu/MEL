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

namespace FrmBazaFilme
{
    public partial class FrmMovies : Form
    {
        private string MovieID = "";
        public static string[] moviesData;
        public FrmMovies()
        {
            InitializeComponent();
        }
        private void FrmMovies_Load(object sender, EventArgs e)
        {
            dgvMovies.DataSource = Global.Ds;
            dgvMovies.DataMember = "Movies";

            dgvDetalii.DataSource = Global.Ds;
            dgvDetalii.DataMember = "Detalii";
            moviesData = new string[7];
        }
        
        private void bAddMovies_Click(object sender, EventArgs e)
        {
            FrmAddMovies f = new FrmAddMovies();
            f.ShowDialog();
        }

        private void bUpdateMovie_Click(object sender, EventArgs e)
        {
            FrmUpdateMovies f = new FrmUpdateMovies(dgvMovies);
            f.ShowDialog();
        }

        private void dgvMovies_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var inputData = dgvMovies.SelectedRows[0].Cells;
            var outputData = inputData;
            var output = (DataGridViewCellCollection) inputData;
            int index = 0;
            if (output != null)
            {
                foreach (var field in output)
                {
                    var crtValue = (DataGridViewCell) field;
                    moviesData[index++] = crtValue.Value.ToString();
                }
            }

        }

        private void bDeleteMovie_Click(object sender, EventArgs e)
        {
            //MovieID = dgvMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
            var inputData = dgvMovies.SelectedRows[0].Cells;
            var outputData = inputData;
            var output = (DataGridViewCellCollection)inputData;
            int index = 0;
            if (output != null)
            {
                foreach (var field in output)
                {
                    var crtValue = (DataGridViewCell)field;
                    moviesData[index++] = crtValue.Value.ToString();
                }
            }


            Global.Con.Open();
            DataTable t = Global.Ds.Tables["Movies"];
            SqlCommand cmd2 = new SqlCommand("delete tMovies where MovieID=@MovieID", Global.Con);
            cmd2.Parameters.AddWithValue("@MovieID", moviesData[0]);
            cmd2.ExecuteNonQuery();

            //folosire SqlDataAdapter
            Global.DaMovies.DeleteCommand = cmd2;
            Global.DaMovies.Update(t);
            Global.Ds.AcceptChanges();

            Global.Con = new SqlConnection(Global.StringConnect);

            Global.Con.Open();
            Global.Ds = new DataSet();
            Global.DaMovies = new SqlDataAdapter("select * from tMovies", Global.Con);
            Global.DaMovies.Fill(Global.Ds, "Movies");

            Global.DaView = new SqlDataAdapter("select * from dbo.vDetalii", Global.Con);
            Global.DaView.Fill(Global.Ds, "Detalii");

            Global.Con.Close();

            dgvMovies.DataSource = Global.Ds;
            dgvMovies.DataMember = "Movies";

            dgvDetalii.DataSource = Global.Ds;
            dgvDetalii.DataMember = "Detalii";

        }
    }
}

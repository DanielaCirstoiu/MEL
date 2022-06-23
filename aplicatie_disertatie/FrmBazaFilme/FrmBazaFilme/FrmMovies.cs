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
            dgvMovies.DataSource = Global.ds;
            dgvMovies.DataMember = "Movies";

            dgvDetalii.DataSource = Global.ds;
            dgvDetalii.DataMember = "Detalii";
            moviesData = new string[7];
        }
        
        private void dgvRemovedMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            //MovieID = dgvMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
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


            Global.con.Open();
            DataTable t = Global.ds.Tables["Movies"];
            SqlCommand cmd2 = new SqlCommand("delete tMovies where MovieID=@MovieID", Global.con);
            cmd2.Parameters.AddWithValue("@MovieID", moviesData[0]);
            cmd2.ExecuteNonQuery();

            //folosire SqlDataAdapter
            Global.daMovies.DeleteCommand = cmd2;
            Global.daMovies.Update(t);
            Global.ds.AcceptChanges();

            Global.daMovies = new SqlDataAdapter("select * from tMovies", Global.con);
            Global.daMovies.Fill(Global.ds, "Movies");

            Global.con = new SqlConnection(Global.stringConectare);

            Global.con.Open();
            Global.ds = new DataSet();
            Global.daMovies = new SqlDataAdapter("select * from tMovies", Global.con);
            Global.daMovies.Fill(Global.ds, "Movies");

            Global.daActors = new SqlDataAdapter("select * from tActors", Global.con);
            Global.daActors.Fill(Global.ds, "Actors");

            Global.daDirectors = new SqlDataAdapter("select * from tDirectors", Global.con);
            Global.daDirectors.Fill(Global.ds, "Directors");

            Global.daView = new SqlDataAdapter("select * from dbo.vDetalii", Global.con);
            Global.daView.Fill(Global.ds, "Detalii");

            Global.con.Close();

            dgvMovies.DataSource = Global.ds;
            dgvMovies.DataMember = "Movies";

            dgvDetalii.DataSource = Global.ds;
            dgvDetalii.DataMember = "Detalii";


        }
    }
}

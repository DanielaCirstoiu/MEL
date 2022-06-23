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
    public partial class FrmMoviesB : Form
    {
        public FrmMoviesB()
        {
            InitializeComponent();
        }

        private void FrmMoviesB_Load(object sender, EventArgs e)
        {
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
        }

        private void bMovies_Click(object sender, EventArgs e)
        {
            FrmMovies f = new FrmMovies();
            f.ShowDialog();
        }

        private void bActors_Click(object sender, EventArgs e)
        {
            FrmActors f = new FrmActors();
            f.ShowDialog();
        }

        private void bDirectors_Click(object sender, EventArgs e)
        {
            FrmDirectors f = new FrmDirectors();
            f.ShowDialog();
        }

        
    }
}

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
            Global.Con = new SqlConnection(Global.StringConnect);
            Global.Con.Open();
            Global.Ds = new DataSet();
            Global.DaMovies = new SqlDataAdapter("select * from tMovies", Global.Con);
            Global.DaMovies.Fill(Global.Ds, "Movies");

            Global.DaActors = new SqlDataAdapter("select * from tActors", Global.Con);
            Global.DaActors.Fill(Global.Ds, "Actors");

            Global.DaDirectors = new SqlDataAdapter("select * from tDirectors", Global.Con);
            Global.DaDirectors.Fill(Global.Ds, "Directors");

            Global.DaView = new SqlDataAdapter("select * from dbo.vDetalii", Global.Con);
            Global.DaView.Fill(Global.Ds, "Detalii");

            Global.Con.Close();
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

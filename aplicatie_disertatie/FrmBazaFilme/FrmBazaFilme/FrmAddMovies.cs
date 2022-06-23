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
    public partial class FrmAddMovies : Form
    {
        public FrmAddMovies()
        {
            InitializeComponent();
        }

        private void bAddMovie_Click(object sender, EventArgs e)
        {
            DataTable t = Global.ds.Tables["Movies"];

            DataRow r = t.NewRow();
            r["MovieID"] = tbMovieID.Text;
            r["Title"] = tbTitle.Text;
            r["Genre"] = gbGenre.Text;
            r["Country"] = cbCountry.Text;
            r["Year"] = dtpYear.Value.Year;
            r["Duration"] = nupdDuration.Value;
            r["MilEarnings"] = tbEarnings.Value;

            t.Rows.Add(r);

            string strInsert = "insert into tMovies(MovieID, Title, Genre, Country, Year, " +
                "Duration, MilEarnings) values ('" +
                tbMovieID.Text + "','" + tbTitle.Text + "','" + gbGenre.Text + "','" + cbCountry.Text +
                "','" +dtpYear.Value.Year + "','" + nupdDuration.Value + "','" + tbEarnings.Value + "')";

            SqlCommand cmd = new SqlCommand(strInsert, Global.con);

            //folosire SqlDataAdapter
            Global.daMovies.InsertCommand = cmd;
            Global.daMovies.Update(t);
            Global.ds.AcceptChanges();
        }

        private void tbEarnings_Scroll(object sender, EventArgs e)
        {
            tbEarnings = (System.Windows.Forms.TrackBar)sender;
            tbEarn.Text = tbEarnings.Value.ToString();
            pbSuccess.Value = tbEarnings.Value * 100 / 1500;
        }

    }
}

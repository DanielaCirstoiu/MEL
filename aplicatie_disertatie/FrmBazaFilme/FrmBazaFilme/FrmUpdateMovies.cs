using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBazaFilme
{
    public partial class FrmUpdateMovies : Form
    {
        private DataGridView _moviesView;
        private List<RadioButton> rButtons;
        public FrmUpdateMovies(DataGridView moviesView)
        {
            InitializeComponent();
            utbMovieID.Enabled = false;
            _moviesView = moviesView;
            LoadData();
        }

        private void LoadData()
        {
            rButtons = new List<RadioButton>();
            rButtons.Add(urbFantasy);
            rButtons.Add(urbAdventure);
            rButtons.Add(urbBiography);
            rButtons.Add(urbComedy);
            rButtons.Add(urbHistory);
            rButtons.Add(urbMusical);
            rButtons.Add(urbSciFi);
            rButtons.Add(urbRomance);
            var data = FrmMovies.moviesData;
            utbMovieID.Text = data[0];
            utbTitle.Text = data[1];

            var checkedButton = rButtons.FirstOrDefault(button => button.Text == data[2]);
            if(checkedButton != null) checkedButton.Checked = true;

            ucbCountry.Text = data[3];
            udtpYear.CustomFormat= data[4];
            unupdDuration.Text = data[5];
            utbEarn.Text = data[6];
        }

        private void bUpdateMovie_Click(object sender, EventArgs e)
        {
            Global.con.Open();
            DataTable t = Global.ds.Tables["Movies"];
            SqlCommand cmd2 = new SqlCommand("update tMovies set MovieID=@MovieID, Title=@Title, Genre=@Genre, Country=@Country, Year=@Year, " +
                                             "Duration=@Duration, MilEarnings=@MilEarnings where MovieID=@MovieID", Global.con);
            cmd2.Parameters.AddWithValue("@MovieID", utbMovieID.Text);
            cmd2.Parameters.AddWithValue("@Title", utbTitle.Text);
            var text = ugbGenre.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            cmd2.Parameters.AddWithValue("@Genre", text);
            cmd2.Parameters.AddWithValue("@Country", ucbCountry.Text);
            cmd2.Parameters.AddWithValue("@Year", udtpYear.Text);
            cmd2.Parameters.AddWithValue("@Duration", unupdDuration.Text);
            cmd2.Parameters.AddWithValue("@MilEarnings", utbEarn.Text);
            cmd2.ExecuteNonQuery();
            
            //folosire SqlDataAdapter
            Global.daMovies.InsertCommand = cmd2;
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

        }
        private void utbEarnings_Scroll(object sender, EventArgs e)
        {
            utbEarnings = (System.Windows.Forms.TrackBar)sender;
            utbEarn.Text = utbEarnings.Value.ToString();
            upbSuccess.Value = utbEarnings.Value * 100 / 1500;
        }

        private void FrmUpdateMovies_FormClosing(object sender, FormClosingEventArgs e)
        {
            _moviesView.DataSource = Global.ds;
            _moviesView.DataMember = "Movies";

            _moviesView.DataSource = Global.ds;
            _moviesView.DataMember = "Detalii";
        }
    }
}

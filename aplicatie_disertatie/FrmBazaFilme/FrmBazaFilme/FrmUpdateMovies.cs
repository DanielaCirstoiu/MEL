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
            Global.Con.Open();
            DataTable t = Global.Ds.Tables["Movies"];
            SqlCommand cmd2 = new SqlCommand("Update tMovies Set MovieID=@MovieID, Title=@Title, Genre=@Genre, Country=@Country, " +
                                             "Year=@Year, Duration=@Duration, MilEarnings=@MilEarnings where MovieID=@MovieID", Global.Con);
            cmd2.Parameters.AddWithValue("@MovieID", utbMovieID.Text);
            cmd2.Parameters.AddWithValue("@Title", utbTitle.Text);
            if (ugbGenre != null)
            {
                var text = ugbGenre.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                cmd2.Parameters.AddWithValue("@Genre", text);
            }

            cmd2.Parameters.AddWithValue("@Country", ucbCountry.Text);
            cmd2.Parameters.AddWithValue("@Year", udtpYear.Text);
            cmd2.Parameters.AddWithValue("@Duration", unupdDuration.Text);
            cmd2.Parameters.AddWithValue("@MilEarnings", utbEarn.Text);
            cmd2.ExecuteNonQuery();

            //using SqlDataAdapter
            Global.DaMovies.UpdateCommand = cmd2;
            Global.DaMovies.Update(t);
            Global.Ds.AcceptChanges();

            //Global.DaMovies = new SqlDataAdapter("select * from tMovies", Global.Con);
            //Global.DaMovies.Fill(Global.Ds, "Movies");

            Global.Ds = new DataSet();
            Global.DaMovies = new SqlDataAdapter("select * from tMovies", Global.Con);
            Global.DaMovies.Fill(Global.Ds, "Movies");

            Global.DaView = new SqlDataAdapter("select * from dbo.vDetalii", Global.Con);
            Global.DaView.Fill(Global.Ds, "Detalii");

            Global.Con.Close();

            Close();
        }
        private void utbEarnings_Scroll(object sender, EventArgs e)
        {
            utbEarnings = (System.Windows.Forms.TrackBar)sender;
            utbEarn.Text = utbEarnings.Value.ToString();
            upbSuccess.Value = utbEarnings.Value * 100 / 1500;
        }

        private void FrmUpdateMovies_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_moviesView.DataSource = Global.Ds;
            //_moviesView.DataMember = "Movies";

            //_moviesView.DataSource = Global.Ds;
            //_moviesView.DataMember = "Detalii";

        }
    }
}

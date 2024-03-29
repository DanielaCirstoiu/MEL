﻿using System;
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
            DataTable t = Global.Ds.Tables["Movies"];

            DataRow r = t.NewRow();
            r["MovieID"] = tbMovieID.Text;
            var rbutton = gbGenre.Controls.OfType<RadioButton>()
                .FirstOrDefault(n => n.Checked);
            r["Title"] = tbTitle.Text;
            if (rbutton != null)
                r["Genre"] = rbutton.Text;
            r["Country"] = cbCountry.Text;
            r["Year"] = dtpYear.Value.Year;
            r["Duration"] = nupdDuration.Value;
            r["MilEarnings"] = int.Parse(tbEarn.Text);

            t.Rows.Add(r);

            string strInsert = "insert into tMovies(MovieID, Title, Genre, Country, Year, " +
                "Duration, MilEarnings) values ('" +
                tbMovieID.Text + "','" + tbTitle.Text + "','" + rbutton.Text + "','" + cbCountry.Text +
                "','" +dtpYear.Value.Year + "','" + nupdDuration.Value + "','" + int.Parse(tbEarn.Text) + "')";

            SqlCommand cmd = new SqlCommand(strInsert, Global.Con);

            //using SqlDataAdapter
            Global.DaMovies.InsertCommand = cmd;
            Global.DaMovies.Update(t);
            Global.Ds.AcceptChanges();
            Close();
        }

        private void tbEarnings_Scroll(object sender, EventArgs e)
        {
            tbEarnings = (System.Windows.Forms.TrackBar)sender;
            tbEarn.Text = tbEarnings.Value.ToString();
            pbSuccess.Value = tbEarnings.Value * 100 / 1500;
        }
        
    }
}

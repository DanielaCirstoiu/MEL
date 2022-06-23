using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBazaFilme
{
    static class Global
    {
        public static string stringConectare = @"Data Source=N022057\SQLEXPRESS;Initial Catalog=DBMovies;Integrated Security=True;";

        public static SqlConnection con;
        public static DataSet ds;
        public static SqlDataAdapter daMovies;
        public static SqlDataAdapter daActors;
        public static SqlDataAdapter daDirectors;
        public static SqlDataAdapter daView;



    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMoviesB());
        }
    }
}

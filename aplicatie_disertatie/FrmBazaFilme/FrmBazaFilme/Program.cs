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
        public static string StringConnect = @"Data Source=N022057\SQLEXPRESS;"+
                                               "Initial Catalog=DBMovies;Integrated Security=True;";

        public static SqlConnection Con;
        public static DataSet Ds;
        public static SqlDataAdapter DaMovies;
        public static SqlDataAdapter DaActors;
        public static SqlDataAdapter DaDirectors;
        public static SqlDataAdapter DaView;
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

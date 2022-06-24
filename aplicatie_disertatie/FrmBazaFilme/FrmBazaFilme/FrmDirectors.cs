using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBazaFilme
{
    public partial class FrmDirectors : Form
    {
        public FrmDirectors()
        {
            InitializeComponent();
        }

        private void dgvDirectors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDirectors_Load(object sender, EventArgs e)
        {
            dgvDirectors.DataSource = Global.Ds;
            dgvDirectors.DataMember = "Directors";
        }
    }
}

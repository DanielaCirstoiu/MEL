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
    public partial class FrmActors : Form
    {
        public FrmActors()
        {
            InitializeComponent();
        }

        private void FrmActors_Load(object sender, EventArgs e)
        {
            dgvActors.DataSource = Global.ds;
            dgvActors.DataMember = "Actors";
        }
    }
}

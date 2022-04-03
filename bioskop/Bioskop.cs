using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bioskop
{
    public partial class Bioskop : Form
    {
        public Bioskop()
        {
            InitializeComponent();
        }

        string cs = @"Data source = DESKTOP-U3IAE97; Initial catalog = Bioskop2; Integrated security = true";
        SqlConnection veza;
        SqlDataAdapter adapter;
        DataTable podaci;

        private void Bioskop_Load(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            adapter = new SqlDataAdapter("select * from Pogled", veza);
            podaci = new DataTable();
            adapter.Fill(podaci);
            dgTabela.DataSource = podaci;
            dgTabela.ReadOnly = true;
            dgTabela.AllowUserToAddRows = false;
        }
    }
}

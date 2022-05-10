using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora
{
    public partial class frm_SeguroCarro : Form
    {
        public frm_SeguroCarro()
        {
            InitializeComponent();
            
        }

        private void frm_SeguroCarro_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_Sim_CheckedChanged(object sender, EventArgs e)
        {
            txtNome2.Enabled = true;
            txtCPF2.Enabled = true;
            panel_SegundoSegurado.Visible = true;
        }

        private void btn_CancelarSegundo_Click(object sender, EventArgs e)
        {
            checkBox_Sim.Controls.Clear();
            txtNome2.Enabled = false;
            txtCPF2.Enabled = false;
            checkBox_Sim.Visible = true;
            checkBox_Sim.Checked = false;
            panel_SegundoSegurado.Visible = false;
        }
    }
}

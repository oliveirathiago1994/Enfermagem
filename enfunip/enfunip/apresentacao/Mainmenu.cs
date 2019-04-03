using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enfunip.apresentacao
{
    public partial class FrmMainmenu : Form
    {
        public FrmMainmenu()
        {
            InitializeComponent();
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void lbl_userfix_Click(object sender, EventArgs e)
        {

        }

        private void menu_pac_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void relToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento Agendamento = new Agendamento();
            Agendamento.Show();
        }

        private void cadastroDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cadastro_Paciente cadastro_Paciente = new frm_Cadastro_Paciente();
            cadastro_Paciente.Show();
        }
    }
}

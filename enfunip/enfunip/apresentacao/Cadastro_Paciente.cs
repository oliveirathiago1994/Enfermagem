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
    public partial class Cadastro_Paciente : Form
    {
        public Cadastro_Paciente()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            timer_CadastroPaciente.Start();
        }

        private void timer_CadastroPaciente_Tick(object sender, EventArgs e)
        {
            pbr_Cadastro.Increment(10);
            
        }

        private void pbr_Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

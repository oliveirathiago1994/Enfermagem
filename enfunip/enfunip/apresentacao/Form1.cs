using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using enfunip.modelo;
using enfunip.apresentacao;

namespace enfunip
{
    public partial class FrmEnfermagem : Form
    {
        public FrmEnfermagem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.usuario = txbUsuario.Text;
            controle.senha = txbSenha.Text;
            controle.Executar();
            if (controle.mensagem.Equals(""))
            {
                this.Hide();

                FrmMainmenu mainmenu = new FrmMainmenu();
                mainmenu.Show();

                
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }
    }
}

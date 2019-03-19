
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using enfunip.modelo;

namespace enfunip.modelo
{
    class Controle
    {
        private String usuario;
        private String senha;
        private String mensagem;

        public Controle(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
            Executar();
        }

        public string Mensagem { get => mensagem;}

        private void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.usuario, this.senha);
            
            if (validacao.Mensagem.Equals(""))
            {
                this.mensagem = "";               
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }
    }
}
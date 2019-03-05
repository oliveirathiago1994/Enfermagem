
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
        public String usuario;
        public String senha;
        public String mensagem;

        public void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.usuario = this.usuario;
            validacao.senha = this.senha;
            validacao.Validar();
            if (validacao.mensagem.Equals(""))
            {
                this.mensagem = "";               
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using enfunip.modelo;

namespace enfunip.modelo
{
    class Validacao
    {
        private String usuario;
        private String senha;
        private String mensagem;

        public Validacao(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
            Validar();
        }

        public string Mensagem { get => mensagem;}

        private void Validar()
        {
            this.mensagem = "";
            try
            {
                if (this.usuario == "admin" && this.senha == "admin" )
                {
                    this.mensagem = "";
                }
                else
                {
                    this.mensagem = "Senha inválida";
                }
            }
            catch (Exception)
            {
                this.mensagem = "senha inválida";
                
            }
        }
    }
}
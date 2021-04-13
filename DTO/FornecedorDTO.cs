using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DTO
{
    public class FornecedorDTO
    {
        private int id;
        private string nome, cnpj, endereco, telefone, email, senha, nomeRepresentante, telefoneRepresentante;

        public int Id { get => id; set => id = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string NomeRepresentante { get => nomeRepresentante; set => nomeRepresentante = value; }
        public string TelefoneRepresentante { get => telefoneRepresentante; set => telefoneRepresentante = value; }

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("Campo nome e obrigatorio");
                }
            }

            get { return this.nome; }
        }

        public string Cnpj
        {
            set
            {
                if (value != string.Empty)
                {
                    this.cnpj = value;
                }
                else
                {
                    throw new Exception("Campo cnpj e obrigatorio");
                }
            }

            get { return this.cnpj; }
        }

        public string Email
        {
            set
            {
                if (value != string.Empty)
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Campo email e obrigatorio");
                }
            }

            get { return this.email; }
        }

        public string Senha
        {
            set
            {
                if (value != string.Empty)
                {
                    this.senha = value;
                }
                else
                {
                    throw new Exception("Campo senha e obrigatorio");
                }
            }

            get { return this.senha; }
        }
    }
}
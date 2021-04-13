using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DTO
{
    public class ClienteDTO
    {          
        private int id;
        private string nome, cpf, endereco, telefone, email, senha;

        public int Id { get => id; set => id = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }

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

        public string Cpf
        {
            set
            {
                if (value != string.Empty)
                {
                    this.cpf = value;
                }
                else
                {
                    throw new Exception("Campo cpf e obrigatorio");
                }
            }

            get { return this.cpf; }
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
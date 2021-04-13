using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DTO
{
    public class CategoriaDTO
    {
        private int id;
        private string nome, descricao;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public string Nome
        {
            set { if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatorio");
                }
            }

            get
            {
                return this.nome;
            }
        }
    }
}
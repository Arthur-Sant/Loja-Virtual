using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DTO
{
    public class ProdutoDTO
    {
        private int id, quantidadeEstoque, categoriaId, fornecedotId;
        private string nome, descricao, foto;
        private double valor;

        public int Id { get => id; set => id = value; }
        public int FornecedotId { get => fornecedotId; set => fornecedotId = value; }
        public string Foto { get => foto; set => foto = value; }
        public double Valor { get => valor; set => valor = value; }

        // nào aceita que o campo ser nulo
        public string Nome
        {
            set { if(value != string.Empty)
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

        public string Descricao
        {
            set { if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("Campo nome e obrigatorio");
                }
            }
            get { return this.descricao; }
        }

        public int QuantidadeEstoque
        {
            set { if (value != 0)
                {
                    this.quantidadeEstoque = value;
                }
                else {
                    throw new Exception("Campo quantidade é obrigatorio");
                }
            }
            get { return this.quantidadeEstoque; }
        }

        public int CategoriaId
        {
            set
            {
                if (value != 0)
                {
                    this.categoriaId = value;
                }
                else
                {
                    throw new Exception("Campo categoria é obrigatorio");
                }
            }
            get { return this.categoriaId; }
        }
    }
}
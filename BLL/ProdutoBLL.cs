using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaVirtual.DAL;
using LojaVirtual.DTO;
using System.Data;

namespace LojaVirtual.BLL
{
    public class ProdutoBLL
    {
        private MySqlDAL con = new MySqlDAL();

        public void Inserir(ProdutoDTO produto)
        {
            string sql = string.Format($@"insert into produtos values (null, {produto.Nome}, {produto.Descricao}, {produto.FornecedotId},
                                       {produto.CategoriaId}, {produto.QuantidadeEstoque}, {produto.Foto};");
            con.ExecutarSql(sql);
        }
        

        public void Excluir(ProdutoDTO produto)
        {
            string sql = string.Format($@"delete from produto where id = { produto.Id} ;");
            con.ExecutarSql(sql);
        }

        public void Alterar(ProdutoDTO produto)
        {
            string sql = string.Format($@"update produto set nome = {produto.Nome},  descricao = {produto.Descricao}, 
                                       valor = {produto.Valor}, fornecedorId = {produto.FornecedotId}, 
                                       categoria = {produto.CategoriaId}, foto = {produto.Foto},
                                       quantidadeEstoque = {produto.QuantidadeEstoque};");

            con.ExecutarSql(sql);
        }

        public DataTable ConsultarID(int id)
        {
            string sql = string.Format($@"select * from produto where id = {id}");
            return con.ExecutarConsulta(sql);
        }

        public DataTable Pesquisar(string condicao)
        {
            string sql = string.Format($@"select p.id, p.nome, p.descricao, p.valor, f.nome, c.nome, p.foto, p.quantidade 
                                       from produto as p, categoria as c, fornecedor as f where p.categoriaID = c.Id
                                        and p.foncedorID = f.ID and {condicao} order by p.id;");

            return con.ExecutarConsulta(sql);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaVirtual.DAL;
using LojaVirtual.DTO;
using System.Data;

namespace LojaVirtual.BLL
{
    public class CategoriaBLL
    {
        private MySqlDAL con = new MySqlDAL();

        public void Inserir(CategoriaDTO categoria)
        {
            string sql = string.Format($@"insert into categoria values (null, {categoria.Nome}, {categoria.Descricao};");
            con.ExecutarSql(sql);
        }


        public void Excluir(CategoriaDTO categoria)
        {
            string sql = string.Format($@"delete from categoria where id = { categoria.Id};");
            con.ExecutarSql(sql);
        }

        public void Alterar(CategoriaDTO categoria) 
        {
            string sql = string.Format($@"update categoria set nome = {categoria.Nome},  descricao = {categoria.Descricao};");

            con.ExecutarSql(sql);
        }

        public DataTable ConsultarID(int id)
        {
            string sql = string.Format($@"select * from categoria where id = {id}");
            return con.ExecutarConsulta(sql);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaVirtual.DAL;
using LojaVirtual.DTO;
using System.Data;

namespace LojaVirtual.BLL
{
    public class ClienteBLL
    {
        private MySqlDAL con = new MySqlDAL();

        public void Inserir(ClienteDTO cliente)
        {
            string sql = string.Format($@"insert into clientes values (null, {cliente.Nome}, {cliente.Cpf}, {cliente.Endereco},
                                       {cliente.Telefone}, {cliente.Email}, {cliente.Senha};");
            con.ExecutarSql(sql);
        }


        public void Excluir(ClienteDTO cliente)
        {
            string sql = string.Format($@"delete from clientes where id = { cliente.Id} ;");
            con.ExecutarSql(sql);
        }

        public void Alterar(ClienteDTO cliente)
        {
            string sql = string.Format($@"update clientes set nome = {cliente.Nome},  cpf = {cliente.Cpf}, 
                                       endereco = {cliente.Endereco}, telefone = {cliente.Telefone}, 
                                       email = {cliente.Email}, senha = {cliente.Senha}");
            con.ExecutarSql(sql);
        }

        public DataTable ConsultarID(int id)
        {
            string sql = string.Format($@"select * from clientes where id = {id}");
            return con.ExecutarConsulta(sql);
        }

        public void ConsultarConta(string email, string senha)
        {
            string sql = string.Format($@"select * from cliente where email = {email} and senha = {senha};");
            
        }
    }
}
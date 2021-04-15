using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaVirtual.DAL;
using LojaVirtual.DTO;
using System.Data;

namespace LojaVirtual.BLL
{
    public class FornecedorBLL
    {
        private MySqlDAL con = new MySqlDAL();

        public void Inserir(FornecedorDTO fornecedor)
        {
            string sql = string.Format($@"insert into fornecedor values (null, {fornecedor.Nome}, {fornecedor.Cnpj}, {fornecedor.Email},
                                                                        {fornecedor.Senha},{fornecedor.Telefone}, {fornecedor.NomeRepresentante},
                                                                         {fornecedor.TelefoneRepresentante};");
            con.ExecutarSql(sql);
        }


        public void Excluir(FornecedorDTO fornecedor)
        {
            string sql = string.Format($@"delete from fornecedor where id = { fornecedor.Id} ;");
            con.ExecutarSql(sql);
        }

        public void Alterar(FornecedorDTO fornecedor)
        {
            string sql = string.Format($@"update fornecedor set nome = {fornecedor.Nome},  cnpj = {fornecedor.Cnpj}, email = {fornecedor.Email}, 
                                       senha = {fornecedor.Senha}, telefone = {fornecedor.Telefone}, nomeRepresentante = {fornecedor.NomeRepresentante},
                                       telefoneRepresentante = {fornecedor.TelefoneRepresentante};");
            con.ExecutarSql(sql);
        }

        public DataTable ConsultarID(int id)
        {
            string sql = string.Format($@"select * from fornecedor where id = {id}");
            return con.ExecutarConsulta(sql);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LojaVirtual.DTO;
using LojaVirtual.BLL;

namespace LojaVirtual.UI
{
    public partial class cadProduto : System.Web.UI.Page
    {
        ProdutoDTO produtoDTO = new ProdutoDTO();
        ProdutoBLL produtoBLL = new ProdutoBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void salvar_Click(object sender, EventArgs e)
        {
            try
            {
                produtoDTO.Nome = txtNome.Text;
                produtoDTO.Descricao = descricao.Text;
                produtoDTO.Valor = Convert.ToDouble(valor.Text);
                produtoDTO.CategoriaId = Convert.ToInt32(categoria.SelectedValue.ToString());
                produtoDTO.FornecedotId = Convert.ToInt32(fornecedor.SelectedValue.ToString());
                produtoDTO.QuantidadeEstoque = Convert.ToInt32(quantidade.Text);
                produtoDTO.Foto = foto.FileName.ToString();

                produtoBLL.Inserir(produtoDTO);

                //Upload da foto para o projeto
                string loaclFoto = Server.MapPath("/IMG/Produtos" + produtoDTO.Foto);
                foto.SaveAs(loaclFoto);

                msgOK.Visible = true;
                msgOK.Text = "Produto inserido com sucesso!!!";
            }
            catch (Exception ex)
            {
                msgErro.Visible = true;
                msgErro.Text = ex.Message;
            }
        }

        protected void cancelar_Click(object sender, EventArgs e)
        {
            limmparCampos();
        }

        public void limmparCampos()
        {
            txtNome.Text = "";
            descricao.Text = "";
            valor.Text = "";
            categoria.SelectedIndex = -1;
            fornecedor.SelectedIndex = -1;
            quantidade.Text = "";
            foto.Dispose();
        }
    }
}
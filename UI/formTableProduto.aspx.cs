using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LojaVirtual.BLL;
using LojaVirtual.DTO;

namespace LojaVirtual.UI
{
    public partial class formTableProduto : System.Web.UI.Page
    {

        ProdutoBLL produtoBLL = new ProdutoBLL();
        ProdutoDTO produtoDTO = new ProdutoDTO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void ExibirGridView()
        {
            string pesquisa = "p.nome like '%" + txtPesquisar.Text + "%'";
            gridViewProduto.DataSource = produtoBLL.Pesquisar(pesquisa);
            gridViewProduto.DataBind();

        }

        protected void btnPequisar_Click(object sender, EventArgs e)
        {
            ExibirGridView();
        }


        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formCadProduto.aspx");
        }

        protected void gridViewProduto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            produtoDTO.Id = Convert.ToInt32(gridViewProduto.DataKeys[e.RowIndex].Value.ToString());
            produtoBLL.Excluir(produtoDTO);
        }

        protected void gridViewProduto_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridViewProduto.PageIndex = e.NewEditIndex;
            ExibirGridView();
        }

        protected void gridViewProduto_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            produtoDTO.Id = Convert.ToInt32(gridViewProduto.DataKeys[e.RowIndex].Value.ToString());
            produtoDTO.Nome = e.NewValues[1].ToString();
            produtoDTO.Descricao = e.NewValues[2].ToString();
            produtoDTO.Valor = Convert.ToDouble(e.NewValues[3].ToString());

            //fazer metodo para consultar o forncedor id e categoria
            produtoDTO.FornecedotId = 1;
            produtoDTO.CategoriaId = 1;

            FileUpload fotoProduto = (FileUpload)gridViewProduto.Rows[e.RowIndex].FindControl("fileUpdFoto");

            if (fotoProduto.HasFile)
            {
                string localFoto = Server.MapPath("~/IMG/Produtos/" + fotoProduto.FileName);
                fotoProduto.SaveAs(localFoto);
                produtoDTO.Foto = fotoProduto.FileName.ToString();
            }

            produtoDTO.QuantidadeEstoque = Convert.ToInt32(e.NewValues[6].ToString());

            produtoBLL.Alterar(produtoDTO);

            gridViewProduto.EditIndex = -1;
            ExibirGridView();
        }

        protected void gridViewProduto_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridViewProduto.EditIndex = -1;
            ExibirGridView();
        }
    }
}
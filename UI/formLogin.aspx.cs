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
    public partial class formLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO clienteDTO = new ClienteDTO();
                clienteDTO.Email = txtEmail.Text;
                clienteDTO.Senha = txtSenha.Text;

                ClienteBLL clienteBLL = new ClienteBLL();
                if (clienteBLL.ConsultarConta(clienteDTO.Email, clienteDTO.Senha))
                {
                    Session["emailUsuario"] = clienteDTO.Email;
                    msgOK.Visible = true;
                    msgOK.Text = "Seja bem vindo";
                    Response.Redirect("formMeuPerfil.aspx");
                }
                else
                {
                    msgErro.Visible = true;
                    msgErro.Text = "Usúario não encontrado";
                }
            }
            catch (Exception ex)
            {
                msgErro.Visible = true;
                msgErro.Text = ex.Message;
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formCadCliente");
        }

        protected void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO clienteDTO = new ClienteDTO();
                clienteDTO.Email = txtEmail.Text;
                clienteDTO.Senha = txtSenha.Text;

                ClienteBLL clienteBLL = new ClienteBLL();

                msgOK.Visible = true;
                string senha = clienteBLL.RecuperarSenha(clienteDTO.Email);
                msgOK.Text = senha;
                txtSenha.Text = senha;
            }
            catch (Exception ex)
            {
                msgErro.Visible = true;
                msgErro.Text = ex.Message;
            }

        }
    }
}
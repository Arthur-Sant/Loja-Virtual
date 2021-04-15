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
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.Email = txtEmail.Text;
            clienteDTO.Senha = txtSenha.Text;

            ClienteBLL clienteBLL = new ClienteBLL();
            clienteBLL.;
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEsqueciSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
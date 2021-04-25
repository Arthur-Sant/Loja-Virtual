 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formCadCliente.aspx.cs" Inherits="LojaVirtual.UI.formCadCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

       <nav>
            <div>
                <ul>
                    <li>
                        <!-- runat -> para rodar as tag e aparecer na tela -->
                        <asp:HyperLink ID="hyperlinkInicial" NavigateUrl="~/UI/index.aspx.cs" Text="Inicial" runat="server"></asp:HyperLink>
                    </li>

                    <li>
                         <asp:HyperLink ID="hyperLinkProdutos" NavigateUrl="~/UI/formTableProdutos.aspx" Text="Produtos" runat="server"></asp:HyperLink>
                    </li>
                    <li>
                         <asp:HyperLink ID="hyperLinkFornecedores"  NavigateUrl="~/UI/formTableFornecedores.aspx" Text="Fornecedores" runat="server"></asp:HyperLink>
                    </li>
                    <li>
                         <asp:HyperLink ID="hyperLinkLogin" NavigateUrl="~/UI/formLogin.aspx" Text="Login" runat="server"></asp:HyperLink>
                    </li>
                  
                </ul>
            </div> 
        </nav>

        <main>
            <form id="form1" runat="server">
                <div>
                    <asp:HiddenField ID="id"/>
                    
                    <div>
                        <asp:Label for="txtNome" Text="Nome" runat="server"></asp:Label>
                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label for="txtCpf" Text="Nome" runat="server"></asp:Label>
                        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label for="txtEndereco" Text="Endereço" runat="server"></asp:Label>
                        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox> 
                    </div>
                    <div>
                        <asp:Label for="txtTelefone" Text="Telefone" runat="server"></asp:Label>
                        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label for="txtEmail" Text="Email" runat="server"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label for="txtSenha" Text="Senha" runat="server"></asp:Label>
                        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                    </div>
                </div>
            </form>
        </main>

</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LojaVirtual.UI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Loja Virtual</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" 
        rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       
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
        
        <div>
        </div>

        <main>
            <asp:Image ImageUrl="~/IMG/mario.jpg" AlternateText="Imagem nãao carregada" runat="server" Height="340px" Width="603px" />
        </main>

        <footer>
            Copyright &copy; Desenvolvido por Arthur. Todos os direitos reservados
        </footer>
    </form>
</body>
</html>

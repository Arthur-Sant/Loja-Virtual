<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formCadProduto.aspx.cs" Inherits="LojaVirtual.UI.cadProduto" %>

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
                        <asp:HyperLink ID="hyperlinkInicial" NavigateUrl="~/UI/index.aspx.cs" Text="Inicial" runat="server"></asp:HyperLink>
                    </li>s

                    <li>
                         <asp:HyperLink ID="hyperLinkProdutos" NavigateUrl="~/UI/formTableProdutos.aspx" Text="Produtos" runat="server"></asp:HyperLink>
                    </li>
                    <li>
                         <asp:HyperLink ID="hyperLinkFornecedores"  NavigateUrl="~/UI/formPrincipal.aspx" Text="Menu" runat="server"></asp:HyperLink>
                    </li>
                    <li>
                         <asp:HyperLink ID="hyperLinkLogin" NavigateUrl="~/UI/formLogin.aspx" Text="Login" runat="server"></asp:HyperLink>
                    </li>
                  
                </ul>
            </div> 
        </nav>

    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="id" runat="server"/>

            <div>
                <asp:Label for="txtNome" Text="Nome" runat="server"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="descricao" Text="Descrição" runat="server"></asp:Label>
                <asp:TextBox ID="descricao" TextMode="MultiLine" Columns="30" Rows="10" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="valor" Text="Valor" runat="server"></asp:Label>
                <asp:TextBox ID="valor" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="categoria" Text="Categoria" runat="server"></asp:Label>
                <asp:DropDownList ID="categoria" runat="server"></asp:DropDownList>
            </div>

            <div>
                <asp:Label for="fornecedor" Text="Fornecedor" runat="server"></asp:Label>
                <asp:DropDownList ID="fornecedor" runat="server"></asp:DropDownList>
            </div>

            <div>
                <asp:Label for="quantidade" Text="Quantidade" runat="server"></asp:Label>
                <asp:TextBox ID="quantidade" runat="server"></asp:TextBox>
            </div>

             <div>
                <asp:Label for="foto" Text="Foto" runat="server"></asp:Label>
                <asp:FileUpload ID="foto" runat="server"></asp:FileUpload>
            </div>

            <div>
                <asp:Button ID="salvar" Text="Salvar" runat="server" OnClick="salvar_Click" />
                <asp:Button ID="cancelar" Text="Cancelar" runat="server" OnClick="cancelar_Click" />
            </div>

            <div>
                 <asp:Label Text="" ID="msgOK" Visible="false" ForeColor="Green" runat="server"></asp:Label>
                 <asp:Label Text="" ID="msgErro" Visible="false" ForeColor="Red" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formTableProduto.aspx.cs" Inherits="LojaVirtual.UI.formTableProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:TextBox ID="txtPesquisar" placeholder="Pesquisar por parte do nome" runat="server"></asp:TextBox>
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar Produto" OnClick="btnCadastrar_Click"/>
            <asp:Button ID="btnPequisar" runat="server" Text="Pesquisar" OnClick="btnPequisar_Click"/>
        </div>
        

        <div>
            <asp:GridView ID="gridViewProduto"
                AutoGenerateColumns="false" 
                OnRowDeleting="gridViewProduto_RowDeleting"
                OnRowCancelingEdit="gridViewProduto_RowCancelingEdit"
                OnRowEditing="gridViewProduto_RowEditing"
                OnRowUpdating="gridViewProduto_RowUpdating"
                DataKeyNames="id"
                runat="server">

                <Columns>

                    <asp:TemplateField HeaderText="Código">
                        <ItemTemplate>
                            <asp:Label ID="labelCod" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nome">
                        <ItemTemplate>
                            <asp:Label ID="labelNome" runat="server" Text='<%# Eval("nome") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textNome" Text='<%# Bind("nome") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Descrição">
                        <ItemTemplate>
                            <asp:Label ID="labelDesc" runat="server" Text='<%# Eval("descricao") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textDesc" Text='<%# Bind("descricao") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Categoria">
                        <ItemTemplate>
                            <asp:Label ID="labelCategoria" runat="server" Text='<%# Eval("categoria") %>' ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Fornecedor">
                        <ItemTemplate>
                            <asp:Label ID="labelForne" runat="server" Text='<%# Eval("fornecedor") %>' ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Foto">
                        <ItemTemplate>
                            <asp:Image ID="labelFoto" ImageUrl='<%# "~/IMG/Produtos" + Eval("foto") %>' Width="240" Height="160" runat="server" ></asp:Image>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:FileUpload ID="fileUpdFoto" ImageUrl='<%# Bind("foto")%>' runat="server"/>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Quantidade">
                        <ItemTemplate>
                            <asp:Label ID="labelQuant" runat="server" Text='<%# Eval("quantidadeEstoque") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtQuantidade" Text='<%# Bind("quantidadeEstoque") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ShowDeleteButton="true" ButtonType="Image" DeleteImageUrl="~/IMG/trash.png" DeleteText="Excluir" runat="server"/>

                    <asp:CommandField ShowEditButton="true" ButtonType="Image" EditImageUrl="~/IMG/edit.png" EditText="Editar" 
                        CancelImageUrl="~/IMG/cancel.png" UpdateImageUrl="~/IMG/update.png" runat="server"/>

                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>

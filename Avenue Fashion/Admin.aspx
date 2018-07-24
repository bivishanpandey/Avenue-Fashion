<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Avenue_Fashion.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titleContent" runat="server">
    AVENUE FASHION | ADMIN
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContent" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col font-color">
                <asp:HiddenField ID="HiddenUserID" runat="server" />
                <div class="wrapper">
                    <div class="form-signin">
                        <asp:Label ID="Label1" runat="server" Text="Email" CssClass="font-weight-bold"></asp:Label>
                        <asp:TextBox ID="txtEmail" type="email" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:Label ID="Label3" runat="server" Text="Password" CssClass="font-weight-bold"></asp:Label>
                        <asp:TextBox ID="txtPassword" type="" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:Button ID="btnSave" runat="server" Text="SAVE" OnClick="btnSave_Click" CssClass="btn btn-block btn-primary btn-light" />
                        <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" CssClass="btn btn-block btn-primary btn-light"/>
                        <asp:Button ID="btnClear" runat="server" Text="CLEAR" OnClick="btnClear_Click" CssClass="btn btn-block btn-primary btn-light"/>
                        <asp:Label ID="lblSuccessMessage" runat="server" Text="" CssClass="font-weight-bold" ForeColor="Green"></asp:Label>
                        <asp:Label ID="lblErrorMessage" runat="server" Text="" CssClass="font-weight-bold" ForeColor="Red"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col font-color">
                <div class="wrapper">
                    <asp:GridView CssClass="table table-responsive table-hover" ID="gvUsers" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:BoundField DataField="Password" HeaderText="Password" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkView" runat="server" CssClass="nav-link" ForeColor="DarkGreen" CommandArgument='<%# Eval("UserID") %>' OnClick="lnkView_OnClick">View</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Avenue_Fashion.Pages.Sign_Up" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titleContent" runat="server">
    AVENUE FASHION | ACCOUNT
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContent" runat="server">
    <img src="Images/6-Sign%20Up/6-Sign-Up_02.png" class="img-fluid"/>
    <div class="container">
        <div class="row font-color justify-content-center">
            <div class="col">
                <div class="wrapper">
                    <div class="form-signin">       
                        <h2 class="form-signin-heading font-weight-bold"><i class="fa fa-sign-in">SIGN IN</i></h2>
                        <asp:HiddenField ID="HiddenUserID" runat="server" />
                        <h6 class="font-weight-bold"><i class="fa fa-envelope">Your Email...</i></h6>
                        <asp:TextBox ID="userNameBox" type="email" CssClass="form-control" runat="server"></asp:TextBox>
                        <h6 class="font-weight-bold"><i class="fa fa-key">Your Password...</i></h6>
                        <asp:TextBox ID="passwordBox" type="password" CssClass="form-control" runat="server"></asp:TextBox>
                        <label class="font-small">
                            <input id="remMe" type="checkbox" class="fa fa-check-square"/> Remember me
                        </label><br />
                        <asp:Label ID="scsLabel" runat="server" Text="" CssClass="font-small font-weight-bold" ForeColor="Green"></asp:Label><br />
                        <asp:Label ID="errLabel" runat="server" Text="" CssClass="font-small font-weight-bold" ForeColor="Red"></asp:Label><br />
                        <a href="#" class="font-italic font-weight-light">Forgot Password?</a>
                        <asp:Button ID="signInBtn" CssClass="btn btn-lg btn-primary btn-block" style="background-color:#00C8C8" BorderStyle="None" runat="server" Text="SIGN IN" OnClick="signInBtn_Click" />
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="wrapper">
                    <div class="form-signin">       
                        <h2 class="form-signin-heading font-weight-bold"><i class="fa fa-user-plus">REGISTER</i></h2>
                        <h6 class="font-weight-bold"><i class="fa fa-envelope">Your Email...</i></h6>
                        <asp:TextBox ID="createUserNameBox" type="email" CssClass="form-control" runat="server"></asp:TextBox>
                        <h6 class="font-weight-bold"><i class="fa fa-key">Your Password...</i></h6>
                        <asp:TextBox ID="createPasswordBox" type="password" CssClass="form-control" runat="server"></asp:TextBox>
                        <h6 class="font-weight-bold"><i class="fa fa-key">Confirm Password...</i></h6>
                        <asp:TextBox ID="confirmPasswordBox" type="password" CssClass="form-control" runat="server"></asp:TextBox>
                        <label class="checkbox font-small">
                            <input id="signUpUpdates" type="checkbox" /> Sign up for exclusive updates, discounts, new arrivals, contests, and more!
                        </label><br />
                        <asp:Label ID="createScsLabel" runat="server" Text="" CssClass="font-small font-weight-bold" ForeColor="Green"></asp:Label><br />
                        <asp:Label ID="createErrLabel" runat="server" Text="" CssClass="font-small font-weight-bold" ForeColor="Red"></asp:Label><br />
                        <asp:Button ID="createAccBtn" CssClass="btn btn-lg btn-primary btn-block" runat="server" Text="CREATE ACCOUNT" OnClick="createAccBtn_Click" />
                        <label class="font-small">
                            By clicking 'Create Account', you agree to our <a href="#" class="font-italic">Privacy Policy</a>
                        </label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

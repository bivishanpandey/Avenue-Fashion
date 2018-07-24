<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="LocalStores.aspx.cs" Inherits="Avenue_Fashion.Pages.Local_Stores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titleContent" runat="server">
    AVENUE FASHION | LOCAL STORES
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContent" runat="server">
    <img src="Images/3-Local%20Stores/3-Local-Stores_02.png" class="img-fluid"/>
    <div class="container">
        <div class="row justify-content-center text-center font-color">
            <div class="col">
                <div class="jumbotron" style="background-color:transparent !important">
                    <h4 class="font-weight-bold">LONDON</h4>
                    <h6 class="font-weight-bold">180-182 REGENT STREET, LONDON, W1B 5BT</h6>
                    <asp:Button ID="viewMoreBtn1" CssClass="btn btn-lg btn-primary btn-block" style="background-color:#343a40 " BorderStyle="None" runat="server" Text="VIEW MORE!" />
                </div>
            </div>
            <div class="col">
                <div class="jumbotron" style="background-color:transparent !important">
                    <h4 class="font-weight-bold">NEW YORK</h4>
                    <h6 class="font-weight-bold">109 COLUMBUS CIRCLE, NEW YORK, NY 10023</h6>
                    <asp:Button ID="viewMoreBtn2" CssClass="btn btn-lg btn-primary btn-block" style="background-color:#00C8C8" BorderStyle="None" runat="server" Text="VIEW MORE!" />
                </div>
            </div>
            <div class="col">
                <div class="jumbotron" style="background-color:transparent !important">
                    <h4 class="font-weight-bold">PARIS</h4>
                    <h6 class="font-weight-bold">2133 RUE SAINT-HONORE, 75001 PARIS</h6>
                    <asp:Button ID="viewMoreBtn3" CssClass="btn btn-lg btn-primary btn-block" style="background-color:#0069d9" BorderStyle="None" runat="server" Text="VIEW MORE!" />
                </div>
            </div>
        </div>
    </div>
    <iframe frameborder="0" width="100%" height="300px" src="https://www.google.com/maps/embed?pb=!1m16!1m12!1m3!1d193572.00379171042!2d-73.97800350000001!3d40.70563080000002!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!2m1!1s87-89+E+4th+St%2C+New+York%2C+NY+10003%2C+Stati+Uniti!5e0!3m2!1sit!2sit!4v1416499866904">
    </iframe>
</asp:Content>

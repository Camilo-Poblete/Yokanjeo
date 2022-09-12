<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="YOKANJEO.Admin.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0" />

 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
 <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <link href="css/Style.css" rel="stylesheet" />
    <link href="css/Admin.css" rel="stylesheet" />
         <link rel="icon" type="imagen" href="../../Account/imagen/Icono.jpg"   />

    <style>
        body{
            background:url(../Images/casa4.jpg);
            background-repeat:no-repeat;
            background-size:cover
        }
    </style>

  <%--  <a href="images/imagen.png">content</a>--%>

    <title>   Inicio de Sesion </title>
</head>
  <br />
   <br />
     <br />
         <br />


    
</head>
     

        <div class="loginbox">
       <img src="../Images/Icono.jpg" alt="Alternate Text" class="user"/>

        
               <h1>       Iniciar Admin  </h1>
       <form runat="server">
           <asp:Label Text="Usuario" CssClass="lblUser" runat="server" />
           <asp:TextBox runat="server" ID="tbAdmin" CssClass="classUser" placeholder="Ingrese Admin"></asp:TextBox>

            <asp:Label Text="Contraseña"  CssClass="lblpass" runat="server" />

             <asp:TextBox runat="server" ID="tbClave" CssClass="classPass" type="Password" placeholder="************" />

          <asp:Button Text="Iniciar Sesion" CssClass="Btnsubmit" runat="server" OnClick="Iniciar" />
          
       <asp:LinkButton Text="¿Olvido su contraseña?" CssClass="btnforget" runat="server"  />
           

          <%-- <asp:Button runat="server" Text="Registrate" CssClass="btnforget" Onclick="Cuenta"  />--%>
             
           </div>
        <br />
        <br />
        <div>
            <asp:Label runat="server" ID="lblError" class="alert-danger"></asp:Label>
            
              
            
            
            <br />
       </form>
   </div>

        </div>
   
   

    <body>


    </body>

        
    
       


</html>
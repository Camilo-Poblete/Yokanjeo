<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Iniciar_sesion.aspx.cs" Inherits="Yokanjeo.Page.Iniciar_sesion" %>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Iniciar Sesion</title>


    <!-- LInk To CSS -->
  
    <link href="Iniciar_sesion/css/login.css" rel="stylesheet" />

     <link rel="icon" type="imagen" href="../Images/Icono.jpg"   />
    <!-- Box Icons -->
    <link rel="stylesheet"
  href="https://cdn.jsdelivr.net/npm/boxicons@latest/css/boxicons.min.css">
</head>
<body>





    


    <!-- Navbar -->
    <header>
        <div class="nav container">
            <!-- Logo -->
            
           <figure>
                <a href="../Home/Home.aspx" class="logo">
        <img src="../Images/YOKANJEO.JPG" width="186px" height="60px" alt="">
    </a>
               
    </figure>
         <%--   <a href="index.html" class="logo"><i class='bx bx-home'></i>R State</a>--%>
           
            <!-- Log In Button -->
           
        </div>

    </header>
    
    <form runat="server">
    <!-- Log In -->
    <div class="login container">
        <div class="login-container">
            <h2>Login To Continue</h2>
            <p>Log in with your data that you entered <br>during your registration</p>
            <!-- Login Form -->
            <form action="">
                <span>Enter your email address</span>
               <asp:TextBox runat="server" ID="tbUsuario" CssClass="classUser" placeholder="Ingrese Usuario" ></asp:TextBox>
                <span>Enter your password</span>
                 <asp:TextBox runat="server" ID="tbClave" CssClass="classPass" type="Password" placeholder="************" />
                <asp:Button Text="Iniciar Sesion" CssClass="btn" runat="server" OnClick="Iniciar" />
                 <asp:LinkButton Text="¿Olvido su contraseña?" CssClass="btnforget" runat="server"  />
                <%--<asp:LinkButton placeholder="¿Olvido su contraseña?" CssClass="alert"  runat="server"   />--%>
                 <asp:Label runat="server" ID="lblError" class="alert-danger"></asp:Label>
             <asp:Button Text="Registrate" CssClass="btn" runat="server" OnClick="Cuenta" />
            </form>
         
        </div>
        
        </form>


        <!-- Log In Image -->
        <div class="login-image">
            <img src="../Images/house_PNG52.png" alt="">
        </div>
    </div>
    
    <!-- Footer -->
    <section class="footer">
        <div class="footer-container container">
            <h2>Yokanjeo</h2>
            <div class="footer-box">
                <h3>Enlaces rápidos</h3>
                <a href="#">Agencia</a>
                <a href="#">Edificio</a>
                <a href="#">Precios</a>
            </div>
            <div class="footer-box">
                <h3>Localizaciones</h3>
                <a href="#">La florida</a>
                <a href="#">Las Condes</a>
                <a href="#">Santiago centro</a>
            </div>
            <div class="footer-box">
                <h3>Contacto</h3>
                <a href="#">+44 (0)800 123 4567</a>
                <a href="#">Yokanjeo@gmail.com</a>
                <div class="social">
                    <a href="#"><i class='bx bxl-facebook' ></i></a>
                    <a href="#"><i class='bx bxl-twitter' ></i></a>
                    <a href="#"><i class='bx bxl-instagram' ></i></a>
                </div>
            </div>
        </div>
    </section>
    <!-- Copyright -->
    <div class="copyright">
        <p>&#169; Yokanjeo All Right Reserved</p>
    </div>

    
</body>
</html>
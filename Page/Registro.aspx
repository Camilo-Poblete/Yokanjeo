<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Yokanjeo.Page.Registro" %>

<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,700&display=swap" rel="stylesheet">
    <link href="https://unpkg.com/ionicons@4.5.10-0/dist/css/ionicons.min.css" rel="stylesheet">


      <link href="Registro/style2.css" rel="stylesheet" />

    <link rel="icon" type="imagen" href="../Images/Icono.jpg"   />
    <title>Registro</title>
  </head>
  <body>
   <section class="contact-box">

  



       <form runat="server">
           <div class="col-xl-7 col-lg-12 d-flex">
                <div class="container align-self-center p-6">
                    <h1 class="font-weight-bold mb-3">Crea tu cuenta en YOKANJEO</h1>
                    <div class="form-group">
                      
                    </div>
                    <p class="text-muted mb-5">Ingrese la siguiente información para registrarte.</p>

                    <form>
                        <div class="form-row mb-2">
                            <div class="form-group col-md-6">
                                <label class="font-weight-bold">Nombre Completo <span class="text-danger">*</span></label>
                                <asp:TextBox ID="txbNombre" CssClass="form-control" runat="server" placeholder="ej Camilo etc"></asp:TextBox>
                            </div>
                            <div class="form-group col-md-6">
                                <label class="font-weight-bold">Correo <span class="text-danger">*</span></label>
                                <asp:TextBox  ID="txbCorreo" CssClass="form-control" runat="server" placeholder="ej camilo@gmail.com"></asp:TextBox>
                            </div>
                        </div>

                          <div class="form-row mb-2">
                            <div class="form-group col-md-6">
                                <label class="font-weight-bold">Comuna <span class="text-danger">*</span></label>
                                      <asp:DropDownList ID="ddlComuna" runat="server" class="form-control" ></asp:DropDownList>
                            </div>
                            <div class="form-group col-md-6">
                                <label class="font-weight-bold">Fecha <span class="text-danger">*</span></label>
                                 <asp:TextBox ID="tbFecha" CssClass="form-control" runat="server" TextMode="Date" placeholder="ej Materno"></asp:TextBox>
                            </div>
                        </div>

                          <div class="form-row mb-2">
                            <div class="form-group col-md-6">
                                <label class="font-weight-bold">Foto <span class="text-danger">*</span></label>
                               <asp:Image runat="server" CssClass="img-thumbnail" Width="100" Height="100" ImageUrl="~/Images/user2.jpg" />
                                <br />
    <br />
                             <asp:FileUpload runat="server" CssClass=" small " ID="FUImage" onchange="mostrarimagen(this)" />
                               
                                <br />
                            </div>
                              <br />
                            <div class="form-group col-md-6">
                                <label class="font-weight-bold">Usuario <span class="text-danger">*</span></label>
                                <asp:TextBox  ID="txbUsuario" CssClass="form-control" runat="server" placeholder="ej camilo@gmail.com"></asp:TextBox>
                            </div>
                        </div>

                          <div class="form-row mb-2">
                            <div class="form-group col-md-6">
                                <label class="font-weight-bold">Contraseña <span class="text-danger">*</span></label>
                                 <asp:TextBox ID="tbClave" CssClass="form-control" runat="server" TextMode="Password" placeholder=" ************ "></asp:TextBox>
                            </div>
                            <div class="form-group col-md-6">
                                <label class="font-weight-bold">Repetir Contraseña <span class="text-danger">*</span></label>
                      <asp:TextBox ID="tbClave2" CssClass="form-control" runat="server" TextMode="Password" placeholder=" ************ "></asp:TextBox>
                            </div>
                        </div>
                         
                        </form>


                        <asp:Label  runat="server" CssClass="alert-alert-danger" ID="Label1"></asp:Label>
                  <br />
                     <asp:Button runat="server" Class="btn  btn-warning" Width="150" Text="Registrarse" OnClick="Registrar" />
                       <asp:Button runat="server" Class="btn  btn-warning" Width="150" Text="Cancelar" OnClick="Cancelar" />
                    </form>
                  <asp:Label  runat="server" CssClass="alert-alert-danger" ID="lblError"></asp:Label>
                </div>
           </div>
       </div>
   </section>


    <!-- Footer -->
    <section class="footer">
        <div class="footer-container container">
            <h2>Yokanjeo</h2>
            <div class="footer-box">
                <h3>Quick Links</h3>
                <a href="#">Agency</a>
                <a href="#">Building</a>
                <a href="#">Rates</a>
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
        <p>&#169; YOKANJEO All Right Reserved</p>
    </div>




    
</body>
</html>
<%@ Page Title="" Language="C#" MasterPageFile="~/Page/MP.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Yokanjeo.Page.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">


 <div class="container">
        <fieldset class="row">
            <div class="container text-black-50 row">
                <div class="col-6 row justify-content-center">
                    <div class="align-items-center col-auto">
                        <fieldset>
                            <div class="row">
                             <asp:Image runat="server" ID="image" CssClass="form-control img-thumbnail" Height="300"  />
                            </div>
                            <br />
                            <div class="row">
                                  <asp:FileUpload runat="server" ID="FUImage" CssClass="form-control form-control-sm" />
                            </div>
                            <br />
                            <div class="row">

                         <asp:Button runat="server" ID="BtnAplicar" CssClass="form-control btn btn-dark" Text="Aplicar Cambios" OnClick="BtnAplicar_Click" />
                            </div>
                        </fieldset>

                    </div>
                    <div class="row">
                        <asp:Label ID="lblError" runat="server" CssClass="alert-danger" ></asp:Label>


                    </div>
                </div>
                <div class="col-6 row justify-content-center">
                       <div class="align-items-center col-auto">
                           <fieldset>
                               <legend> 
                                   <i class="fa fa-database"> Datos personales </i>
                               </legend>
                               <asp:Table  runat="server" Enabled="false">
                                  <asp:TableRow>
                                      <asp:TableCell>
                                          <asp:Label  runat="server" CssClass="col-form-label" Text="Nombres"></asp:Label>
                                      </asp:TableCell>
                                      <asp:TableCell>
                                          <asp:Button runat="server" CssClass="form-control" ID="txbNombre" />
                                      </asp:TableCell>
                                  </asp:TableRow>

                                  <asp:TableRow>
                                      <asp:TableCell>
                                            <asp:Label  runat="server" CssClass="col-form-label" Text="Correo"></asp:Label>
                                      </asp:TableCell>
                                      <asp:TableCell>
                                            <asp:Button runat="server" CssClass="form-control" ID="txbCorreo" />
                                      </asp:TableCell>
                                  </asp:TableRow>

                                  <asp:TableRow>
                                      <asp:TableCell>
                                           <asp:Label  runat="server" CssClass="col-form-label" Text="Comuna"></asp:Label>
                                      </asp:TableCell>
                                      <asp:TableCell>
                                           <asp:Button runat="server" CssClass="form-control" ID="txbComuna" />
                                      </asp:TableCell>
                                  </asp:TableRow>

                                      <asp:TableRow>
                                      <asp:TableCell>
                                           <asp:Label  runat="server" CssClass="col-form-label" Text="Fecha de creacion"></asp:Label>
                                      </asp:TableCell>
                                      <asp:TableCell>
                                           <asp:Button runat="server" CssClass="form-control" ID="tbFecha" />
                                      </asp:TableCell>
                                  </asp:TableRow>


                               </asp:Table>

                           </fieldset>
                </div>
            </div>

        </fieldset>
        <br />
        <fieldset>
            <legend>
                <i class="fa fa-key">Datos de sesion</i>
            </legend>

            <asp:Table  runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label  runat="server" CssClass="col-fom-label" Text="Usuario:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>

                  <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox runat="server" CssClass="form-control" ID="txbUsuario" Enabled="false"></asp:TextBox>

                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Button  runat="server" CssClass="form-control btn btn-warning" ID="BtnCambiar" Text="Cambiar contraseña" OnClick="BtnCambiar_Click"></asp:Button>
                    </asp:TableCell>
                       <asp:TableCell>
                             <asp:Button  runat="server" CssClass="form-control btn btn-success" ID="btnGuardar" Text="Guardar" OnClick="BtnGuardar_Click" Visible="false" ></asp:Button>
                 
                            </asp:TableCell>
                </asp:TableRow>


            </asp:Table>
            <asp:Table runat="server" ID="contrasenia" Visible="false" >
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label  runat="server" CssClass="col-form-label" Text="Contraseña:"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox  runat="server" CssClass="form-control" ID="tbClave" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                     </asp:TableCell>
                </asp:TableRow>

                  <asp:TableRow>
                    <asp:TableCell>
                         <asp:Label  runat="server" CssClass="col-form-label" Text="Repetir Contraseña:"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                              <asp:TextBox  runat="server" CssClass="form-control" ID="tbClave2" placeholder=" Nueva Contraseña" TextMode="Password"></asp:TextBox>
                     </asp:TableCell>
                </asp:TableRow>

            </asp:Table>

            <asp:Label runat="server" ID="lblErrorClave" CssClass="alert-danger"></asp:Label>




          
           
        </fieldset>


    </div>
    
    </div>
    
    </div>
       </fieldset>
    <br />
    <br />

    <div class="container d-flex justify-content-end">
        <asp:Button  runat="server" Class="btn btn-danger" Text="Eliminar cuenta" OnClick="Eliminar" />
    </div>









</asp:Content>





using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yokanjeo.Page
{
    public partial class Perfil : System.Web.UI.Page
    {

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public static int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Session["usuariologueado"].ToString());
            if (Session["usuariologueado"] == null)
            {
                Response.Redirect("../Page/Iniciar_sesion.aspx");
            }
            else
            {

                using (SqlCommand cmd = new SqlCommand("Perfil", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        image.ImageUrl = "../Page/FmImagen.aspx?id=" + id;
                        this.txbNombre.Text = dr["Nombre_completo"].ToString();
                        this.txbCorreo.Text = dr["Correo"].ToString();
                        this.txbComuna.Text = dr["Comuna"].ToString();
                        this.tbFecha.Text = dr["Fecha"].ToString();
                        //tbFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        this.txbUsuario.Text = dr["Usuario"].ToString();

                        dr.Close();
                    }
                    con.Close();

                }
            }
        }




        void MetodoOcultar()
        {
            if (contrasenia.Visible == false)
            {
                contrasenia.Visible = true;
                btnGuardar.Visible = true;
                BtnCambiar.Text = "Cancelar";
                lblErrorClave.Text = "";
            }
            else
            {
                contrasenia.Visible = false;
                btnGuardar.Visible = false;
                BtnCambiar.Text = "Cambiar contraseña";
                lblErrorClave.Text = "";
            }
        }



        protected void BtnAplicar_Click(object sender, EventArgs e)
        {
            int tamanioarchivo;
            byte[] imagen = FUImage.FileBytes;
            tamanioarchivo = int.Parse(FUImage.FileContent.Length.ToString());
            if (tamanioarchivo >= 2097151000)
            {
                lblError.Text = "El tamaño de la imagen debe ser menor a 10 Mb!";
            }
            else if (FUImage.HasFile)
            {
                SqlCommand cmd = new SqlCommand("CambiarImagen", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@Imagen", SqlDbType.Image).Value = imagen;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                con.Open();
                cmd.ExecuteNonQuery();
                lblError.Text = "";
                con.Close();
            }
            else
            {
                lblError.Text = "No se ha cargado una imagen de perfil nueva!";
            }
        }



        protected void BtnCambiar_Click(object sender, EventArgs e)
        {
            MetodoOcultar();
        }




        protected void Eliminar(object sender, EventArgs e)
        {
            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("Eliminar", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Session.Remove("usuariologueado");
                    Response.Redirect("../Page/Iniciar_sesion.aspx");
                }
            }
        }






        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            string contraseniasinverificar = tbClave.Text;
            Regex letras = new Regex(@"[a-zA-Z]");
            Regex numeros = new Regex(@"[0-9]");
            Regex especiales = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]{|}~]");



            if (tbClave.Text == "" || tbClave2.Text == "")
            {
                lblError.Text = "Los campos no pueden quedar vacios!";
            }


            else if (tbClave.Text != tbClave2.Text)
            {
                lblError.Text = "Las contraseñas no coinciden!";
            }
            else if (!letras.IsMatch(contraseniasinverificar))
            {
                lblError.Text = "La contraseña debe contener letras!";
            }
            else if (!numeros.IsMatch(contraseniasinverificar))
            {
                lblError.Text = "La contraseña debe contener numeros!";
            }

            else if (!especiales.IsMatch(contraseniasinverificar))
            {
                lblError.Text = "La contraseña debe contener caracteres especiales!";
            }
            else
            {
                try
                {
                    using (con)
                    {
                        using (SqlCommand cmd = new SqlCommand("CambiarContrasenia", con))
                        {
                            string patron = "InmoYOKA";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            cmd.Parameters.Add("@Clave", SqlDbType.VarChar).Value = tbClave.Text;
                            cmd.Parameters.Add("@Patron", SqlDbType.VarChar).Value = patron;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MetodoOcultar();
                            lblErrorClave.Text = "";
                        }
                    }

                }
                catch (Exception ex)
                {

                    lblErrorClave.Text = ex.Message;

                }
            }
        }
    }
}











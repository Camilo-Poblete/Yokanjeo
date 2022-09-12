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
    public partial class Registro : System.Web.UI.Page
    {

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cascada();
            }
        }




        protected void Cancelar(object sender, EventArgs e)
        {

            Response.Redirect("../Page/Iniciar_sesion.aspx");

        }


        protected void Registrar(object sender, EventArgs e)
        {
            int tamanioimagen = int.Parse(FUImage.FileContent.Length.ToString());
            string contraseniasinverificar = tbClave.Text;
            string correoverificar = txbCorreo.Text;
            Regex letras = new Regex(@"[a-zA-]");
            Regex numeros = new Regex(@"[0-9]");
            Regex especiales = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]{|}~]");


            con.Open();

            SqlCommand usuario = new SqlCommand("ContarUsuario", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            usuario.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txbUsuario.Text;
            int user = Convert.ToInt32(usuario.ExecuteScalar());
            if (txbNombre.Text == "" || txbCorreo.Text == "" || ddlComuna.Text == "" || tbFecha.Text == "" /*|| txbUsuario.Text == ""*/)
            {
                lblError.Text = "Los campos no pueden quedar vacios!";
            }


            else if (user > 1)
            {
                lblError.Text = "El  usuario " + txbUsuario.Text + "ya  existe!";
            }

            else if (!letras.IsMatch(correoverificar))
            {
                lblError.Text = "El correo  debe contener letras!";
            }


            else if (!especiales.IsMatch(correoverificar))
            {
                lblError.Text = "El correo debe contener caracteres especiales!";
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

            else if (!FUImage.HasFile)
            {
                lblError.Text = "No se ha cargado una imagen de perfil!";
            }
            else if (tamanioimagen >= 2097151000)
            {
                lblError.Text = "El tamaño de la imagen no puede ser mayor a 10 MB";
            }
            else
            {

                byte[] imagen = FUImage.FileBytes;
                string patron = "InmoYOKA";
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand("Registrar", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Nombres_completo", SqlDbType.VarChar).Value = txbNombre.Text;
                        cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = txbCorreo.Text;
                        cmd.Parameters.Add("@Comuna", SqlDbType.VarChar).Value = ddlComuna.Text;
                        cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = tbFecha.Text;
                        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txbUsuario.Text;
                        cmd.Parameters.Add("@Clave", SqlDbType.VarChar).Value = tbClave.Text;
                        cmd.Parameters.Add("@Patron", SqlDbType.VarChar).Value = patron;
                        cmd.Parameters.Add("@Imagen", SqlDbType.Image).Value = imagen;
                        cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = 0;
                        cmd.ExecuteNonQuery();


                    }
                    con.Close();
                    Response.Redirect("../Home/Home.aspx");


                }

            }

        }


        string conn = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        protected void cascada()
        {
            SqlConnection sqlconn = new SqlConnection(conn);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand("select comuna from Usuarios", sqlconn);
            sqlcomm.CommandType = CommandType.Text;
            ddlComuna.DataSource = sqlcomm.ExecuteReader();
            ddlComuna.DataTextField = "Comuna";

            ddlComuna.DataBind();
            ddlComuna.Items.Insert(0, new ListItem(" Seleccionar comuna ", "0"));
        }
    }

}


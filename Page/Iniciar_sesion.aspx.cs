using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yokanjeo.Page
{
    public partial class Iniciar_sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);





        protected void Iniciar(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "" || tbClave.Text == "")
            {
                lblError.Text = "Los campos no pueden quedar vacios!";
            }
            else
            {
                string patron = "InmoYOKA";
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand("Validar", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = tbUsuario.Text;
                        cmd.Parameters.Add("@Clave", SqlDbType.VarChar).Value = tbClave.Text;
                        cmd.Parameters.Add("@Patron", SqlDbType.VarChar).Value = patron;
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Session["usuariologueado"] = dr["Id_usuarios"].ToString();
                            Response.Redirect("../Principales/Principal");

                        }
                        else
                        {
                            lblError.Text = "Usuario o Contraseña incorrecta!";
                        }
                        con.Close();
                    }
                }
            }

        }
        


        protected void Cuenta(object sender, EventArgs e)
        {
            Response.Redirect("../Page/Registro.aspx");
        }
    }

}

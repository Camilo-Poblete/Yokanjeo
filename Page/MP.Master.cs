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
    public partial class MP : System.Web.UI.MasterPage
    {

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuariologueado"] != null)
            {
                int id = int.Parse(Session["usuariologueado"].ToString());
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand("Perfil", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                        dr.Read();
                        this.lblUsuario.Text = dr["Nombre_completo"].ToString();
                        imgPerfil.ImageUrl = "../Page/FmImagen.aspx?id=" + id;
                    }
                }
            }
            else
            {
                Response.Redirect("../Page/Iniciar_sesion.aspx");
            }
        }






        protected void Perfiles(object sender, EventArgs e)
        {
            Response.Redirect("../Page/Perfil.aspx");
        }




        protected void Salir(object sender, EventArgs e)
        {
            Session.Remove("usuariologueado");
            Response.Redirect("../Page/Iniciar_sesion.aspx");
        }
    }


}
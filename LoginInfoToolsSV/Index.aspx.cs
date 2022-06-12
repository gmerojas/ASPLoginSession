﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginInfoToolsSV
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuariologueado"] != null)
            {
                string usuariologueado = Session["usuariologueado"].ToString();
                lblBienvenida.Text = "Bienvenido/a " + usuariologueado;
            }
            else
            {
                Response.Redirect("LoginInfoToolsSV.aspx");
            }
        }

        protected void btnCerrarSession_Click(object sender, EventArgs e)
        {
            Session.Remove("usuariologueado");
            Response.Redirect("LoginInfoToolsSV.aspx");
        }
    }
}
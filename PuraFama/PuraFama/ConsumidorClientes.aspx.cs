using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuraFama
{
    public partial class ConsumidorClientes : System.Web.UI.Page
    {
        RS_BD.DataBase_WSSoapClient WS = new RS_BD.DataBase_WSSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = WS.ListarCliente();
            grd_leerCliente.Visible = true;
            grd_leerCliente.DataSource = ds.Tables[0];
            grd_leerCliente.DataBind();

        }

        protected void btn_CrearCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int rutCliente = Convert.ToInt32(txt_rutCliente.Text);
                string nombreCliente = txt_nombreCliente.Text;
                int telefonoCliente = Convert.ToInt32(txt_telefonoCliente.Text);
                int gastosCliente = Convert.ToInt32(txt_gastosCliente.Text);
                DataSet ds = WS.CrearCliente(rutCliente, nombreCliente, telefonoCliente, gastosCliente);
                ds = WS.ListarCliente();
                grd_leerCliente.Visible = true;
                grd_leerCliente.DataSource = ds.Tables[0];
                grd_leerCliente.DataBind();
            }
            catch (Exception ex)
            {
                grd_leerCliente.Visible = true;
            }
            
        }

        protected void btn_leerCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int rutCliente = Convert.ToInt32(txt_rutClienteFiltrar.Text);
                DataSet leerCliente = WS.LeerCliente(rutCliente);
                grd_leerCliente.Visible = true;
                grd_leerCliente.DataSource = leerCliente.Tables[0];
                grd_leerCliente.DataBind();
            }catch(Exception ex)
            {
                grd_leerCliente.Visible = true;
            }
            

        }

        protected void btn_actualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int rutCliente = Convert.ToInt32(txt_rutClienteActualizar.Text);
                string nombreCliente = txt_nombreClienteActualizar.Text;
                int telefonoCliente = Convert.ToInt32(txt_telefonoClienteActualizar.Text);
                int gastosCliente = Convert.ToInt32(txt_gastosClienteActualizar.Text);
                DataSet ds = WS.ActualizarCliente(rutCliente, nombreCliente, telefonoCliente, gastosCliente);
                ds = WS.ListarCliente();
                grd_leerCliente.Visible = true;
                grd_leerCliente.DataSource = ds.Tables[0];
                grd_leerCliente.DataBind();
            }
            catch (Exception ex)
            {
                grd_leerCliente.Visible = true;
            }
            
        }

        protected void btn_eliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int rutCliente = Convert.ToInt32(txt_rutClienteEliminar.Text);
                DataSet ds = WS.EliminarCliente(rutCliente);
                ds = WS.ListarCliente();
                grd_leerCliente.Visible = true;
                grd_leerCliente.DataSource = ds.Tables[0];
                grd_leerCliente.DataBind();
            }catch(Exception ex)
            {
                grd_leerCliente.Visible = true;
            }

        }

        protected void txt_rutCliente_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_rutClienteActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_rutClienteEliminar_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
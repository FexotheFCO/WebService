using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public ServiceReference1.ServicioEjemploSoapClient serv = new ServiceReference1.ServicioEjemploSoapClient();
        float plata;
        List<Producto> productos = new List<Producto>();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            plata = 10000;
            String productostodojunto = serv.productos();
            String[] separados = productostodojunto.Split('.');
            String[] separa3 = separados[0].Split(';');
            String[] separa4 = separados[1].Split(';');
            String[] separa5 = separados[2].Split(';');
            Producto zapas = new Producto(separa3[0], Int16.Parse(separa3[1]),Int16.Parse(separa3[2]));
            Producto tele = new Producto(separa4[0], Int16.Parse(separa4[1]), Int16.Parse(separa4[2]));
            Producto auri = new Producto(separa5[0], Int16.Parse(separa5[1]), Int16.Parse(separa5[2]));
            TextBox1.Text = zapas.Nombre + zapas.Cantidad + zapas.Precio;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                        
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }

    public class Producto
    {
        String nombre;
        float precio;
        int cantidad;

        public Producto(String nombre, float precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
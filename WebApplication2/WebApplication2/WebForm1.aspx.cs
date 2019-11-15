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
        int plata = 2000;
        Producto zapas = new Producto();
        Producto tele = new Producto();
        Producto auri = new Producto();

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = plata.ToString();
            refresh();
        }

        protected void BtnCompra1_Click(object sender, EventArgs e)
        {
            if (plata >= 10)
            {
                String p = "zapatillas;10;1";
                serv.comprar(p);
                plata = plata - 10;
                refresh();
            }
        }

        protected void BtnCompra2_Click(object sender, EventArgs e)
        {
            if (plata >= 1000)
            {
                String p = "Television;1000;1";
                serv.comprar(p);

                plata = plata - 1000;
                refresh();
            }
        }

        protected void BtnCompra3_Click(object sender, EventArgs e)
        {
            if (plata >= 100)
            {
                String p = "Auriculares;100;1";
                serv.comprar(p);
                
                plata = plata - 100;
                refresh();
            }
        }

        void refresh()
        {
            String productostodojunto = serv.productos();
            String[] separados = productostodojunto.Split('.');
            String[] separa3 = separados[0].Split(';');
            String[] separa4 = separados[1].Split(';');
            String[] separa5 = separados[2].Split(';');
            zapas.Nombre = separa3[0];
            zapas.Precio = Int16.Parse(separa3[1]);
            zapas.Cantidad = Int16.Parse(separa3[2]);
            tele.Nombre = separa4[0];
            tele.Precio = Int16.Parse(separa4[1]);
            tele.Cantidad = Int16.Parse(separa4[2]);
            auri.Nombre = separa5[0];
            auri.Cantidad = Int16.Parse(separa5[1]);
            auri.Precio = Int16.Parse(separa5[2]);
            LblProducto1.Text = zapas.Nombre;
            LblProducto2.Text = tele.Nombre;
            LblProducto3.Text = auri.Nombre;
            LblPrecio1.Text = zapas.Precio.ToString();
            LblPrecio2.Text = tele.Precio.ToString();
            LblPrecio3.Text = auri.Precio.ToString();
            LblCantidad1.Text = zapas.Cantidad.ToString();
            LblCantidad2.Text = tele.Cantidad.ToString();
            LblCantidad3.Text = auri.Cantidad.ToString();
            LblPlata.Text = plata.ToString();
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
        public Producto()
        {

        }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
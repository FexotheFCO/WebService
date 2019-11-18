using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        Producto zapas = new Producto();
        Producto tele = new Producto();
        Producto auri = new Producto();

        protected void Page_Load(object sender, EventArgs e)
        {            
            refresh();
            Debug.WriteLine("pito dur cagakrpsakpdksa");
        }

        protected void BtnCompra1_Click(object sender, EventArgs e)
        {
            string plata = System.IO.File.ReadAllText(@"C:\Users\agust\Desktop\plata.txt");
            int plataint = Int16.Parse(plata);
            if (plataint >= 10 && Int16.Parse( LblCantidad1.Text) > 0)
            {
                String p = "zapatillas;10;1";
                serv.comprar(p);
                plataint = plataint - 10;
                System.IO.File.WriteAllText(@"C:\Users\agust\Desktop\plata.txt", plataint.ToString());
                refresh();

            }
        }

        protected void BtnCompra2_Click(object sender, EventArgs e)
        {
            string plata = System.IO.File.ReadAllText(@"C:\Users\agust\Desktop\plata.txt");
            int plataint = Int16.Parse(plata);
            if (plataint >= 1000 && Int16.Parse(LblCantidad2.Text) > 0)
            {
                String p = "Television;1000;1";
                serv.comprar(p);

                plataint = plataint - 1000;
                System.IO.File.WriteAllText(@"C:\Users\agust\Desktop\plata.txt", plataint.ToString());
                refresh();
            }
        }

        protected void BtnCompra3_Click(object sender, EventArgs e)
        {
            string plata = System.IO.File.ReadAllText(@"C:\Users\agust\Desktop\plata.txt");
            int plataint = Int16.Parse(plata);
            if (plataint >= 100 && Int16.Parse(LblCantidad1.Text) > 0)
            {
                String p = "Auriculares;100;1";
                serv.comprar(p);
                
                plataint = plataint - 100;
                System.IO.File.WriteAllText(@"C:\Users\agust\Desktop\plata.txt", plataint.ToString());
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
            auri.Precio = Int16.Parse(separa5[1]);
            auri.Cantidad = Int16.Parse(separa5[2]);
            actualizarLabels();
        }

        void actualizarLabels()
        {
            LblProducto1.Text = zapas.Nombre;
            LblProducto2.Text = tele.Nombre;
            LblProducto3.Text = auri.Nombre;
            LblPrecio1.Text = zapas.Precio.ToString();
            LblPrecio2.Text = tele.Precio.ToString();
            LblPrecio3.Text = auri.Precio.ToString();
            LblCantidad1.Text = zapas.Cantidad.ToString();
            LblCantidad2.Text = tele.Cantidad.ToString();
            LblCantidad3.Text = auri.Cantidad.ToString();
            string plata = System.IO.File.ReadAllText(@"C:\Users\agust\Desktop\plata.txt");
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
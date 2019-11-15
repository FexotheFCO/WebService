using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://localhost/", Name ="ServicioEjemplo")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        Producto zapas = new Producto("zapatillas", 10, 10);
        Producto tele = new Producto("Television", 1000, 10);
        Producto auri = new Producto("Auriculares", 100, 10);
        List<Producto> productos1 = new List<Producto>();
        /*
        WebService1()
        {
            productos1.Add(zapas);
            productos1.Add(tele);
            productos1.Add(auri);
        }*/

        [WebMethod]
        public string productos()
        {   /*
            String resultado = null;
            productos1.Add(zapas);
            productos1.Add(tele);
            productos1.Add(auri);
            foreach (Producto p in productos1)
            {
                resultado = resultado + descomponerProducto(p) + ".";
            }*/
            string resultado = zapas.Nombre + ";" + zapas.Precio + ";" + zapas.Cantidad + "." +
                tele.Nombre + ";" + tele.Precio + ";" + tele.Cantidad + "." +
                auri.Nombre + ";" + auri.Precio + ";" + auri.Cantidad;
            return resultado;
        }
        [WebMethod]
        public void comprar(string producto)
        {
            Producto productoComprado = new Producto();
            productoComprado = armarProducto(producto);
            if(productoComprado.Nombre == zapas.Nombre)
            {
                zapas.Cantidad = zapas.Cantidad - 1;
            }
            else if(productoComprado.Nombre == tele.Nombre)
            {
                tele.Cantidad = tele.Cantidad - 1;
            }
            else
            {
                auri.Cantidad = auri.Cantidad - 1;
            }
        }
        
        public Producto armarProducto(string producto)
        {
            string[] productoDesarmado = producto.Split(';');
            Producto resultado = new Producto(productoDesarmado[0], Int16.Parse(productoDesarmado[1]), Int16.Parse(productoDesarmado[2]));
            return resultado;
        }
        public string descomponerProducto(Producto producto)
        {
            string resultado = producto.Nombre + ";" + producto.Precio + ";" + producto.Cantidad;
            return resultado;
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

    

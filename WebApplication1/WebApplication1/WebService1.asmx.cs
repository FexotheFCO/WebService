using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        Producto zapas = new Producto();
        Producto tele = new Producto();
        Producto auri = new Producto();

        [WebMethod]
        public string productos()
        {   string resultado = System.IO.File.ReadAllText(@"C:\Users\agust\Desktop\db.txt");
            Debug.WriteLine("Resultado " + resultado);
            return resultado;
        }
        [WebMethod]
        public void comprar(string producto)
        {
            string resultado = System.IO.File.ReadAllText(@"C:\Users\agust\Desktop\db.txt");
            Debug.WriteLine(resultado);
            String[] separados = resultado.Split('.');
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
            Producto productoComprado = new Producto();
            productoComprado = armarProducto(producto);
            Debug.WriteLine("cargado : "+tele.Nombre);
            Debug.WriteLine("comprado : " + productoComprado.Nombre);
            if (productoComprado.Nombre == zapas.Nombre)
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
            string texto = zapas.Nombre + ";" + zapas.Precio + ";" + zapas.Cantidad + "." +
                tele.Nombre + ";" + tele.Precio + ";" + tele.Cantidad + "." +
                auri.Nombre + ";" + auri.Precio + ";" + auri.Cantidad ;
            System.IO.File.WriteAllText(@"C:\Users\agust\Desktop\db.txt", texto);
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

        void guardar()
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
        public Producto()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}

    

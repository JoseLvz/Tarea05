using System;

namespace JoseLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Horno horno = new Horno(true, 50, 20, 3);
            horno.Hornear("el horno esta encendido? = " + horno.encendido);
            horno.Hornear("usted tiene un " + horno.contenido +" horneando");
            horno.Hornear("la temperatura es de " + horno.temperatura);

            Ingrediente ingrediente = new Ingrediente();
            Ingrediente pollo = new Ingrediente();
            pollo.calorias = 25;
            pollo.cantidad = 5;
            pollo.nombre = "pechugon";
            Almacen almacen = new Almacen();
            almacen.addIng(pollo);
            Console.WriteLine(pollo); 
        }
    }
}

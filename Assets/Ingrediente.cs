

namespace JoseLopez
{
    public class Ingrediente{

        public string nombre;
        public int cantidad;
        public int calorias;

        public void Alimento( string msj)
        {
            //Console.WriteLine(msj);
        }


        /*public void Buscar()
        {
            List<string> ingredientes = new List<string>();
            ingredientes.Add("carne");
            ingredientes.Add("Masa");
            ingredientes.Add("Mozarella");
            ingredientes.Add("Pepperoni");

            return ingredientes;
        }*/

        /*public void Buscar()
        {
            Dictionary<string, int> ing = new Dictionary<string, int>();
            ing.Add("Carne", 5);
            ing.Add("Masa", 2);
            ing.Add("Mozarella", 5);
            ing.Add("Pepperoni", 2);

            if (ing.ContainsKey("carne"))
            {
                cantidad = ing["carne"];
                Console.WriteLine();
            }
        }*/


        public Ingrediente()
        {
            
        }

        override public string ToString() {
            string str = "Pollo (nombre: " + nombre + ", cantidad: " + cantidad + ", calorias: " + calorias + ")";

            return str;
        }

    }
}

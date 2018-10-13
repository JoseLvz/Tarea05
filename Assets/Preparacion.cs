

namespace JoseLopez
{
    class Preparacion:Utensilio_de_cocina{
        float resistencia;

        public int Recipiente(int cantidad)
        {
            cantidad = 2;
            return cantidad;
        }
    }
    class Olla:Preparacion { }
    class Sarten:Preparacion { }
    class Tetera:Preparacion { }
}

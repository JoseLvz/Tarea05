

namespace JoseLopez
{
    class Manipulacion : Utensilio_de_cocina {

        public float fuerza;
        public float rango;

        public float Cortar( float rango)
        {
            rango = 10;
            return rango;
        }
    }
    class Espatula:Manipulacion { }
    class Cucharon:Manipulacion { }
    class Cuchillo:Manipulacion { }
    class Rodillo:Manipulacion { }
    class Cuchara:Manipulacion { }
    class Tenedor:Manipulacion { }
    class Taza_con_medida:Manipulacion { }
    class Exprimidor:Manipulacion { }
    class Rallador:Manipulacion { }
    class Colador:Manipulacion { }
}

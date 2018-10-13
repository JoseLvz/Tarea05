

namespace JoseLopez
{
    public class Electrodomestico: Herramienta{

        public bool encendido;
        public float potencia;
        public float temperatura;
        public int contenido;


        public bool Encender()
        {
            encendido = true;
            return encendido;
        }
    }
}


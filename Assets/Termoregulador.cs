

namespace JoseLopez
{
    public class Termoregulador : Electrodomestico {

        public bool Refrigerar(Electrodomestico electrodomestico)
        {
            encendido = true;
            return encendido;
        }
        public float Calentar(Electrodomestico electrodomestico)
        {
            contenido = 10;
            return contenido;
        }

        public float Mantener_Temperatura(Electrodomestico electrodomestico)
        {
            temperatura = 20;
            return temperatura;
        }
    }

    class Cafetera:Termoregulador { }
    class Refrigerador:Termoregulador { }
    class Hervidor:Termoregulador { }

}


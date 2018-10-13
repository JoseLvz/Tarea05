

namespace JoseLopez
{
    class Soporte:Manipulacion{
        
        public float Soportar (float soporta){
            soporta = 50;
            return soporta;
        }

    }
    class tabla_de_cortar:Soporte { }
    class tabla_redonda:Soporte { }
}

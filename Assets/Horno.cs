using UnityEngine;
namespace JoseLopez
{
    class Horno:Electrodomestico
    {
        public void Hornear(string msj)
        {
            Debug.Log(msj);
        }


        public Horno(bool encendido, float potencia, float temperatura, int contenido)
        {
            this.encendido = encendido;
            this.potencia = potencia;
            this.temperatura = temperatura;
            this.contenido = contenido;
        }
    }
}

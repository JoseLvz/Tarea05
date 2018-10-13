
namespace JoseLopez
{
    class Modificador:Electrodomestico{

        public float velocidad;

        public bool Revolver(bool revuelve)
        {
            revuelve = true;
            return revuelve;
        }
    }

    class Batidora:Modificador { }
    class Licuadora:Modificador{ }
}


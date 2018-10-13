using JoseLopez;
using System.Collections.Generic;

public class Almacen
{
    public List<Ingrediente> Ings;

    public Almacen()
    {
        Ings = new List<Ingrediente>();
    }

    public void addIng(Ingrediente newIng)
    {
        Ings.Add(newIng);
        //Console.WriteLine();
    }

}

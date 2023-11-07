using AnimalesYSusSsonidos.Services;

class Program
{
    public static void Main(string[] args)
    {
        Comida comida = new Comida(); // sujeto

        Conejo conejo = new Conejo();
        Gato gato = new Gato();         // observadores
        Perro perro = new Perro();

        comida.AgregarAnm(perro);
        comida.AgregarAnm(gato);
        comida.AgregarAnm(conejo);

        comida.EliminarAnm(conejo);


        comida.ComidaOperacion("pescado");
        comida.ComidaOperacion("ensalada");
        comida.ComidaOperacion("pollo");

    }
}
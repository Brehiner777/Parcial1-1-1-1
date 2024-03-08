using Periodico;

class Program
{
    static void Main()
    {
        var libro1 = new Publicacion(200, 10, "El Gran Libro", "lujo", "Autor Genial", "01/03/2024", false);
        var periodico1 = new Publicacion(50, 5, "Diario Noticias", "normal", "Editor Jefe", "02/03/2024", true);

        Console.WriteLine($"Costo del libro: ${libro1.CalcularCosto()}");
        Console.WriteLine($"Costo del periódico: ${periodico1.CalcularCosto()}");
    }
}
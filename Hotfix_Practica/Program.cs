
Personaje personaje = new Personaje
{
    Nombre = "Guerrero",
    Vida = 100,
    Ataque = 20,
    Defensa = 10,
    Nivel = 1
};

Console.WriteLine($"Nombre: {personaje.Nombre}");

class Personaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }
    public int Nivel { get; set; }
}


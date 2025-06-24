using System;


class NoTengoIdea
{
    //getters & setters = add security to fields by encapsulation
    //                    They're accessors found within properties

    // properties = combine aspects of both fields and methods (share name with a field)
    // get accessor = used to return the property value
    // set accessor = used to assign a new value
    // value keyword = defines the value being assigned by the set (parameter)

    static void noseeeee(string[] args)
    {
        // Crear un auto con el constructor
        Automovil miAuto = new Automovil("Toyota", "Corolla", 2020);

        // Leer propiedades con GET
        Console.WriteLine($"Marca: {miAuto.Marca}");
        Console.WriteLine($"Modelo: {miAuto.Modelo}");
        Console.WriteLine($"Año: {miAuto.Anio}");

        // Cambiar el año con SET
        miAuto.Anio = 2024;

        Console.WriteLine($"\nAuto actualizado: {miAuto.Marca} {miAuto.Modelo} - Año {miAuto.Anio}");

        // Intentar poner un año inválido
        miAuto.Anio = 1800; // Setter rechazará este valor

        Console.WriteLine($"\nIntento inválido de año: {miAuto.Anio}");
    }

}
/*
Encapsulación: los campos son privados (private), y solo se accede a través de propiedades.
Propiedades (get y set) permiten:
    - Leer valores (get)
    - Asignar valores (set)
    - Validar antes de asignar (como con el año)
    - Se evita asignar valores inválidos directamente desde fuera de la clase.
 */
// Clase Auto con propiedades encapsuladas
class Automovil
{
    // Campo privado (no se puede acceder directamente desde afuera)
    private string marca;
    private string modelo;
    private int anio;

    // Constructor
    public Automovil(string marca, string modelo, int anio)
    {
        this.Marca = marca;   // Usa el set
        this.Modelo = modelo;
        this.Anio = anio;
    }

    // Propiedad con get y set para Marca
    public string Marca // por convencion esto se llama igual pero mayuscula
    {
        get { return marca; }
        set { marca = value; } // value es como se escribe en el lenguaje es el "parametro"
    }

    // Propiedad con get y set para Modelo
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    // Propiedad con validación para Año
    public int Anio
    {
        get { return anio; }
        set
        {
            if (value >= 1886 && value <= DateTime.Now.Year + 1) // Validación simple
                anio = value;
            else
                Console.WriteLine("⚠️ Año inválido. No se actualizó.");
        }
    }
}

class autito
{

    // Esto se llama auto-implemented property.
    public string Model { get; set; } // Esto ya crea un campo oculto automáticamente

    /*
    String model;

    public String Model
    {
        get { return model; }
        set { model = value; }
    }
    */
}


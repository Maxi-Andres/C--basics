using System; // Biblioteca base
using System.Collections.Generic; // Para usar List<>
using System.Threading.Tasks; // Para async/await

// `namespace` agrupa clases relacionadas
namespace EjemploModificadores
{
    // `public`: accesible desde otros archivos/proyectos
    public class Persona
    {
        // `readonly`: se asigna una vez (en constructor o en declaración)
        public readonly string Nombre;

        // `private`: accesible solo desde esta clase
        private int edad;

        // `static`: pertenece a la clase, no a una instancia
        public static int CantidadTotal = 0;

        // `const`: valor fijo en tiempo de compilación
        public const string ESPECIE = "Humano";

        // `protected`: accesible desde clases hijas
        protected string dni = "00000000";

        // `internal`: accesible solo dentro del mismo proyecto
        internal bool activo = true;

        // Constructor con parámetros
        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre; // `this`: referencia a la instancia actual
            this.edad = edad;
            CantidadTotal++;
        }

        // `virtual`: permite ser sobrescrito con `override` Se puede usar en cualquier clase (no necesariamente abstracta).
        public virtual void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre} y tengo {edad} años.");
        }

        // `async`: permite usar `await`
        public async Task EsperarYSaludar()
        {
            await Task.Delay(1000); // espera 1 segundo
            Saludar();
        }

        // `ref`: se pasa por referencia y se puede modificar
        public void AumentarEdad(ref int cantidad)
        {
            edad += cantidad;
        }

        // `out`: se debe asignar un valor dentro del método
        public void ObtenerEdad(out int resultado)
        {
            resultado = edad;
        }

        // `params`: permite pasar una cantidad variable de argumentos
        public void SaludarGrupo(params string[] nombres)
        {
            foreach (string n in nombres)
                Console.WriteLine($"Hola, {n}!");
        }
    }

    // `sealed`: evita que otra clase herede de esta
    public sealed class Empleado : Persona
    {
        public Empleado(string nombre, int edad) : base(nombre, edad) { }

        // `override`: sobrescribe método de clase base, solo se puede si es virtual, abstract o ya se le hizo override
        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy un empleado llamado {Nombre}");
        }
    }

    // `partial`: clase puede estar en varios archivos
    public partial class Utilidades
    {
        public static void MostrarTipo(object obj)
        {
            // `typeof` y `GetType` para obtener el tipo
            Console.WriteLine($"Tipo estático: {typeof(string)}");
            Console.WriteLine($"Tipo dinámico: {obj.GetType()}");
        }

        public static void VerNombreVariable()
        {
            int valor = 42;
            Console.WriteLine(nameof(valor)); // Imprime: valor
        }
    }

    // Punto de entrada
    class Program
    {
        static async Task Main(string[] args)
        {
            // `var`: tipo inferido automáticamente
            var p1 = new Persona("Juan", 30);
            var e1 = new Empleado("Maxi", 25);

            p1.Saludar();
            e1.Saludar();

            // Llamado con `ref` y `out`
            int extra = 5;
            p1.AumentarEdad(ref extra);

            int edadFinal;
            p1.ObtenerEdad(out edadFinal);
            Console.WriteLine($"Edad después de aumentar: {edadFinal}");

            // Llamado con `params`
            p1.SaludarGrupo("Ana", "Luis", "Pepe");

            // Uso de static method y typeof
            Utilidades.MostrarTipo(p1);
            Utilidades.VerNombreVariable();

            // Llamado async
            await p1.EsperarYSaludar();

            Console.ReadKey(); // Espera una tecla para cerrar
        }
    }
}

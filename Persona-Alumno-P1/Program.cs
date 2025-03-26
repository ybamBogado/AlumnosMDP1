using Persona_Alumno_P1;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Pila pila = new Pila();
        Cola cola = new Cola();
        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
        LlenarAlumnos(pila);
        LlenarAlumnos(cola);
        informar(pila);
        informar(cola);
        informar(multiple);
    }
    public static void LlenarAlumnos(Coleccionable col)
    {
        Random r = new Random();
        for (int i = 0; i < 20; i++)
        {   //random para luego ser convertido a ascii
            //mnayusculas de 65 a 90
            char inicial = (char)r.Next(65, 90);
            //minúsculas entre 97 y 122
            char dos = (char)r.Next(97, 122);
            char tres = (char)r.Next(97, 122);
            char cuatro = (char)r.Next(97, 122);
            //interpolacion de cadenas para formar el nombre
            string nombre = $"{inicial}{dos}{tres}{cuatro}";
            //random para int
            int id = r.Next(40000000, 50000000);
            int p = r.Next(1, 100);
            Comparable comp = new Alumno(nombre, id, i, p);
            //Impresion de cada comparable
            //Console.WriteLine(comp);
            col.agregar(comp);
        }
    }
    public static void informar(Coleccionable c)
    {
        Console.WriteLine(c.cuantos());
        
        Console.WriteLine(c.minimo());
        Console.WriteLine(c.maximo());
        Console.WriteLine("escribe dni a buscar:");
        int dni = int.Parse(Console.ReadLine());
        Comparable comparable = new Alumno("informar",dni,0,0);
        if (c.contiene(comparable))
        {
            Console.WriteLine("El elemento leído está en la colección");
        }
        else
        {
            Console.WriteLine("El elemento leído no está en la colección");
        }
    }
}
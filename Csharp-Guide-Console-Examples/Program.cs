using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Metodos: linea 70 a 103 video 4*/
// para que el codigo siga corriendo despues del breakpoint se preciona F10
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Control+k+c para conmentar lineas

            //PreguntaYEdad(); linea 115

            EscribeHolaMundo(); //linea 55

            EscribeEnLaConsola("Metodo que escribe en la consola");//linea 66

            IdentificadorDelMetodo("valor1", "valor2", 32);//linea 73

            int sumando1 = 5;//linea 84
            int sumando2 = 7;//linea 84
            //Declaramos la variable resultado y decimos que es igual al resultado que devuelve el metodo suma cuando le pasamos los parametros sumando1 y sumando2
            int resultado = Suma(sumando1, sumando2);//linea 84
            Console.WriteLine(resultado);//linea 84

            Console.WriteLine("Hola Mundo C#");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("White on blue.");
            string[] array = { "red", "blue", "green" };
            // Loop with for each and write colors with string interpolation.
            Console.ResetColor();
            foreach (string color in array)
            {
                Console.WriteLine($"Color = {color}");
            }
            //Nos da tiempo para ver la consola.
            Console.Read();
        }
        // La linea verde debajo de las variables indica que no se estan usando, incluso si esta fue asignada pero no usada.
        // Ejemplos de declaracion de una variable:
        /*int mes;
        string nombre;
        DateTime time;
        bool procesoTerminado;*/

        // Ejemplos de inicializacion de una variable:
        /*mes = 7;
        nombre = "Hola";
        procesoTerminado = true;*/

        // Podemos inicializar y declarar en una misma linea:
        //string direccion = "Argentina";

        /* Conclusion: 
        Las variables son informacion que guardamos en memoria para utilizarlas de manenra
        conveniente. Luego de declarar una variable, podemos hacer referencia a esta utilizando
        su nombre o identificador.
        Un ejemplo de variable es int mes = 5;
            donde int es el tipo de dato de la variable
            mes es el nombre de la variable 
            y 5 es el valor que el hemos asignado.
        Algunos ejemplos de tipo de datos son: int, bool, string, DateTime.
        */

        /*Los metodos son bloques de codigo que podemos ejecutar cuantas veces queramos.Pueden recibir valores
         *de entrada, llamados parametros. Tambien pueden devolver valores si se desea, nada de esto es 
         * obligatorio un ejemplo de metodo es el metodo main el cual es el metodo que se ejecuta al iniciar
         * el programa y por donde este empieza.*/
        static void EscribeHolaMundo()
        {
            Console.WriteLine("Hola mundo");
        }
        //Este metodo recibe un valor de entrada que sea una cadena de texto que queramos escribir en consola.
        //para indicar que un metodo recibe parametros declaramos sus variables de entrada dento del parenticis.
        static void EscribeEnLaConsola(string valor)
        {
            Console.WriteLine(valor);
        }
        /* Metodo estatico sin valores de salida, dentro del parentesis podemos colocar tantas variables
         *entrada como queramos del tipo que queramos */
        static void IdentificadorDelMetodo(string parametro1, string parametros2, int etc)
        {

        }
        /*
         los metodos marcados con void son aquellos metodos que no tienen valores de salida no debuelve un resultado
         a quien los invoca, si queremos realizar un metodo que debuelva un valor debemos cambiar la palabra void por el tipo de valor que queremos retornar 
         utilizamos "return" para retornar un valor a lo que haya invocado el metodo.
         */

        /*Los metodos son bloques de codigo que podemos ejecutar cuantas veces queramos.
         * Sirven tambien para evitar repetir piezas de codigo que utilizaremos en varios lugares.
         * Sirven ademas para organizar el codigo en partes.
         * Los metodos pueden recibir valores de entrada, esto no es obligatorio.
         * Los metodos pueden recibir valores de salida, esto no es obligatorio.*/
        static int Suma(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Hacer un programa que le pregunte al usuario su nombre y edad, posterior a eso debe mostrar un mensaje en
        /// pantalla con el nombre del usuario y su edad.
        /// Pista: Utilice Console.ReadLine para leer la informacion que ingresa el usuario
        /// Pista 2: Utilice int.Parse para convertir de tipo string a tipo int
        /// </summary>
        /// <param name="args"></param>
        static void PreguntaYEdad()
        {
            string nombre;
            int edad;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            string output = string.Format("Su nombre es {0} y tiene {1} años de edad ", nombre, edad);
            Console.WriteLine(output);
            Console.Read();
        }
        // Las clases nos permiten definir una entidad con un estado (variables) y comportamientos (metodos).
        // Podemos crear clases para modelar objetos o ideas del mundo real.
        // Podemos crear clases que tengan distintas responsabilidades, tambien las clases pueden representar procesos.
        class Factura
        {
            public int Id;
            // ... Otras variables
        }
        class RepositorioFacturas
        {
            //public Factura ObtenerPorId(int Id)
            //{
            //    // Codigo obtiene factura por Id
            //}
            public void Guardar(Factura factura)
            {
                // Codigo guarda factura en una BD
            }

            // El tipo del resultado de una operacion de relacion es booleano <, >,<=,>=,!=,==,is.
            // a is int, El operador is es como preguntar ¿"a es de tipo int"?
            // El operador de la conjucion es & devuelve el valor true si ambos operandos tienen valor de verdad true.
            // Si utilizamos && entonces el segundo operando solo se evalua si el premiero es true.
            // disyuncion exclusiva ^ (caret) devuelve true cuando los operadores son distintos uno true y otro false.
            // disyuncion inclusiva | debuelve false si ambos oprandos son false

        }

    }
}
using System;

namespace E2
// Diego Alejandro Palomino Vazquez 331-27 10/22/26

{
    class Program
    {
        // Funcion principal
        static void Main(string[] args)
        {
            // 1. Escribir la sintaxis para definir una funcion.
            int CalcularDoble(int numero)
            {
                int resultado = 2 * numero;
                return resultado;
            }

            // 2. Definir ciclo para imprimir la siguiente secuencia: 2, 4, 6, 9, 12, 15, 19, 23, 27.
             for (int n = 2; n <= 27; )
                {
                    Console.WriteLine(n);

                    if (n == 2)
                    n += 2;
                    else if (n == 6)
                    n += 3;
                    else if (n == 9)
                    n += 3;
                    else if (n == 12)
                    n += 3;
                    else if (n == 15)
                    n += 4;
                    else if (n == 19)
                    n += 4;
                    else if (n == 23)
                    n += 4; 
                    else if (n == 27);
                }

            // 3. Declarar e inicializar 2 variables: inicio, limite. Si el producto de inicio y limite es menor que 8 e inicio es mayor que limite, definir un ciclo descendiente de 9 ejecuciones. En cualquier otro caso, definir un ciclo ascendiente.
                int inicio = 9;
                int limite = 2;

                if (inicio * limite < 8 && inicio > limite)
                {
                    for (int i = 9; i >= 1; i--)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    for (int i = inicio; i <= limite; i++)
                    {
                     Console.WriteLine(i);
                    }
                }

            
            // 4.Definir e invocar una funcion para determinar si un numero es multiplo de 5. Si el numero es multiplo de 5, devolver true; en caso contrario, false.Imprimir la devolucion utilizando interpolacion.
            bool EsMultiploDe5(int numero)
            {
             return numero % 5 == 0;
            }

            int numero = 15;
            bool resultado = EsMultiploDe5(numero);

            Console.WriteLine($"¿El número {numero} es múltiplo de 5? {resultado}");
            

            // 5.Definir e invocar una funcion vacia para imprimir: "Examen: Programacion III", donde "Programacion III" corresponda a un argumento
             void ImprimirExamen(string materia)
            {
             Console.WriteLine($"Examen: {materia}");
            }

             ImprimirExamen("Programacion III");
            

            
        } // Termino funcion principal
    } // Termino clase principal
} // Termino espacio de nombres

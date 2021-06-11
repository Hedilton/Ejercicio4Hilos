using System;
using System.Collections.Generic;//contiene interfaces y clases que definen colecciones genericas,permiten estar tipadas
using System.Linq;//conjunto de extensiones integradas en c#,permite trabajar mas comodo
using System.Text;//contiene clases que representan codificaciones de caracteres
using System.Threading;
//dado un numero decimal convertirlo en binario y octal
namespace Ejercicio4Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int[] vec = new int[21];
            Console.Write("ingrese el numero: ");
            num = Int32.Parse(Console.ReadLine());
            Thread x = new Thread(proceso1);
            Thread y = new Thread(proceso2);
            x.Start(num);
            y.Start(num);
        }
        static void proceso1(object n)
        {
            int num = Convert.ToInt32(n);
            int aux = 0,pos = 1,i=0;
            int[] vec = new int[21];
            while (num >= 2)
            {
                aux = num % 2;
                vec[pos] = aux;
                pos = pos + 1;
                num = num / 2;
            }
            vec[pos] = num;
            Console.WriteLine("El numero binario es: ");
            for (i = pos; i >= 1; i += -1)
            {
                Console.Write(vec[i] + " ");
            }
            Console.WriteLine();

        }
        static void proceso2(object n)
        {
            int num = Convert.ToInt32(n);
            int aux = 0, pos = 1, i = 0;
            int[] vec = new int[21];
            while (num >= 8)
            {
                aux = num % 8;
                vec[pos] = aux;
                pos = pos + 1;
                num = num / 8;
            }
            vec[pos] = num;
            Thread.Sleep(1000);
            Console.WriteLine("El numero octal es: ");
            for (i = pos; i >= 1; i += -1)
            {
                Console.Write(vec[i] + " ");
            }
        }
    }
}

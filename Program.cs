using System.Linq;

namespace Ejercicio6
{
    class Program
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("Intoduzca una cadena de caracteres: ");
            string cadena = Console.ReadLine();

            string revertir = Reverse(cadena);
            Console.WriteLine(revertir);
        }
        static string Reverse(string cadena)
        {
            char[] charArray = cadena.ToCharArray();
            string revertir = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                revertir += charArray[i];
            }
            return revertir;
        }
    }
}
using System; // Necessário para usar Console

namespace Operadores_atribuicao
{
    public class Program
    {
        public static void Main()
        {
            int x = 10; // Atribuição simples: guarda 10 em x

            Console.WriteLine("Valor inicial: " + x); // 10

            x += 5; // Equivale a x = x + 5 → x vale 15
            Console.WriteLine("Depois de += 5: " + x); // 15

            x -= 3; // Equivale a x = x - 3 → x vale 12
            Console.WriteLine("Depois de -= 3: " + x); // 12

            x *= 2; // Equivale a x = x * 2 → x vale 24
            Console.WriteLine("Depois de *= 2: " + x); // 24

            x /= 4; // Equivale a x = x / 4 → x vale 6 (divisão inteira)
            Console.WriteLine("Depois de /= 4: " + x); // 6

            x %= 4; // Equivale a x = x % 4 → resto de 6 por 4 = 2
            Console.WriteLine("Depois de %= 4: " + x); // 2

            /* Atenção: = (atribuição) não é o mesmo que == (comparação).
             * "x = 5" guarda 5 em x; "x == 5" pergunta se x é igual a 5. */
        }
    }
}
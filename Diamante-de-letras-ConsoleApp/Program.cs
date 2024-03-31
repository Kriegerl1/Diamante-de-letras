namespace Diamante_De_Letras_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Diamante de Letras | Academia de Programação 2024!\n");

                string letra = obterValor<string>("Digite uma letra para gerar o diamante: "); // Veja a linha 20;

                char[] alfabetoArray;
                int indexDoArray;
                dadosDoDiamante(letra, out alfabetoArray, out indexDoArray);

                construtorDoDiamante(alfabetoArray, indexDoArray);

            }

            static tipo obterValor<tipo>(string texto) // Método que recebe e converte o valor, o tipo da conversão é feito com um indicador na declaração do método;
            {
                Console.WriteLine(texto);

                string input = Console.ReadLine().ToUpper();
                try
                {
                    return (tipo)Convert.ChangeType(input, typeof(tipo));
                }
                catch
                {
                    Console.WriteLine("Formato inválido!");
                    return obterValor<tipo>(texto);
                }
            }
        }

        private static void dadosDoDiamante(string letra, out char[] alfabetoArray, out int indexDoArray)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alfabetoArray = alfabeto.ToCharArray(0, alfabeto.Length);
            indexDoArray = alfabeto.IndexOf(letra);
            // Filtro que indica posição da letra digitada dentro do array alfabetoArray;
        }

        private static void construtorDoDiamante(char[] alfabetoArray, int indexDoArray)
        {

            #region Topo do diamante de letras
            for (int i = 0; i <= indexDoArray; i++) // altura do diamante, base da letra escrita;
            {
                for (int j = 0; j < indexDoArray - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(alfabetoArray[i]);
                if (i > 0)
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(alfabetoArray[i]);

                }
                Console.WriteLine();
            }
            #endregion

            // Mesma lógica, inversa do topo
            #region Base do diamante de letras
            for (int i = indexDoArray - 1; i >= 0; i--)
            {
                for (int j = 0; j < indexDoArray - i; j++)
                {
                    Console.Write(" ");

                }
                Console.Write(alfabetoArray[i]);

                if (i > 0)
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(alfabetoArray[i]);
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
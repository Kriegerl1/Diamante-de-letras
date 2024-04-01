namespace iamante_De_Letras_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //lista ASCII   A = 65 ~~ Z == 90
                Console.WriteLine("Diamante de Letras 2.0 | Academia de Programação 2024!\n");

                Console.WriteLine("Utilizando os valores dos tipos Char.\n\n");
                while (true)
                {
                    dadosDoDiamante();
                    if (desejaContinuar("Deseja continuar? (S / N)")) break;
                }
            }




            static tipo obterValor<tipo>(string texto)
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

            static bool desejaContinuar(string texto)
            {
                Console.WriteLine(texto);
                string decisao = Console.ReadLine().ToUpper();
                Console.Clear();
                return decisao == "N";
            }

            static void dadosDoDiamante()
            {
                char letra = obterValor<char>("Digite uma letra para gerar o diamante: ");

                //char letra = 'Z';

                int letraAscii = Math.Abs(Convert.ToInt32(letra));

                string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char[] arrayAlfabeto = alfabeto.ToCharArray(0, alfabeto.Length);
                int A = letra - 64;
                construtorDiamante(arrayAlfabeto, A);
            }
        }

        private static void construtorDiamante(char[] arrayAlfabeto, int A)
        {
            #region Topo do Diamante de Letras
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(arrayAlfabeto[i]);
                if (i > 0)
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(arrayAlfabeto[i]);
                }
                Console.WriteLine();
            }
            #endregion

            #region Base do Diamante de Letras

            for (int i = A - 2; i >= 0; i--)
            {
                for (int j = 0; j <= A - i - 1; j++)
                {
                    Console.Write(" ");
                }
                if (i > 0)
                {
                    Console.Write(arrayAlfabeto[i]);
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine(arrayAlfabeto[i]);
            }
            #endregion
        }
    }
}
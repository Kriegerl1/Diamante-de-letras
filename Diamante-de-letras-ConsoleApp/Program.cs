namespace Diamante_De_Letras_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Diamante de Letras | Academia de Programação 2024!\n");

                string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string letra = obterValor<string>("Digite uma letra para gerar o diamante: ");

                char[] alfabetoArray = alfabeto.ToCharArray(0, alfabeto.Length); // Array de LETRAS [A , B , C ...];


                int letraIndex = alfabeto.IndexOf(letra); // Tamanho do Array = 26;


                #region Topo do diamante de letras
                for (int i = 0; i <= letraIndex; i++) // altura do diamante, base da letra escrita;
                {
                    for (int j = 0; j < letraIndex - i; j++)
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
                for (int i = letraIndex - 1; i >= 0; i--)
                {
                    for (int j = 0; j < letraIndex - i; j++)
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
        }
    }
}
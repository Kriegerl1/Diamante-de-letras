namespace Diamante_De_Letras_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Diamante de Letras | Academia de Programação 2024!\n");

                Console.WriteLine("Aqui eu tentarei utilizar a metodologia que o Thiago comentou!\nUtilizando os valores dos tipos Char.");

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
namespace Diamante_De_Letras_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Diamante de Letras | Academia de Programação 2024!\n");

                string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string letra = obterValor<string>("Digite uma letra de A a Z: ");

                char[] alfabetoArray = alfabeto.ToCharArray(0, alfabeto.Length); // Array de LETRAS [A , B , C ...];


                decimal letraIndex = alfabeto.IndexOf(letra); // Tamanho do Array = 26;

                decimal A = Math.Floor(letraIndex * 2); // Metade do letraIndex, arredondado para baixo;


                #region Topo do diamante de letras
                for (int i = 0; i <= letraIndex; i++) // altura do diamante, base da letra escrita;
                {
                    for (int j = 1; j <= A; j++)
                    {
                        if ((A - j) / 2 >= i) // espaços inicias de fora topo;
                        {
                            Console.Write(" ");
                        }
                        else if ((A - j) >= (2 * i) - 1)
                        {
                            Console.Write(alfabetoArray[i]); // gera os primeiros caracteres;
                        }
                        else
                        {
                            Console.Write(" "); // gera 1/4 do LOZANGO;
                        }

                    }
                    for (int j = 1; j <= A; j++)// gera 1/4 do LOZANGO;
                    {
                        if ((1 + A - j) / 2 <= i)
                        {
                            Console.Write(" ");
                        }

                    }
                    Console.WriteLine(alfabetoArray[i]); // fecha o LOZANGO;

                }
                #endregion

                // Mesma lógica, inversa do topo
                #region Base do diamante de letras
                for (int i = Convert.ToInt32(letraIndex) - 1; i >= 0; i--)
                {
                    for (int j = 1; j <= A; j++)
                    {
                        if ((A - j) / 2 >= i)
                        {
                            Console.Write(" ");
                        }
                        else if ((A - j + 1) / 2 >= i)
                        {
                            Console.Write(alfabetoArray[i]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }

                    for (int j = 1; j <= A; j++)
                    {
                        if ((1 + A - j) / 2 <= i)
                        {
                            Console.Write(" ");
                        }

                    }
                    Console.WriteLine(alfabetoArray[i]);
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
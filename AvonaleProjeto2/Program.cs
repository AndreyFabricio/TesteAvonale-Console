using System;
using System.Collections.Generic;

namespace AvonaleProjeto2
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            // Cria e inicializa a lista inicial de números
            var numeros = new List<int>(new int[] { 3, 14, 15, 9, 26, 53, 58, 97, 93, 23, 84 });

            // Mantém o programa rodando em loop até o mesmo ser encerrado em EncerraPrograma()
            while (true)
            {
                
                // Imprime no console a lista atual dos números
                Console.WriteLine("================================================================");
                Console.WriteLine();
                ImprimeLista(numeros);
                Console.WriteLine();
                Console.WriteLine();

                // Imprime no console a média dos números contidos na lista
                Console.WriteLine("================================================================");
                Console.WriteLine();
                Media(numeros);
                Console.WriteLine();
                Console.WriteLine();

                // Imprime no console os números contidos na lista em ordem inversa
                Console.WriteLine("================================================================");
                Console.WriteLine();
                ImprimeListaReversa(numeros);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("================================================================");

                // Classe que encerra o programa
                EncerraPrograma();

                /* Caso o usuário não deseje encerrar o programa ele tem a opção de 
                 * executar novamente o programa com uma nova lista */
                NovaLista(numeros);

            } // Fim do While
            
        }// Fim do Main  
        #endregion

        // Imprime no console os números contidos na lista
        private static void ImprimeLista(List<int> numeros)
        {
            Console.Write("Lista atual dos números: ");
            foreach (int num in numeros) Console.Write(num + " ");
        }

        // Imprime no console a média dos números contidos na lista
        private static void Media(List<int> numeros)
        {
            float media = 0, quantidade = 0;

            foreach (int num in numeros)
            {
                media += num; // Soma a média o número atual da lista
                quantidade++; // Para cada número da lista percorrido no foreach soma 1 a quantidade
            }

            // Imprime a média
            Console.Write("A média atual dos números da lista é: {0:0.00}", media / quantidade);
        }

        // Imprime no console os números na ordem invertida
        private static void ImprimeListaReversa(List<int> numeros)
        {
            numeros.Reverse(); // Inverte a lista
            Console.Write("Lista invertida dos números: ");
            foreach (int num in numeros) Console.Write(num + " ");
            numeros.Reverse(); // Inverte novamente a lista para sua ordem inicial
        }

        // Encerra o programa
        private static void EncerraPrograma()
        {
            Console.Write("Gostaria de encerrar o programa? (S/N) ");

            string userInput = Console.ReadLine(); // Recebe o valor digitado pelo usuário

            if (userInput == "S" || userInput == "s")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear(); // Caso o programa não seja encerrado, limpa o console
            }
        }

        // Cria uma nova lista de números inteiros
        private static void NovaLista(List<int> numeros)
        {
            Console.Write("Gostaria de utilizar o programa com uma nova lista? (S/N) ");

            string userInput = Console.ReadLine(); // Recebe o valor digitado pelo usuário

            if (userInput == "S" || userInput == "s")
            {
                numeros.Clear(); // Apaga toda a lista de números
                Console.WriteLine();

                while (true) // Executa até o usuário digitar "C"
                {
                    Console.WriteLine("Digite um número inteiro para adicionar a lista");
                    Console.Write("Digite 'c' para completar a lista: ");

                    userInput = Console.ReadLine(); // Recebe o valor digitado pelo usuário
                    Console.WriteLine();

                    if (Int32.TryParse(userInput, out int n)) // Testa se o valor é um número inteiro
                    {
                        numeros.Add(n); // Adiciona o número inteiro a lista
                    }
                    else if (userInput == "C" || userInput == "c")
                    {
                        Console.Clear(); // Limpa o console
                        break; // Sai do while
                    }
                    else
                    {
                        /* Exceção caso o usuário digite um valor diferente 
                         * de um número inteiro ou da letra C */
                        Console.WriteLine("O valor digitado não é um número, tente novamente.");
                        Console.WriteLine();
                    }

                } // Fim do While

            } // Fim do If
            else
            {
                /* Caso o usuário tenha ido para a opção de digitar uma nova lista
                 * sem que tenha sido sua intenção inicial, este Else serve para
                 * chamar EncerraPrograma() */
                        Console.WriteLine();
                EncerraPrograma();
            }
            
        } // Fim do método NovaLista

    }// Fim da Class
}
 
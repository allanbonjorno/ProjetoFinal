class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bem-vindo ao Carrinho de Compras");
            Console.WriteLine("1. Visualizar produtos disponíveis");
            Console.WriteLine("2. Adicionar produto ao carrinho");
            Console.WriteLine("3. Visualizar itens do carrinho");
            Console.WriteLine("4. Finalizar compra");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Produtos disponíveis para compra:");
               
                    break;

                case "2":
                    Console.Write("Digite o ID do produto que deseja adicionar: ");


                    break;

                case "3":
                    Console.WriteLine("Itens no carrinho:");
                    break;
                case "4":
                    Console.WriteLine();
                
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    }

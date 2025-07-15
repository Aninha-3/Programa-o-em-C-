
        string horta;
        int opcao;

        do
        {
            ExibirMenu();

            if (int.TryParse(Console.ReadLine(), out opcao))
            {

                switch (opcao)
                {
                    case 1:
                        ExibirFruta();
                        Console.ReadKey();
                        break;
                    case 2:
                        ExibirLegume();
                        Console.ReadKey();
                        break;
                    case 3:
                        ExibirVerdura();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida. Tente Novamente.");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Não foi possivel realizar a operação.");
                Console.ReadKey();
            }

        } while (opcao != 3);

        void ExibirMenu()
        {

            Console.Clear();
            Console.WriteLine("Quetipo de produto você quer cadastrar?");
            Console.WriteLine("1 - Fruta");
            Console.WriteLine("2 - Legume");
            Console.WriteLine("3 - Verdura");
        }


        void ExibirFruta()
        {
            Console.Write("Qual Fruta você quer adicionar a sua sacola:");
            string frutas(Console.ReadLine());

            SalvarFrutas();
        }

        void SalvarFrutas()
        {
            string carrinho = "itens.csv";

            if (File.Exists(carrinho))
            {
                string conteudo = File.ReadAllText(carrinho);

                File.WriteAllText(carrinho, conteudo);
            }
        }

        void ExibirLegume()
        {
            Console.Write("Qual Legume você quer adicionar a sua sacola:");


        }



        void ExibirVerdura()
        {
            Console.Write("Qual Verdura você quer adicionar a sua sacola:");


        }
   


/*
void VerCarrinho()
{
   
}*/


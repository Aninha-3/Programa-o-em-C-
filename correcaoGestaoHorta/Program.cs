// Invocação do método ExibirMenu
ExibirMenu();

// Atribuindo à variável opcao o retorno do método Console.ReadLine(), que é uma string
int opcao = int.Parse(Console.ReadLine()); // Console.ReadLine() captura e retorna uma string fornecida pelo usuário

// Verifica o valor da variável opcao
switch (opcao)
{
    case 1:
        // Opção fruta selecionada
        Console.WriteLine("Digite o nome da fruta a ser salva:");
        SalvarItem("fruta");
        break;
    case 2:
        // Opção legume selecionada
        Console.WriteLine("Digite o nome do legume a ser salvo:");
        SalvarItem("legume");
        break;
    case 3:
        // Opção verdura selecionada
        Console.WriteLine("Digite o nome da verdura a ser salva:");
        SalvarItem("verdura");
        break;
    default:
        // Nenhuma das opções previstas foi selecionada
        break;
}

// Declaração do método ExibirMenu
void ExibirMenu()
{
    Console.WriteLine("Que tipo de produto você gostaria de cadastrar?");
    Console.WriteLine("1 - Fruta");
    Console.WriteLine("2 - Legume");
    Console.WriteLine("3 - Verdura");
}

void SalvarItem(string tipoDeItem)
{
    string item = Console.ReadLine(); // Atribuição do retorno do método Console.Readline() à variável item

    string arquivo = "dados/" + tipoDeItem + "s.csv";

    /**
     ! operador de negação
     File.Exists("dados/fruta.csv") // false
     File.Exists("dados/frutas.csv") // true
     !File.Exists("dados/fruta.csv") // true
    */

    // Se o arquivo não existir
    if (!File.Exists(arquivo))
    {
        // Criar arquivo com conteúdo vazio
        File.WriteAllText(arquivo, "");
    }

    string conteudoAtual = File.ReadAllText(arquivo); // Lê o conteúdo atual do arquivo

    string[] itensExistentes = conteudoAtual.Split(",");
    bool itemJaExiste = false;

    for (int count = 0; count < itensExistentes.Length; count++)
    {
        if (item == itensExistentes[count])
        {
            itemJaExiste = true;
            Console.WriteLine($"{tipoDeItem} já existe.");
        }
    }

    if (itemJaExiste == false)
    {
        Console.WriteLine($"{tipoDeItem} não existe ainda, salvando no nosso banco de dados...");
        File.WriteAllText(arquivo, conteudoAtual + item + ","); // Salva conteúdo no arquivo especificado
    }
}

// Modificar um item já existente

void ModificarItens()
{
    string Modificar = (fruta.Replace());
}
// Case AutoMind
namespace CadastroUsuarios
{
    // Classe para representação de usuário
    class InformacoesUsuario
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
    }

    // Classe para criação do menu principal
    class Menu
    {
        // Lista para armazenar usuários
        static List<InformacoesUsuario> usuarios = new List<InformacoesUsuario>();

        // Função Menu Principal
        static void Main(string[] strings)
        {
            int numeroDeEscolha;

            do
            {
                Console.WriteLine("\n--- Cadastro de Usuários ---");
                Console.WriteLine("1 - Cadastrar Usuário");
                Console.WriteLine("2 - Listar Usuários");
                Console.WriteLine("3 - Buscar Usuário por Nome");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                
                // Lê a escolha do usuário e valida
                if (!int.TryParse(Console.ReadLine(), out numeroDeEscolha))
                {
                    Console.WriteLine("Entrada inválida. Digite um número de 0 a 3.");
                    continue;
                }

                switch (numeroDeEscolha)
                {
                    case 1:
                        CadastrarUsuario();
                        break;
                    case 2:
                        ListarUsuarios();
                        break;
                    case 3:
                        BuscarUsuario();
                        break;
                    case 0:
                        Console.WriteLine("Finalizando cadastro de usuários!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente um número de 0 à 3");
                        break;
                }

            } while (numeroDeEscolha != 0);
        }

        // Função para cadastrar um usuário
        static void CadastrarUsuario()
        {
            Console.Write("\nDigite o seu nome: ");
            string nome = Console.ReadLine() ?? string.Empty; 

            if (string.IsNullOrWhiteSpace(nome) || !nome.All(c => char.IsLetter(c) || c == ' '))
            {
                Console.WriteLine("Nome inválido. Digite apenas letras.");
                return;
            }
            else
            {
                Console.WriteLine($"Nome digitado: {nome}");
            }

            string email;
            
            do
            {
                Console.Write("Digite seu email: ");
                email = Console.ReadLine();

                if (!email.Contains("@"))
                {
                    Console.WriteLine("Por favor, digite um email válido contendo '@'.");
                }
            } while (!email.Contains("@")); 


            int idade;
            while (true)
            {
                Console.Write("Digite a idade do usuário: ");
                if (int.TryParse(Console.ReadLine(), out idade) && idade > 0)
                {
                    break; // Sai do loop se a idade for válida e maior que 0
                }
                else
                {
                    Console.WriteLine("Idade inválida. Digite um número inteiro positivo.");
                }
            }


            InformacoesUsuario novoUsuario = new InformacoesUsuario
            {
                Nome = nome,
                Email = email,
                Idade = idade
            };

            usuarios.Add(novoUsuario);
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }

        // Função para listar os usuários
        static void ListarUsuarios()
        {
            Console.WriteLine("\nLista de usuários: ");

            if (usuarios.Count == 0)
            {
                Console.WriteLine("Não há nenhum usuário cadastrado.");
                return;
            }

            // Para cada item da lista usuarios...
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Nome: {usuario.Nome}, Email: {usuario.Email}, Idade: {usuario.Idade}");
            }
        }

        // Função para buscar usuários pelo nome
        static void BuscarUsuario()
        {
            Console.Write("\nDigite o nome do usuário que você quer buscar: ");
            string nomeBusca = Console.ReadLine();

            var usuarioEncontrado = usuarios.FirstOrDefault(u => u.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase));

            if (usuarioEncontrado != null)
            {
                Console.WriteLine($"Usuário encontrado: Nome: {usuarioEncontrado.Nome}, Email: {usuarioEncontrado.Email}, Idade: {usuarioEncontrado.Idade}");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }
    }
}

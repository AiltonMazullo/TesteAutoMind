# Cadastro de Usuários - Teste AutoMind

Este é um sistema de cadastro de usuários que fiz utilizando C# + .net. O sistema solicita o nome, email e idade do usuário, realizando validações para garantir que os dados fornecidos sejam válidos, também exibe a lista dos usuários cadastro e dá para buscar usuário por nome.

## Funcionalidades

1. Cadastro de Usuário : O sistema permite o cadastro de usuários com as seguintes informações:
   - Nome (apenas letras)
   - Email (deve conter o símbolo `@`)
   - Idade (deve ser um número inteiro)

2. Validação de Dados :
   - O nome deve ser composto apenas por letras.
   - O email deve conter o símbolo `@`.
   - A idade deve ser um número inteiro válido.

3. Armazenamento de Usuários : Após o cadastro, as informações do usuário são armazenadas em uma lista e uma mensagem de sucesso é exibida.

4. Listagem de usuários : Após o cadastro, é possível saber todos os usuários cadastrados no sitema.

5. Busca de usuário por nome: Após o cadastro dos usuários, é possível buscar o usuário pelo seu nome e irá aparecer suas informações.

   ## Como Rodar o Projeto

1. **Pré-requisitos**:
   - Instale o [.NET SDK](https://dotnet.microsoft.com/download).
   
2. **Passos para execução**:
   - Clone este repositório.
   - Abra o terminal ou prompt de comando na pasta do projeto.
   - Execute o seguinte comando para rodar o programa:

   ```bash
   dotnet run

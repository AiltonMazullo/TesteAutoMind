
# Cadastro de Usuários - **Teste AutoMind**  
Sistema de cadastro de usuários feito em **C# + .NET**, que solicita nome, email e idade, realizando validações antes de armazenar os dados em memória. É possível listar todos os usuários e buscar por nome.

---

## 🚀 Funcionalidades

### 1. Cadastro de Usuário – `CadastrarUsuario()`  
Permite o cadastro de usuários com:
- **Nome** 
- **Email** (deve conter o símbolo `@`)
- **Idade** (número inteiro)

**Trecho de Código:**
```csharp
Console.WriteLine("Digite o seu nome:");
string nome = Console.ReadLine();
```

---

### 2. Validação de Dados  
Valida se:
- Email contém `@`.
- Idade é um número inteiro válido.

**Verificação de @ no Email:**
```csharp
while (!email.Contains("@"))
{
    Console.WriteLine("Por favor, digite um email válido contendo '@'.");
    email = Console.ReadLine();
}
```

**Verificação se a Idade é Número Inteiro:**
```csharp
bool idadeValida = int.TryParse(Console.ReadLine(), out int idade);
while (!idadeValida)
{
    Console.WriteLine("Idade inválida. Digite um número inteiro:");
    idadeValida = int.TryParse(Console.ReadLine(), out idade);
}
```

---

### 3. Armazenamento de Usuários  
Usuários são armazenados numa lista em memória.

**Trecho de Código:**
```csharp
usuarios.Add(novoUsuario);
```

---

### 4. Listagem de Usuários  
Exibe todos os usuários cadastrados.

**Trecho de Código:**
```csharp
foreach (InformacoesUsuario usuario in usuarios)
{
    Console.WriteLine($"Nome: {usuario.Nome}, Email: {usuario.Email}, Idade: {usuario.Idade}");
}
```

---

### 5. Busca por Nome  
Permite buscar um usuário pelo nome.

**Trecho de Código:**
```csharp
var usuarioEncontrado = usuarios.Find(u => u.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase));
```

---

## ⚙️ Como Rodar o Projeto

### Pré-requisitos:
- INSTALE [.NET SDK](https://dotnet.microsoft.com/download)

### Passos:
1. Clone o repositório.
2. Navegue até a pasta do projeto.
3. Execute:
```bash
dotnet run
```

---

## 🟢 Diferenciais Implementados

- Validação de dados completa.
- Armazenamento dinâmico em lista.
- Busca eficiente por nome.
- Feedback com mensagens de sucesso ou erro.

---

Criado por: Ailton Rodrigues Mazullo Neto | Contato: ailtonrodriguesdev@gmail.com

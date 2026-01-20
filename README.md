<div align="center">

# **Sistema de Gestão de Biblioteca (API) <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" width="35" height="35" align="center" />**

### **Este projeto é uma API RESTful desenvolvida para gerenciar o acervo de uma biblioteca. O sistema permite realizar o CRUD completo de livros, integrando uma base de dados SQL Server e seguindo padrões de arquitetura profissional.**

---

## **Tecnologias e Padrões Utilizados**

**Linguagem:** C# (.NET 8/9).

**Framework Web:** ASP.NET Core Web API.

**ORM:** Entity Framework Core (Abordagem Code First).

**Banco de Dados:** SQL Server.

<img src="https://github.com/user-attachments/assets/0f658aa0-793f-4adb-862a-64f153991aac" width="800" alt="Screenshot SQL Server" />

**Padrão de Projeto:** Repository Pattern (para desacoplamento da lógica de dados).

**Documentação:** Swagger UI (OpenAPI) para testes de endpoints.

---

## **Estrutura do Projeto**

**O projeto foi organizado seguindo a separação de responsabilidades para facilitar a manutenção e escalabilidade:**

**Controllers/:** Gerenciamento dos endpoints e requisições HTTP.

**Models/:** Definição das entidades de negócio.

**Repositories/:** Camada de abstração para acesso aos dados.

**Data/:** Contexto do banco de dados e configurações do EF Core.

---

## **Como Executar o Projeto**

**1. Clonar o repositório:**

git clone [https://github.com/seu-usuario/BibliotecaAPI.git](https://github.com/seu-usuario/BibliotecaAPI.git)

**2. Configurar o Banco de Dados:**

**No arquivo `appsettings.json`, ajuste a string de conexão para o seu servidor local.**

**3. Executar Migrations:**

dotnet ef database update

**4. Executar a API:**
   
dotnet run

Com o banco configurado, use o comando abaixo para compilar e iniciar a aplicação:

**Execute o comando abaixo para que o Entity Framework crie automaticamente o banco de dados e as tabelas no seu SQL Server:**

dotnet ef database update

5. Acessar a documentação:

Abra http://localhost:5099/swagger no seu navegador para testar os endpoints.

<img src="https://github.com/user-attachments/assets/39942433-c8d4-47bf-a123-4c04131a2bd3" width="900" alt="Screenshot Swagger" />

📝 Próximos Passos (Roadmap)

[ ] Implementar autenticação JWT.

[ ] Adicionar lógica de empréstimo de livros com validação de estoque.

[ ] Criar testes unitários com xUnit.

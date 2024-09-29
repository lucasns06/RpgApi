# RPG API
Para começar, o comando para criar uma API é 
```cmd
dotnet new webapi 
```
Usamos o padrão MVC, em projetos WebAPI

![image](https://github.com/user-attachments/assets/7ab9a9a9-78f0-4031-b117-e17273e1ce1e)

Divide a lógica em três elementos conectados.

O usuário requisita dados de um Controlador, que carrega o Modelo e exibe em uma visualização

Quando se cria uma api (pelo menos aqui no visual studio), vem com uma controller pronta, de clima, a WeatherForecast.
para executar, você usa o comando
```cmd
dotnet run
```
Ao dar o comando vai aparecer no terminal um link localhost, se você clicar não vai acontecer nada, porque você tem que colocar uma controller para executar algum comando.

Você pode usar o Swagger ou o PostMan para testar, ou colocar o controller no link do localhost, depois da barra, tipo:

http://localhost:5289/PersonagensExemplo/getAll

## Controller Personagens Exemplo

Esta controller tem uma lista de personagens e Requisições com métodos. Exemplos:

As requisições HTTP são uma maneira do navegador/aplicativo se comunica com um site/API. O protocólo HTTP define diferentes tipos de requisições:

1. GET
2. POST
3. PUT
4. DELETE

Quando se faz uma requisição, o controller recebe a requisição e aplica a lógica apropriada, com base no tipo da requisição.

- O **GET** Busca dados e retorna uma resposta.
- O **POST** Recebe os dados enviados pelo cliente, valida de salva no banco de dados.
- O **PUT** Atualiza dados existentes.
- O **DELETE** Obviamente ele remove.

No exemplo visto antes, o controller é o PersonagensExemplo, a requisição é HttpGet, e o método é GetAll, que retorna todos os personagens da lista.

Estrutura:
```cSharp
 [HttpGet("GetAll")] //Requisição get, método com o nome GetAll
        public IActionResult Get()
        {
            return Ok(personagens); //retorna a lista de personagens
        }
```

Você pode usar os métodos com paramêtros, colocando entre chaves {} no nome do método, e o parametro (int id). Exemplo:
```cSharp
  [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(personagens.FirstOrDefault(pe => pe.Id == id));
        }
```
## Estrutura da API

Aqui explicarei a estrutura das pastas dentro de uma API:

- Models
- Controllers
- Data

## Models
Contém as classes que representam os dados ou personagens do projeto

## Controllers
Contém classes que lidam com as requisições feitas pelos clientes

## Data

Geralmente contém a configuração do banco de dados e a classe do DbContext.

### DbContext ?

O DbContext atua como uma ponte, permitindo que você trabalhe com os dados no banco de dados de maneira orientada a objetos.

Ela permite realizar operações CRUD. (CREATE, READ, UPDATE, DELETE)

Ai entramos na parte de banco de dados e Frameworks ORM (Object-Relational Mapping)

# Relação com banco de dados

Abra o terminal e instale o pacote digitando
```cmd
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
Agora a ferramenta para trabalhar com comandos Migration
```cmd
dotnet tool install --global dotnet-ef  
```
E depois mais um comando, que instala um pacote que permite customizar as tabelas do banco de dados usando c#
```cmd
dotnet add package Microsoft.EntityFrameworkCore.Design 
```

Ai você cria a pasta Data, e dentro criar a classe DataContext.cs, para usar o Framework, utilizamos uma herança à  classe DbContext.
```csharp
using Microsoft.EntityFrameworkCore; //tem que aparecer o using

public class DataContext : DbContext // herança 
{

}
```

Depois criar um construtor (o construtor sempre tem o mesmo nome da classe e o método de acesso publico)

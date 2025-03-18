<p align="center">
   <img width="500em" src="https://github.com/user-attachments/assets/586ff36f-0202-4a1c-8455-da00697ffc34">
</p>

# API de RPG

Esta é uma API de RPG criada em C# utilizando .NET 8. 

A API permite gerenciar personagens, habilidades, disputas e armas em um jogo de RPG.

Com uma Autenticação de Usuarios via Tokens

## Tecnologias Utilizadas

- .NET 8
- Entity Framework Core

## Estrutura do Projeto

- `Arma`: Representa uma arma utilizada pelos personagens.
- `Disputa`: Representa uma disputa entre personagens.
- `Habilidade`: Representa uma habilidade que um personagem pode possuir.
- `Personagem`: Representa um personagem do RPG.
- `PersonagemHabilidade`: Representa a relação entre personagens e habilidades.
- `Usuario`: Representa um usuário do sistema.

## Como rodar o projeto

Clone este repositório:

```bash
   git clone https://github.com/lucasns06/RpgApi.git
```

Configure o caminho do banco de dados no arquivo appsettings.json.

Atualize o banco de dados
```bash
   dotnet ef database update
```

E depois

```bash
   dotnet run
```

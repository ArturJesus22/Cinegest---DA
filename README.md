
# Sistema de Gestão de Cinema

**CineGest** é um sistema de gestão desenvolvido para um cinema, permitindo gerenciar todas as operações relacionadas ao negócio. O software implementa diversas funcionalidades, desde a criação e manutenção dos filmes em exibição até a emissão de bilhetes para os clientes, além de fornecer recursos para armazenar dados dos trabalhadores.

## Funcionalidades Principais

1.  **Configuração do Cinema**: Antes de utilizar a aplicação, é necessário configurar as informações iniciais do cinema, como nome, morada e email. Esses dados podem ser editados a qualquer momento, mas apenas existe um cinema de cada vez.
    
2.  **Gestão de Salas**: O cinema pode ter um número configurável de salas. Cada sala possui um número de filas e colunas para os lugares, o que pode ser definido pelo usuário.
    
3.  **Filmes em Exibição**: É possível associar filmes às sessões, agendando datas e horários específicos para exibição. Um filme pode estar em exibição em mais de uma sala.
    
4.  **Categorias de Filmes**: Cada filme é categorizado em uma das seguintes categorias: Comédia, Sci-fi, Terror, Romance, Ação, Thriller, Drama, Mistério, Crime, Aventura, Fantasia ou Animação.
    
5.  **Sessões**: Para cada sala, é possível criar sessões, definindo o filme associado a uma determinada data e hora.
    
6.  **Venda de Bilhetes**: Durante uma sessão, é possível emitir bilhetes para os clientes. Cada bilhete possui um lugar único associado a ele. O estado do bilhete pode ser alterado para indicar se foi utilizado ou não.
    
7.  **Clientes**: Os bilhetes podem ser adquiridos por clientes anônimos ou por clientes previamente registrados no sistema. A opção de salvar os dados do cliente permite agilizar compras futuras.
    
8.  **Funcionários**: É possível criar e gerenciar funcionários no programa. Durante a utilização, é permitido alterar o funcionário que está utilizando o sistema.
    
9.  **Visualização de Clientes**: O sistema oferece uma lista de todos os clientes, exibindo informações como nome, morada, número fiscal, número e valor total de bilhetes adquiridos.
    
10.  **Dados**: Os dados são guardados em SQL Server, utilizando a *Entity Framework* para garantir a segurança dos dados.

## Pré-requisitos

 - SO Compatível (Testado em Windows)
 - Microsoft Visual Studio (2015 ou mais recente) 
 - Microsoft .NET Framework instalada

## Known Issues

 - Falha em Algumas Validações
 - Atribuição de Bilhetes não funcional
 - Sistema apenas funciona corretamente em `C:\Users\Username\Desktop`

## Developers

> **Tomás Coelho** /
> **Artur Jesus** / 
> **Gonçalo Delgado**

![](https://www.ipleiria.pt/wp-content/themes/ipleiria/img/logo_ipl_header.png)

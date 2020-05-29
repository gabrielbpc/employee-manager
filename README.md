# employee-manager

[![Gabriels](https://img.shields.io/badge/Gabriel-Silva-blue.svg?longCache=true&style=for-the-badge)](https://gabriel.com.br)

Iremos desenvolver um sistema para cadastro de funcionários maiores de 18 anos e que tenha ao menos uma habilidade

O sistema precisa conter as seguintes funcionalidades 

Cadastro/Edição dos Funcionários
* Nome Completo (obrigatório inclusive o sobrenome)
* Data Nascimento (obrigatório e a data deve estar no formato BR)
* Email (não obrigatório mas quando preenchido deve ser válido)
* Sexo (obrigatório)
* Habilidades (C#, Java, Angular, SQL, ASP) (obrigatório) 


Relatório 
* Filtro por: Idade, Sexo, Habilidades (diferencial), Nome (autcomplete diferencial)
* Colunas: Nome, Data Nascimento, Idade, Email, Sexo, Habilidades, Opção para Ativar / Desativar
* Paginação (diferencial)
* Ao entrar no relatório deve trazer todos os registros cadastrados sem a necessidade de filtrar


Tecnologias a serem utilizadas:

* WEB API C#
* EntityFramework (Code First) ou Dapper
* Angular ou MVC (Senior)
* MS SQL Server
* TDD (diferencial)


** Caso utilize o Dapper criar uma pasta dentro da solution com o nome "Scripts DB" e salvar as consultas.
** Caso utilize EF os dados como Sexo e Habilidade devem estar dentro do Migration não havendo a necessidade do desenvolvedor inserir no banco.

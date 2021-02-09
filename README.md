# SoftPlan
Teste asp.Net Core

- Para a excução é necessario ter o .Net Core 3.1, Docker for Windows com o Hyper-V backend.

- Quando for executar o projeto, setar como inicio do projeto o docker-compose.
  Nele sera criado dois containers, cada um com a aplicação.
 
Para testar as rotas são:

  - https://localhost:49316/Swagger

Testando com o container

  - http://localhost:3000/TaxaJuros
  
  - http://localhost:3001/CalculaJuros/?valorinicial=100&meses=5
  - http://localhost:3001/showmethecode
  
Utilizado modelagem DDD para montar aplicação.




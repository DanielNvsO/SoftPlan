# SoftPlan
Teste asp.Net Core

1 - VS 2019
- Para a excução é necessario ter o .Net Core 3.1, Docker for Windows com o Hyper-V backend.

- Quando for executar o projeto, setar como inicio do projeto o docker-compose.
  Nele sera criado dois containers, cada um com a aplicação.
  
2 - Powershell docker
- Acessar a pasta onde contem a solutions.

-Rodar os comandos:

- docker-compose build

- docker-compose up -d

Para testar as rotas são:
  
  VS 2019
  
  - https://localhost:49316/Swagger

  Powershell docker
  
  - http://localhost:3001/Swagger
  
Testando com o container

  - http://localhost:3000/TaxaJuros 
  
  - http://localhost:3001/CalculaJuros/?valorinicial=100&meses=5
  - http://localhost:3001/showmethecode
  
  
  PROJETO
  
  Utilizado modelagem DDD para montar aplicação.




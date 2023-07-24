# Aplicação construida para participar do processo seletivo da Localize


### Backend
    Requisitos: 
        - .NET 6 ou superior
        - docker (se for executar utilizando docker)
        OBS: O docker compose cria o banco e as tabelas, não é necessário executar as queries caso esteja executando no docker

    caso você não for utilizar docker:
        - SQL Server 2017 ou superior
        - executar as queries de criação do banco e tabelas que estão no arquivo init.sql


    execute o arquivo docker-compose.yaml dentro da pasta backend com o seguinte comando:

    - docker-compose up -d 

    executar a aplicação backend no Visual Studio ou Visual Studio Code


### Frontend
    Requisitos:
        - Angular 16 ou superior
        - Node 18 ou superior

    execute o seguinte comando dentro da pasta frontend:
        - npm install

    após a instalação dos pacotes, execute a aplicaçao:
        - ng s -o
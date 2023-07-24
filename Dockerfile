# Use a imagem oficial do Microsoft SQL Server para Linux
FROM mcr.microsoft.com/mssql/server:2019-latest

EXPOSE 1433

ENV SA_PASSWORD=sqlserver@2023
ENV MSSQL_SCRIPT=init.sql
ENV ACCEPT_EULA=Y

WORKDIR /src/app
COPY ./init.sql /src/app/
COPY ./entrypoint.sh /src/app/

CMD /bin/bash ./entrypoint.sh


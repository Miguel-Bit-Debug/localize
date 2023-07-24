#!/bin/bash

# Run init-script with long timeout - and make it run in the background
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "sqlserver@2023" -i init.sql & /opt/mssql/bin/sqlservr
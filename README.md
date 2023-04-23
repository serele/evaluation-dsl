# DSL para evaluar actividades de CODE.ORG

Para lanzar los tests ejecutar:
>dotnet test --collect:"XPlat Code Coverage"

Para generar informes en HTML de los tests:
>reportgenerator -reports:".\Tests\TestResults\{ULTIMA CARPETA GENERADA}\coverage.cobertura.xml" -targetdir:"coverageresults" -reporttype:html


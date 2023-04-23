# DSL para evaluar actividades de CODE.ORG

Para lanzar los tests ejecutar:
>dotnet test --collect:"XPlat Code Coverage"

Para generar informes en HTML de los tests:
>reportgenerator -reports:".\Tests\TestResults\6fde6a81-861c-42f1-ad2c-a31ffc0076b1\coverage.cobertura.xml" -targetdir:"coverageresults" -reporttype:html

[Informe de cobertura de tests](coverageresults%2Findex.html)
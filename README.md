# DSL para evaluar actividades de CODE.ORG

Se necesita tener instalado el framework [dotnet 7.0](TestsCoverageResults%2FEvaluationDSL_Activity.html)
y se han incluido los siguientes paquetes NuGet:

* xunit 2.4.2
* xunit.runner.visualstudio 2.4.5
* coverlet.collector 3.1.2
* dotnet-reportgenerator-globaltool 5.1.19

Para lanzar los tests ejecutar en el terminal:
>dotnet test --collect:"XPlat Code Coverage"

esto generará el fichero [coverage.cobertura.xml](Tests%2FTestResults%2Fdc103550-4a1d-48ab-901a-e4d0b5ec2e40%2Fcoverage.cobertura.xml)

El [informe con los resultados de la cobertura de los test](https://htmlpreview.github.io/?https://github.com/serele/evaluation-dsl/blob/main/coverageresults/index.html) se ha generado ejecutando:
>dotnet reportgenerator -reports:.\Tests\TestResults\dc103550-4a1d-48ab-901a-e4d0b5ec2e40\coverage.cobertura.xml -targetdir:TestsCoverageResults -reporttype:html

[informe con los resultados de la cobertura de los test](TestsCoverageResults%2Findex.html)

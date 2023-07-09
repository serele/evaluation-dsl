# Lenguaje de Dominio Específico para la evaluación de actividades de Pensamiento Computacional

Este proyecto es un DSL cuya función es la evaluación de actividades de pensamiento computacional de la plataforma [code.org](https://studio.code.org/home).

Para la extracción de los datos dicha plataforma se ha desarrollado una [extensión de Chrome](https://github.com/serele/code.org-spy) que genera ficheros json que posteriormente serán evaluados mediante el DSL.


Se necesita tener instalado el framework [dotnet 7.0](TestsCoverageResults%2FEvaluationDSL_Activity.html)
y se han incluido los siguientes paquetes NuGet:

* xunit 2.4.2
* xunit.runner.visualstudio 2.4.5
* coverlet.collector 3.1.2
* dotnet-reportgenerator-globaltool 5.1.19

Para lanzar los tests ejecutar en el terminal:
>dotnet test --collect:"XPlat Code Coverage"

esto generará el fichero [coverage.cobertura.xml](Tests%2FTestResults%2Fd32cfb67-b226-4f15-b1d1-858d00276eaa%2Fcoverage.cobertura.xml)

El [informe con los resultados de la cobertura de los test](https://htmlpreview.github.io/?https://github.com/serele/evaluation-dsl/blob/main/TestsCoverageResults/index.html) se ha generado ejecutando:
>dotnet reportgenerator -reports:.\Tests\TestResults\Fd32cfb67-b226-4f15-b1d1-858d00276eaa\coverage.cobertura.xml -targetdir:TestsCoverageResults -reporttype:html

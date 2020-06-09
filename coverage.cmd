dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=../../coverage/ /p:Exclude=[xunit.*]*
cd ./coverage
reportgenerator "-reports:.\coverage.cobertura.xml" "-targetdir:."
if [%1]==[] goto openCoverage

:openCoverage
start index.htm
exit 1

cd ..
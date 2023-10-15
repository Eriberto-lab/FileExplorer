
using FileExplorer.Service;


var currentDirectory = Directory.GetCurrentDirectory(); // pega o caminho do diretorio atual
var storesDirectory = Path.Combine(currentDirectory, "stores"); //  pega o caminho do diretorio de onde esta as vendas

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");// caminho de onde ficara o resultado do total das vendas
// criando a pasta onde ficara o arquivo com o total de vendas:
Directory.CreateDirectory(salesTotalDir);

var salesFiles = FindFiles.FindFilesJson(storesDirectory); //encontrando todos os arquivos que contém o número de vendas do tipo json

var salesTotal = Calculate.CalculateSalesTotal(salesFiles);// calcula o total das vendas

try
{
    File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}"); // adiciona o total calculado no novo arquivo 'totals.txt'
}
catch (Exception ex)
{

    Console.WriteLine($"An error occurred while write file: {ex.Message}");
}
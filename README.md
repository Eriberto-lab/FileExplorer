# FileExplorer with C#

## Projeto de Estudos

Este projeto tem como objetivo estudar e praticar conceitos de manipulação de arquivos em C#. O programa lê arquivos JSON contendo informações de vendas de diversas lojas e calcula o total de vendas. Em seguida, o programa cria um arquivo de texto com o total de vendas calculado.

## Como executar o programa

1. Clone o repositório em sua máquina local.
2. Abra o projeto em um editor de código, como o Visual Studio Code.
3. Execute o programa a partir do arquivo `Program.cs`.
4. Verifique se o arquivo `totals.txt` foi criado na pasta `salesTotalDir`.

## Comandos utilizados

- `Directory.GetCurrentDirectory()`
- `Path.Combine()`
- `Directory.CreateDirectory()`
- `FindFiles.FindFilesJson()`
- `Calculate.CalculateSalesTotal()`
- `File.AppendAllText()`

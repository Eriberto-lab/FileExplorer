

namespace FileExplorer.Service;

public class FindFiles
{


    public static IEnumerable<string> FindFilesJson(string folderName)
    {
        List<string> salesFiles = new List<string>();

        try
        {
            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);//EnumerateFiles cria uma coleção de Enumetable

            var jsonFiles = from file in foundFiles
                            where file.Contains(".json")
                            select file;

            salesFiles.AddRange(jsonFiles);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while searching for files: {ex.Message}");
        }

        return salesFiles;


    }
}

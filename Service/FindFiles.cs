

namespace FileExplorer.Service;

public class FindFiles
{


    public static IEnumerable<string> FindFilesJson(string folderName)
    {
        List<string> salesFiles = new List<string>();

        try
        {
            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);//EnumerateFiles cria uma coleção de Enumetable

            foreach (var file in foundFiles)
            {
                var extension = Path.GetExtension(file);

                if (extension == ".json")
                {
                    salesFiles.Add(file);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while searching for files: {ex.Message}");
        }

        return salesFiles;


    }
}

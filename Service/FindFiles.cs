

namespace FileExplorer.Service;

public class FindFiles
{


    public static IEnumerable<string> FindFilesJson(string folderName)
    {
        List<string> salesFiles = new List<string>();

        var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

        foreach (var file in foundFiles)
        {
            var extension = Path.GetExtension(file);

            if (extension == ".json")
            {
                salesFiles.Add(file);
            }
        }

        return salesFiles;
    }
}
using Newtonsoft.Json;
using FileExplorer.Model;

namespace FileExplorer.Service;

public class Calculate
{
    public static decimal CalculateSalesTotal(IEnumerable<string> salesFiles)
    {
        decimal salesTotal = 0;

        // READ FILES LOOP
        // Loop over each file path in salesFiles
        foreach (var file in salesFiles)
        {
            // Read the contents of the file
            string salesJson = File.ReadAllText(file);

            // Parse the contents as JSON
            SalesTotal? data = JsonConvert.DeserializeObject<SalesTotal?>(salesJson);

            // Add the amount found in the Total field to the salesTotal variable
            salesTotal += data?.Total ?? 0;
        }

        return salesTotal;
    }
}

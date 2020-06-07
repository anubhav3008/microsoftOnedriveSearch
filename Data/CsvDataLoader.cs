using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using PartsInventoryConnector.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PartsInventoryConnector.Data
{
    public static class CsvDataLoader
    {
        public static List<AppliancePart> LoadPartsFromCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.RegisterClassMap<AppliancePartMap>();
                return new List<AppliancePart>(csv.GetRecords<AppliancePart>());
            }
        }
    }

    public class AppliancePartMap : ClassMap<AppliancePart>
    {
        public AppliancePartMap()
        {
            Map(m => m.Id);
            Map(m => m.Title);
            Map(m => m.Text);
            Map(m => m.Url);
        }
    }
}
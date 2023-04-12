using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperDemo
{
    public class Operation
    {
        public static void ImplementCSVHandling()
        {
            List<Model> records = new List<Model>();
            string importFilePath = @"D:\BridgeLabz\CSVHelperDemo\CSVHelperDemo\data.csv";
            string exportFilePath = @"D:\BridgeLabz\CSVHelperDemo\CSVHelperDemo\csvFile.csv";
            using (var reader = new StreamReader(importFilePath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csvReader.GetRecords<Model>().ToList();
                Console.WriteLine("Reading CSV File");
                Console.WriteLine("=========================");
                foreach (var data in records)
                {
                    Console.WriteLine(data.name + "\n" + data.email + "\n" + data.phone + "\n" + data.country);
                }
            }
            using (var writer = new StreamWriter(exportFilePath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }
        }
        public static void ImplementCSVToJson()
        {
            List<Model> records = new List<Model>();
            string importFilePath = @"D:\BridgeLabz\CSVHelperDemo\CSVHelperDemo\data.csv";
            string exportFilePath = @"D:\BridgeLabz\CSVHelperDemo\CSVHelperDemo\csvFile.json";
            using (var reader = new StreamReader(importFilePath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csvReader.GetRecords<Model>().ToList();
                Console.WriteLine("Reading CSV File");
                Console.WriteLine("=========================");
                foreach (var data in records)
                {
                    Console.WriteLine(data.name + "\n" + data.email + "\n" + data.phone + "\n" + data.country);
                }
            }
            var json = JsonConvert.SerializeObject(records);
            File.WriteAllText(exportFilePath, json);
        }
    }
}

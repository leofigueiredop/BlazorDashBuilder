using Rampfy.BlazorDash.Shared.Models;

namespace Rampfy.BlazorDash.Server.Services
{
    public class CsvService
    {
        private CsvData _csvData;

        public CsvService(string csvFilePath)
        {
            _csvData = LoadCsvData(csvFilePath);
        }

        private CsvData LoadCsvData(string csvFilePath)
        {
            CsvData csvData = new CsvData();

            try
            {
                string[] lines = File.ReadAllLines(csvFilePath);
                string[] headers = lines[0].Split(',');

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');

                    Dictionary<string, string> row = new Dictionary<string, string>();
                    for (int j = 0; j < headers.Length; j++)
                    {
                        row.Add(headers[j], values[j]);
                    }

                    csvData.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading CSV data: " + ex.Message);
            }

            return csvData;
        }

        public List<Dictionary<string, string>> GetRows()
        {
            return _csvData.Rows;
        }

        public List<string> GetColumnNames()
        {
            return _csvData.Rows[0].Keys.ToList();
        }

        public List<string> GetColumnValues(string columnName)
        {
            List<string> values = new List<string>();

            foreach (var row in _csvData.Rows)
            {
                if (row.TryGetValue(columnName, out string value))
                {
                    values.Add(value);
                }
            }

            return values;
        }

        public List<Dictionary<string, string>> FilterRowsByColumnValue(string columnName, string columnValue)
        {
            List<Dictionary<string, string>> filteredRows = new List<Dictionary<string, string>>();

            foreach (var row in _csvData.Rows)
            {
                if (row.TryGetValue(columnName, out string value) && value == columnValue)
                {
                    filteredRows.Add(row);
                }
            }

            return filteredRows;
        }


    }
}
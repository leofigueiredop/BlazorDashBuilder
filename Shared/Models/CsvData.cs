namespace Rampfy.BlazorDash.Shared.Models
{
    public class CsvData
  {
    public List<Dictionary<string, string>> Rows { get; set; }

    public CsvData()
    {
      Rows = new List<Dictionary<string, string>>();
    }
  }

}

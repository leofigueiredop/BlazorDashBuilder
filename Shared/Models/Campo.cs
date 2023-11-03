using Rampfy.BlazorDash.Shared.Enums;


namespace Rampfy.BlazorDash.Shared.Models
{
    public class Campo
    {
        public int CodigoIndicador { get; set; }
        public string? NomeIndicador { get; set; }
        public string? LabelIndicador { get; set; }
        public int CodigoCampo { get; set; }
        public string? NomeCampo { get; set; }
        public string? LabelCampo { get; set; }
        public TipoDado TipoDado { get; set; }

        public object? Valor {get; set;}
    }
}
using System;
using Rampfy.BlazorDash.Shared.Enums;

namespace Rampfy.BlazorDash.Shared.Models
{
    public class Dashboard
    {
       public int Id_met { get; set; }
        public DateTime DataCri_met { get; set; }
        public DateTime DataAtu_met { get; set; }
        public int CodigoCliente_met { get; set; }
        public int CodigoUsuCri_met { get; set; }
        public int CodigoIndicador_met { get; set; }
        public int CodigoCampo_met { get; set; }
        public int? CodigoAgrupador_met { get; set; }
        public string Label_met { get; set; }
        public Agregacao Agregacao_met { get; set; }
    }
}
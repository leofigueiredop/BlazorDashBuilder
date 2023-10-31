
using System.Dynamic;
using Rampfy.BlazorDash.Shared.Enums;


namespace Rampfy.BlazorDash.Shared.Models
{
    public class Componente
    {
        public int Id_com { get; set; }
        public required string Titulo_com { get; set; }
        public DateTime DataCri_com { get; set; }
        public DateTime DataAtu_com { get; set; }

        public int CodigoCliente_com { get; set; }
        public int CodigoUsuCri_com { get; set; }
        public TipoDado TipoDado_com { get; set; }

        public FormatoExibicao formatoExibicao_com { get; set; }
        public NivelVisaoDados NivelVisaoDados_com { get; set; }
        public bool MultiplosKpis_com { get; set; }
        public bool CompararAtualFechamentoMesAnterior_com { get; set; }
        public bool CompararAtualFechamentoMesAnoAnterior_com { get; set; }
        public bool CompararComMeta { get; set; }
        public bool CompararComProjetado { get; set; }
        public bool CompararAtualDiaMesAnterior_com { get; set; }
        public bool CompararAtuaDiaAnoPassado_com { get; set; }
        public TipoGrafico TipoGrafico_com { get; set; }

    }
}
namespace Rampfy.BlazorDash.Shared.Models
{
    public class Dashboard
    {
        public int Id_dash { get; set; }
        public string? Label_dash { get; set; }
        public int Colunas_dash { get; set; }
        public int Linhas_dash { get; set; }
        public DateTime DataCri_dash { get; set; }
        public DateTime DataAtu_dash { get; set; }
        public int CodigoCliente_dash { get; set; }
        public int CodigoUsuCri_dash { get; set; }

        public List<Componente>? Componentes { get; set; }


    }
}
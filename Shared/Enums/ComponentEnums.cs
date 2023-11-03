namespace Rampfy.BlazorDash.Shared.Enums
{

    // Enum para o formato de exibição
    public enum FormatoExibicao
    {
        posicao_atual = 1,
        evolucao_mensal = 2,
        evolucao_diaria = 3,
        card = 4
    }

    // Enum para o nível de visão dos dados
    public enum NivelVisaoDados
    {
        unidade = 1,
        divisao = 2,
        pessoa = 3,
        kpi = 4
    }
    public enum TipoDado
    {
        currency = 1,
        integer = 2,
        percentage = 3
    }

    // Enum para o tipo de gráfico
    public enum TipoGrafico
    {
        bar = 1,
        stacked_bar = 2,
        line = 3,
        stacked_area = 4,
        pie = 5,
        donut = 6,
        tableView = 7,
        treeView = 8
    }
    public enum Comparacao
    {
        ind_cam_executado = 1,
        ind_cam_projetado = 2,
        ind_cam_meta = 3,
        ind_cam_percentual_atingido = 4,
        ind_cam_percentual_projetado = 5
    }


    public enum Agregacao
    {
        SUM = 1,
        AVG = 2,
        MIN = 3,
        MAX = 4
    }

     public enum AxysType
    {
        X = 1,
        Y = 2
    }
}
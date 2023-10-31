using System;

namespace Rampfy.BlazorDash.Shared.Enums
{

    // Enum para o formato de exibição
    public enum FormatoExibicao
    {
        posicao_atual = 1,
        evolucao_mensal = 2,
        evolucao_diaria = 3,
        totalizador = 4
    }

    // Enum para o nível de visão dos dados
    public enum NivelVisaoDados
    {
        unidade = 1,
        divisao = 2,
        pessoa = 3
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


public enum Agregacao
    {
        SUM = 1,
        AVG = 2,
        MIN = 3,
        MAX = 4
    }
}
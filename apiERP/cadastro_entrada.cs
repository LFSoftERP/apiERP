//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace apiERP
{
    using System;
    using System.Collections.Generic;
    
    public partial class cadastro_entrada
    {
        public cadastro_entrada()
        {
            this.alas_do_armazem_lotes = new HashSet<alas_do_armazem_lotes>();
            this.autorizacao_lotes = new HashSet<autorizacao_lotes>();
            this.lotes_compoe_carregamento = new HashSet<lotes_compoe_carregamento>();
            this.lote_instrucao = new HashSet<lote_instrucao>();
            this.lote_situacaonorma = new HashSet<lote_situacaonorma>();
            this.lote_composicao = new HashSet<lote_composicao>();
            this.complementacoes_lote = new HashSet<complementacoes_lote>();
            this.defeito_cafe_cadastro_lote = new HashSet<defeito_cafe_cadastro_lote>();
            this.lotes_do_fechamento_e_hedge = new HashSet<lotes_do_fechamento_e_hedge>();
            this.formulario_exercicio_rastreabilidade_balanco_massa = new HashSet<formulario_exercicio_rastreabilidade_balanco_massa>();
            this.notas_de_origem = new HashSet<notas_de_origem>();
            this.lote_producao_rastreabilidade = new HashSet<lote_producao_rastreabilidade>();
            this.lote_origem_do_result_reb = new HashSet<lote_origem_do_result_reb>();
            this.referenciar_lotes_armazem_terceiros = new HashSet<referenciar_lotes_armazem_terceiros>();
            this.lote_nota_cancelada = new HashSet<lote_nota_cancelada>();
            this.lotes_origem_do_produto = new HashSet<lotes_origem_do_produto>();
            this.movimentos_produtos_contabeis = new HashSet<movimentos_produtos_contabeis>();
            this.movimentos_produtos_contabeis1 = new HashSet<movimentos_produtos_contabeis>();
            this.solicitacao_de_amostra_lote = new HashSet<solicitacao_de_amostra_lote>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_COOPERADO { get; set; }
        public string TXT_LOTE { get; set; }
        public decimal FLOAT_QTD_SACAS { get; set; }
        public float FLOAT_PESO_LIQ { get; set; }
        public Nullable<int> INT_ID_BEBIDA { get; set; }
        public Nullable<float> FLOAT_TEOR_UMIDADE { get; set; }
        public Nullable<int> INT_CATACAO { get; set; }
        public Nullable<int> INT_NF { get; set; }
        public System.DateTime DATE_ENTRADA { get; set; }
        public Nullable<int> INT_ID_TALHAO { get; set; }
        public Nullable<int> INT_ID_SUBTIPO { get; set; }
        public int INT_ID_ALMOXARIFADO { get; set; }
        public Nullable<int> INT_14UP { get; set; }
        public Nullable<int> INT_16UP { get; set; }
        public Nullable<int> INT_17UP { get; set; }
        public Nullable<decimal> FLOAT_PONTUACAO { get; set; }
        public string TXT_SAFRA { get; set; }
        public bool BOOL_FLAG_MEXER_NMEXER { get; set; }
        public Nullable<int> INT_18UP { get; set; }
        public bool BOOL_TIPO { get; set; }
        public bool BOOL_FLAG { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public Nullable<decimal> DECIMAL_CATACAO_MERCADO { get; set; }
        public bool BOOL_TRANSICAO { get; set; }
        public Nullable<int> INT_FUNCIONARIO { get; set; }
        public decimal FLOAT_SACAS_DEVOLVIDAS { get; set; }
        public Nullable<decimal> DECIMAL_VALOR_UNITARIO_NF_ENTRADA { get; set; }
        public string TXT_MOTIVO_DE_NAO_MEXER { get; set; }
        public string TXT_OBS { get; set; }
        public Nullable<int> INT_VAZAMENTO { get; set; }
        public bool BOOL_CAFE_BORDADURA { get; set; }
        public Nullable<int> INT_ID_AGENDAMENTO_COOPERADO { get; set; }
        public string TXT_OBS_CLASSIFICACAO { get; set; }
        public decimal DECIMAL_PESO_LIQUIDO_TOTAL { get; set; }
        public bool BOOL_FINALIZOU_DESCARGA { get; set; }
        public string TXT_CODIGO_DE_BARRAS { get; set; }
        public Nullable<bool> BOOL_VINCULAR_NOTA_FILIAL { get; set; }
    
        public virtual agendamento_cooperado agendamento_cooperado { get; set; }
        public virtual ICollection<alas_do_armazem_lotes> alas_do_armazem_lotes { get; set; }
        public virtual almoxarifado almoxarifado { get; set; }
        public virtual ICollection<autorizacao_lotes> autorizacao_lotes { get; set; }
        public virtual bebida bebida { get; set; }
        public virtual ICollection<lotes_compoe_carregamento> lotes_compoe_carregamento { get; set; }
        public virtual ICollection<lote_instrucao> lote_instrucao { get; set; }
        public virtual ICollection<lote_situacaonorma> lote_situacaonorma { get; set; }
        public virtual ICollection<lote_composicao> lote_composicao { get; set; }
        public virtual ICollection<complementacoes_lote> complementacoes_lote { get; set; }
        public virtual cooperado cooperado { get; set; }
        public virtual ICollection<defeito_cafe_cadastro_lote> defeito_cafe_cadastro_lote { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual ICollection<lotes_do_fechamento_e_hedge> lotes_do_fechamento_e_hedge { get; set; }
        public virtual ICollection<formulario_exercicio_rastreabilidade_balanco_massa> formulario_exercicio_rastreabilidade_balanco_massa { get; set; }
        public virtual ICollection<notas_de_origem> notas_de_origem { get; set; }
        public virtual ICollection<lote_producao_rastreabilidade> lote_producao_rastreabilidade { get; set; }
        public virtual ICollection<lote_origem_do_result_reb> lote_origem_do_result_reb { get; set; }
        public virtual ICollection<referenciar_lotes_armazem_terceiros> referenciar_lotes_armazem_terceiros { get; set; }
        public virtual ICollection<lote_nota_cancelada> lote_nota_cancelada { get; set; }
        public virtual ICollection<lotes_origem_do_produto> lotes_origem_do_produto { get; set; }
        public virtual ICollection<movimentos_produtos_contabeis> movimentos_produtos_contabeis { get; set; }
        public virtual ICollection<movimentos_produtos_contabeis> movimentos_produtos_contabeis1 { get; set; }
        public virtual ICollection<solicitacao_de_amostra_lote> solicitacao_de_amostra_lote { get; set; }
        public virtual subtipo_norma subtipo_norma { get; set; }
        public virtual talhao talhao { get; set; }
    }
}
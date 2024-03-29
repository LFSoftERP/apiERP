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
    
    public partial class movimentos_produtos_contabeis
    {
        public movimentos_produtos_contabeis()
        {
            this.premio_ft = new HashSet<premio_ft>();
        }
    
        public int INT_ID { get; set; }
        public int INT_CODIGO_CONTABIL { get; set; }
        public System.DateTime DATE_DATA_NF { get; set; }
        public int INT_NF { get; set; }
        public bool BOOL_ENTRADA_SAIDA { get; set; }
        public Nullable<int> INT_ID_DOC { get; set; }
        public string CHAR_DOC { get; set; }
        public bool BOOL_ATIVO_EXCLUIDO { get; set; }
        public bool BOOL_COMPRA_COMPL { get; set; }
        public Nullable<int> INT_ID_LANCAMENTO_EXTRA { get; set; }
        public Nullable<int> INT_ID_AUTORIZACAO_DEV_COOP { get; set; }
        public Nullable<int> INT_ID_LOTE_DO_FECHAMENTO { get; set; }
        public Nullable<int> INT_ID_NOTA_DE_ORIGEM { get; set; }
        public Nullable<int> INT_ID_CADASTRO_ENTRADA { get; set; }
        public Nullable<int> INT_ORIGEM_DO_PRODUTO { get; set; }
        public Nullable<int> INT_ID_COMPLEMENTACOES_LOTE { get; set; }
        public Nullable<int> INT_ID_LOTE_PRODUTO { get; set; }
        public decimal DECIMAL_QTD { get; set; }
        public Nullable<int> INT_ID_MATERIA_PRIMA_UTILIZADA { get; set; }
        public Nullable<int> INT_ID_CONTAS_A_PAGAR { get; set; }
        public Nullable<decimal> DECIMAL_VALOR { get; set; }
        public Nullable<int> INT_ID_VENDA_PRESTACAO { get; set; }
        public Nullable<System.DateTime> DATA_LANCAMENTO { get; set; }
        public Nullable<int> INT_ID_FUNCIONARIO { get; set; }
        public Nullable<int> INT_ID_EMPRESA { get; set; }
        public Nullable<int> INT_ID_CFOP { get; set; }
        public decimal DECIMAL_PIS { get; set; }
        public decimal DECIMAL_COFINS { get; set; }
        public decimal DECIMAL_ICMS { get; set; }
        public decimal DECIMAL_PISST { get; set; }
        public decimal DECIMAL_COFINSST { get; set; }
        public decimal DECIMAL_ICMSST { get; set; }
        public decimal DECIMAL_IPI { get; set; }
        public decimal DECIMAL_ICMS_PARTILHA { get; set; }
        public string TXT_ICMS_CST { get; set; }
        public string TXT_ORIGEM_ICMS { get; set; }
        public string TXT_ICMS_DESONERACAO { get; set; }
        public string TXT_MODALIDADE_DA_BC { get; set; }
        public decimal DECIMAL_ALIQUOTA_ICMS { get; set; }
        public decimal DECIMAL_REDUCAO_BC_ICMS { get; set; }
        public decimal DECIMAL_BC_OPERACAO_PROPRIA { get; set; }
        public string TXT_MODALIDADE_DE_DET_DA_BC_ICMSST { get; set; }
        public decimal DECIMAL_ALIQUOTA_ICMSST { get; set; }
        public decimal DECIMAL_REDUCAO_BC_ICMSST { get; set; }
        public decimal DECIMAL_MVA { get; set; }
        public string TXT_PIS_CST { get; set; }
        public decimal DECIMAL_ALIQUOTA_PIS { get; set; }
        public decimal DECIMAL_VLR_UN_PIS { get; set; }
        public bool BOOL_PISST { get; set; }
        public decimal DECIMAL_ALIQUOTA_PISST { get; set; }
        public decimal DECIMAL_VLR_UN_PISST { get; set; }
        public string TXT_CST_COFINS { get; set; }
        public decimal DECIMAL_ALIQUOTA_COFINS { get; set; }
        public decimal DECIMAL_VLR_UN_COFINS { get; set; }
        public bool BOOL_COFINSST { get; set; }
        public decimal DECIMAL_ALIQUOTA_COFINSST { get; set; }
        public decimal DECIMAL_VLR_UN_COFINSST { get; set; }
        public decimal DECIMAL_ALIQUOTA_IPI { get; set; }
        public decimal DECIMAL_VLR_UN_IPI { get; set; }
        public string TXT_ENQUADRAMENTO_IPI { get; set; }
        public decimal DECIMAL_MULTA { get; set; }
        public decimal DECIMAL_SEGURO { get; set; }
        public decimal DECIMAL_JUROS { get; set; }
        public decimal DECIMAL_DESCONTO { get; set; }
        public decimal DECIMAL_FRETE { get; set; }
        public decimal DECIMAL_VLR_UN { get; set; }
        public string TXT_NATUREZA_DA_RECEITA { get; set; }
        public Nullable<int> INT_ID_NOTA_FISCAL { get; set; }
        public decimal DECIMAL_BC_ICMS { get; set; }
        public decimal DECIMAL_BC_ICMSST { get; set; }
        public string TXT_CST_IPI { get; set; }
        public decimal DECIMAL_ALIQUOTA_INTERNA_PARA_CALCULO_DIFAL { get; set; }
        public bool BOOL_RETORNO_INDUSTRIALIZACAO { get; set; }
        public Nullable<int> INT_ID_LOTE_REMESSA_RASTREAR_RETORNO { get; set; }
        public Nullable<int> INT_ID_NOTA_CANCELADA { get; set; }
        public Nullable<int> INT_ID_NOTA_ORIGEM_DO_PRODUTO { get; set; }
        public string TXT_IND_ADD_PROD { get; set; }
        public Nullable<int> INT_ID_SOLICITACAO_RETIRADA { get; set; }
        public decimal DECIMAL_TAXA_DOLAR { get; set; }
        public Nullable<int> INT_ID_ALMOXARIFADO { get; set; }
        public Nullable<int> INT_ID_TRANSFERENCIA_PRODUTO { get; set; }
        public Nullable<int> INT_ID_PROCEDIMENTO { get; set; }
        public Nullable<int> INT_ID_DEVOLUCAO_COMPRA { get; set; }
        public Nullable<int> INT_ID_TRANSFERENCIA_ALMOXARIFADO_PRODUTO { get; set; }
        public string CHAR_TIPO_NOTA { get; set; }
        public Nullable<int> INT_ID_COTACAO_ITEM { get; set; }
        public Nullable<int> INT_ID_RESULTADO_REBENEFICIO_NOTA_FILIAL { get; set; }
        public Nullable<int> INT_ID_LOTE_ENTRADA_NOTA_FILIAL { get; set; }
        public Nullable<int> INT_ID_AUTORIZACAO_DE__CARREGAMENTO_NOTA_FILIAL { get; set; }
        public decimal DECIMAL_VALOR_PREMIO_FT { get; set; }
    
        public virtual almoxarifado almoxarifado { get; set; }
        public virtual autorizacao_dev_cooperado autorizacao_dev_cooperado { get; set; }
        public virtual autorizacao_generica autorizacao_generica { get; set; }
        public virtual cadastro_entrada cadastro_entrada { get; set; }
        public virtual cadastro_entrada cadastro_entrada1 { get; set; }
        public virtual cfop cfop { get; set; }
        public virtual complementacoes_lote complementacoes_lote { get; set; }
        public virtual contas_a_pagar_e_receber contas_a_pagar_e_receber { get; set; }
        public virtual cotacao_item cotacao_item { get; set; }
        public virtual devolucao_de_compra devolucao_de_compra { get; set; }
        public virtual empresa empresa { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual lancamento_extras_codigos_contabeis lancamento_extras_codigos_contabeis { get; set; }
        public virtual lote_produto lote_produto { get; set; }
        public virtual lote_produto lote_produto1 { get; set; }
        public virtual lotes_do_fechamento_e_hedge lotes_do_fechamento_e_hedge { get; set; }
        public virtual ordem_de_producao_produtos_utilizados ordem_de_producao_produtos_utilizados { get; set; }
        public virtual notas_canceladas notas_canceladas { get; set; }
        public virtual nota_fiscal nota_fiscal { get; set; }
        public virtual notas_de_origem notas_de_origem { get; set; }
        public virtual origem_do_produto origem_do_produto { get; set; }
        public virtual origem_do_produto_nota_fiscal origem_do_produto_nota_fiscal { get; set; }
        public virtual procedimento procedimento { get; set; }
        public virtual resultado_rebeneficio resultado_rebeneficio { get; set; }
        public virtual solicitacao_de_retirada solicitacao_de_retirada { get; set; }
        public virtual transferencia_produtos transferencia_produtos { get; set; }
        public virtual transferencia_produtos transferencia_produtos1 { get; set; }
        public virtual venda_prestacao_servico venda_prestacao_servico { get; set; }
        public virtual ICollection<premio_ft> premio_ft { get; set; }
        public virtual produtos_contabeis produtos_contabeis { get; set; }
    }
}

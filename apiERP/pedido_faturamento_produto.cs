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
    
    public partial class pedido_faturamento_produto
    {
        public int INT_ID { get; set; }
        public int INT_ID_PEDIDO { get; set; }
        public decimal DECIMAL_QTD { get; set; }
        public decimal DECIMAL_VLR_UN { get; set; }
        public decimal DECIMAL_JUROS { get; set; }
        public decimal DECIMAL_DESCONTO { get; set; }
        public decimal DECIMAL_FRETE { get; set; }
        public decimal DECIMAL_SEGURO { get; set; }
        public decimal DECIMAL_TOTAL { get; set; }
        public int INT_ID_CFOP { get; set; }
        public decimal DECIMAL_BC_ICMS { get; set; }
        public decimal DECIMAL_ICMS { get; set; }
        public decimal DECIMAL_ST { get; set; }
        public decimal DECIMAL_DIFAL { get; set; }
        public decimal DECIMAL_PIS { get; set; }
        public decimal DECIMAL_COFINS { get; set; }
        public decimal DECIMAL_IPI { get; set; }
        public decimal DECIMAL_PIS_ST { get; set; }
        public decimal DECIMAL_COFINS_ST { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public int INT_ID_PRODUTO { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public string TXT_INF_ADD { get; set; }
    
        public virtual funcionario funcionario { get; set; }
        public virtual padrao_de_imposto_por_cfop padrao_de_imposto_por_cfop { get; set; }
        public virtual pedido_faturamento pedido_faturamento { get; set; }
        public virtual produtos_contabeis produtos_contabeis { get; set; }
    }
}

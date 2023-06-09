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
    
    public partial class cotacao_resultado_itens
    {
        public cotacao_resultado_itens()
        {
            this.cotacao_compra_item = new HashSet<cotacao_compra_item>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_COTACAO_FORNECEDOR { get; set; }
        public int INT_UN_MEDIDA { get; set; }
        public decimal DECIMAL_VALOR_FRETE { get; set; }
        public decimal DECIMAL_VALOR_UNITARIO { get; set; }
        public decimal DECIMAL_VALOR_DESCONTO { get; set; }
        public decimal DECIMAL_ST { get; set; }
        public decimal DECIMAL_ICMS { get; set; }
        public decimal DECIMAL_IPI { get; set; }
        public decimal DECIMAL_DIFAL { get; set; }
        public System.DateTime DATE_PRAZO_ENTREGA { get; set; }
        public bool BOOL_FECHOU { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public Nullable<int> INT_ID_FORMA_ENTREGA { get; set; }
        public decimal DECIMAL_DESCONTO_FRETE { get; set; }
        public decimal DECIMAL_DIFAL_PORCENT { get; set; }
        public string TXT_OBS { get; set; }
    
        public virtual ICollection<cotacao_compra_item> cotacao_compra_item { get; set; }
        public virtual cotacao_item_fornecedor cotacao_item_fornecedor { get; set; }
        public virtual modalidade_entrega modalidade_entrega { get; set; }
        public virtual unidade_de_medida unidade_de_medida { get; set; }
    }
}
